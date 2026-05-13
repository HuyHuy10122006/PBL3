using exambank.data;
using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using System.Linq;
using System.Diagnostics;

namespace exambank.ui
{
    public partial class UC_AICreate : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly GeminiService _aiService = new GeminiService();
        private readonly DocumentService _docService = new DocumentService();
        private readonly QuestionService _questionService = new QuestionService(); //Test
        private readonly ExamService _examService = new ExamService(); //Test
        private List<QuestionModel> _questions;
        public UC_AICreate(UserModel loginUser)
        {
            _loginUser = loginUser;
            InitializeComponent();
        }

        private void UC_AICreate_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        public void LoadQuestions(List<QuestionModel> questions)
        {
            flpPreview.SuspendLayout();
            foreach (Control c in flpPreview.Controls)
            {
                c.Dispose();
            }
            flpPreview.Controls.Clear();

            for (int i = 0; i < questions.Count; i++)
            {
                var item = questions[i];
                UC_Question uc = new UC_Question();
                uc.SetData(item, $"Câu {i + 1}");
                uc.Width = flpPreview.ClientSize.Width - (flpPreview.Padding.Left + flpPreview.Padding.Right + 10);
                uc.Margin = new Padding(0, 0, 0, 20);
                flpPreview.Controls.Add(uc);
            }
            flpPreview.ResumeLayout(true);
        }

        private void LoadComboBoxData()
        {
            try
            {
                cbKhoi.Items.AddRange(Constants.List_Khoi.ToArray());
                cbDoKho.Items.AddRange(Constants.List_DoKho.ToArray());
                cbMonHoc.Items.AddRange(Constants.List_MonHoc.ToArray());
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Có lỗi khi khởi tạo dữ liệu: " + ex.Message);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Thiết lập bộ lọc file
                ofd.Filter = "Document Files|*.pdf";
                ofd.Title = "Chọn tài liệu nguồn để tạo đề thi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn lên TextBox
                    txtFilePath.Text = ofd.FileName;
                    UIMessageTip.ShowOk("Chọn file thành công.");
                    // logic đọc nội dung file...
                }
            }
        }

        private void FixJson(string jsonResult)
        {
            // Sử dụng tùy chọn giải mã linh hoạt để tránh lỗi định dạng JSON cơ bản
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true // Chấp nhận dấu phẩy thừa ở cuối mảng JSON
            };
            try
            {
                // Giải mã JSON thành List<QuestionModel>[cite: 2, 8]
                _questions = JsonSerializer.Deserialize<List<QuestionModel>>(jsonResult, options) ?? new List<QuestionModel>();
                var now = DateTime.Now;
                // Chuẩn hóa dữ liệu từng câu hỏi để khớp với ràng buộc của QuestionModel
                foreach (var q in _questions)
                {
                    // 1. Xử lý triệt để thuộc tính Answer (Phải là A, B, C hoặc D và độ dài = 1)
                    if (string.IsNullOrWhiteSpace(q.Answer))
                    {
                        q.Answer = "A"; // Gán mặc định nếu trống
                    }
                    else
                    {
                        string ans = q.Answer.Trim().ToUpper();

                        // Xử lý trường hợp AI trả về "Option A" hoặc chuỗi dài
                        if (ans.Contains("OPTION"))
                        {
                            // Tìm ký tự A, B, C, D trong chuỗi
                            if (ans.Contains("A")) ans = "A";
                            else if (ans.Contains("B")) ans = "B";
                            else if (ans.Contains("C")) ans = "C";
                            else if (ans.Contains("D")) ans = "D";
                        }

                        // Đảm bảo chỉ lấy 1 ký tự duy nhất để không vi phạm [MaxLength(1)][cite: 2]
                        if (ans.Length > 1) ans = ans.Substring(0, 1);

                        // Kiểm tra cuối cùng trước khi gán để khớp với RegularExpression ^[ABCD]$[cite: 2]
                        if (ans != "A" && ans != "B" && ans != "C" && ans != "D")
                        {
                            q.Answer = "A";
                        }
                        else
                        {
                            q.Answer = ans;
                        }
                    }

                    // 2. Đảm bảo các thuộc tính bắt buộc khác không bị NULL (Tránh lỗi UI/Database)[cite: 2]
                    if (string.IsNullOrWhiteSpace(q.Question)) q.Question = "N/A";
                    q.OptionA ??= "";
                    q.OptionB ??= "";
                    q.OptionC ??= "";
                    q.OptionD ??= "";

                    // 3. Gán Metadata[cite: 2]
                    q.Subject = string.IsNullOrWhiteSpace(cbMonHoc.Text) ? "..." : cbMonHoc.Text;
                    q.Difficulty = string.IsNullOrWhiteSpace(cbDoKho.Text) ? "..." : cbDoKho.Text;
                    q.CategoryId = 1;
                    q.CreatedByUserId = _loginUser.Id;
                    q.CreatedAt = now;
                    q.IsActive = true;
                }
            }
            catch (JsonException ex)
            {
                UIMessageBox.ShowError2("Lỗi khi xử lý dữ liệu từ AI: " + ex.Message);
                _questions = new List<QuestionModel>();
            }
        }

        private async void btnCreateExam_Click(object sender, EventArgs e)
        {
            string inputData = "";

            // 1. Kiểm tra nguồn dữ liệu dựa trên Tab đang chọn
            if (tabSource.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtFilePath.Text))
                {
                    UIMessageBox.ShowWarning2("Vui lòng chọn file tài liệu trước!");
                    return;
                }
                try
                {
                    if (!File.Exists(txtFilePath.Text))
                    {
                        UIMessageBox.ShowWarning2("File không tồn tại hoặc không thể truy cập.");
                        return;
                    }
                    inputData = _docService.ExtractTextFromPdf(txtFilePath.Text);
                }
                catch (Exception exFile)
                {
                    UIMessageBox.ShowError2("Không thể đọc file: " + exFile.Message);
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtText.Text))
                {
                    UIMessageBox.ShowWarning2("Vui lòng nhập nội dung văn bản trước!");
                    return;
                }
                inputData = txtText.Text;
            }

            //Kiểm tra số câu hỏi và thời gian có hợp lệ không
            if (iudSL.Value < 1 || iudTG.Value < 1)
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập số câu hỏi và thời gian làm bài hợp lệ!");
                return;
            }

            // 2. Thiết lập trạng thái UI
            btnCreateExam.Enabled = false;
            btnCreateExam.Text = "AI đang soạn đề...";

            try
            {
                var now = DateTime.Now;
                // 3. GỌI AI VÀ XỬ LÝ DỮ LIỆU
                string jsonResult = await _aiService.GenerateQuestionsAsync(inputData, (int)iudSL.Value);
                FixJson(jsonResult);

                if (!string.IsNullOrWhiteSpace(jsonResult) && !jsonResult.StartsWith("Error"))
                {

                    // 4. Hiển thị kết quả
                    if (_questions.Count > 0)
                    {
                        string MonHoc = string.IsNullOrWhiteSpace(cbMonHoc.Text) ? "..." : cbMonHoc.Text;
                        LoadQuestions(_questions);
                        txtExamName.Text = $"Đề thi {MonHoc} - {now:ddMMyyyyHHmmss}";
                        txtExamCode.Text = now.ToString("ddMMyyyyHHmmss");
                    }
                    else
                    {
                        UIMessageBox.ShowWarning2("AI trả về dữ liệu trống hoặc không đúng định dạng.");
                    }
                }
                else
                {
                    // Hiển thị lỗi từ API nếu có
                    UIMessageBox.ShowError2(jsonResult ?? "AI không thể tạo được câu hỏi.");
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Lỗi hệ thống: " + ex.Message);
            }
            finally
            {
                btnCreateExam.Enabled = true;
                btnCreateExam.Text = "TẠO ĐỀ THI";
            }
        }

        private ExamModel CreateExam()
        {
            var exam = new ExamModel
            {
                Subject = string.IsNullOrWhiteSpace(cbMonHoc.Text) ? "..." : cbMonHoc.Text,
                Duration = (int)iudTG.Value,
                Title = txtExamName.Text,
                ExamCode = txtExamCode.Text,
                TotalQuestions = _questions?.Count ?? 0,
                CreatedByUserId = _loginUser.Id,
                CreatedAt = DateTime.Now
            };
            return exam;
        }

        //Xóa câu hỏi có isActive = false trước khi lưu hoặc xuất file
        private void  FilterQuestions()
        {
            _questions = _questions.Where(q => q.IsActive).ToList();
        }


        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (_questions == null || !_questions.Any())
            {
                UIMessageBox.ShowWarning2("Không có câu hỏi nào.");
                return;
            }
            FilterQuestions();

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Document|*.docx";
                saveFileDialog.Title = "Lưu đề thi ra file Word";
                // Lấy tên đề thi từ TextBox để đặt tên file mặc định
                saveFileDialog.FileName = $"{txtExamName.Text}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExamModel _currentExam = CreateExam();
                        //Kiểm tra Tên đề, mã đề có hợp lệ không trước khi xuất file
                        if (string.IsNullOrWhiteSpace(_currentExam.Title) || string.IsNullOrWhiteSpace(_currentExam.ExamCode))
                        {
                            UIMessageBox.ShowWarning2("Tên đề thi hoặc mã đề thi không hợp lệ.");
                            return;
                        }

                        var docService = new DocumentService();

                        // Chạy tác vụ xuất file trên một luồng khác để tránh treo UI nếu file nặng
                        await Task.Run(() =>
                        {
                            docService.ExportToWord(saveFileDialog.FileName, _currentExam, _questions);
                        });

                        UIMessageBox.ShowSuccess2("Xuất file Word thành công!");
                    }
                    catch (Exception ex)
                    {
                        UIMessageBox.ShowError2($"Lỗi khi xuất file Word: {ex.Message}");
                    }
                }
            }
        }


        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (_questions == null || !_questions.Any())
            {
                UIMessageBox.ShowWarning2("Không có câu hỏi nào.");
                return;
            }

            int successCount = 0;
            foreach (var question in _questions)
            {
                if (question.IsActive == false) continue;
                try
                {
                    bool isSuccess = _questionService.AddQuestion(question);
                    if (isSuccess) successCount++;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            int totalActive = _questions.Count(q => q.IsActive);
            if (successCount == totalActive)
                UIMessageBox.ShowSuccess2("Lưu tất cả câu hỏi thành công!");
            else if (successCount > 0)
                UIMessageBox.ShowInfo2($"Chỉ lưu được {successCount} / {totalActive} câu hỏi.");
            else
                UIMessageBox.ShowError2("Lưu thất bại! Có thể các câu hỏi đã được lưu trước đó.");
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (_questions == null || _questions.Count == 0)
            {
                UIMessageBox.ShowWarning2("Không có câu hỏi nào.");
                return;
            }
            FilterQuestions();
            ExamModel _currentExam = CreateExam();
            //Kiểm tra Tên đề, mã đề có hợp lệ không trước khi xuất file
            if (string.IsNullOrWhiteSpace(_currentExam.Title) || string.IsNullOrWhiteSpace(_currentExam.ExamCode))
            {
                UIMessageBox.ShowWarning2("Tên đề thi hoặc mã đề thi không hợp lệ.");
                return;
            }

            try
            {
                bool isSaved = _examService.CreateExam(_currentExam, _questions);
                if (isSaved)
                    UIMessageBox.ShowSuccess2("Lưu đề thi thành công!");
                else
                    UIMessageBox.ShowError2("Lưu đề thi thất bại! Kiểm tra lại dữ liệu hoặc kết nối.");
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Lỗi khi lưu đề thi: " + ex.Message);
            }
        }
    }
}
