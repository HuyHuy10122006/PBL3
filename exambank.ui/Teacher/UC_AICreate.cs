using exambank.data;
using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
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
using exambank.ui.LogicTest;

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

        public async void LoadQuestions(List<QuestionModel> questions)
        {
            flpPreview.SuspendLayout();
            flpPreview.Controls.Clear();

            foreach (var item in questions)
            {
                UC_Question uc = new UC_Question();
                uc.SetData(item, $"Câu {questions.IndexOf(item) + 1}");

                // Đảm bảo UC luôn khít chiều ngang của Panel cha
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
                // 1. Nạp dữ liệu Khối
                cbKhoi.Items.Clear();
                cbKhoi.Items.AddRange(Constants.List_Khoi.ToArray());

                // 2. Nạp dữ liệu Độ khó
                cbDoKho.Items.Clear();
                cbDoKho.Items.AddRange(Constants.List_DoKho.ToArray());

                // 3. Nạp dữ liệu Môn học
                cbMonHoc.Items.Clear();
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
                ofd.Filter = "Document Files|*.pdf;*.docx;*.txt|All Files|*.*";
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

        private async void btnCreateExam_Click(object sender, EventArgs e)
        {
            string inputData = "";

            // 1. Kiểm tra nguồn dữ liệu dựa trên Tab đang chọn (Giữ nguyên)
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

            // 2. Thiết lập trạng thái UI (Giữ nguyên)
            btnCreateExam.Enabled = false;
            btnCreateExam.Text = "AI đang soạn đề...";

            try
            {
                // Thu thập cấu hình từ UI
                string monHoc = cbMonHoc.Text;
                string doKho = cbDoKho.Text;
                int soCau = (int)iudSL.Value;

                // 3. GỌI AI VÀ XỬ LÝ DỮ LIỆU (PHẦN THAY ĐỔI)
                string jsonResult = await _aiService.GenerateQuestionsAsync(inputData, soCau);

                if (!string.IsNullOrWhiteSpace(jsonResult) && !jsonResult.StartsWith("Error"))
                {
                    // Sử dụng tùy chọn giải mã linh hoạt để tránh lỗi định dạng JSON cơ bản
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        AllowTrailingCommas = true // Chấp nhận dấu phẩy thừa ở cuối mảng JSON
                    };

                    // Giải mã JSON thành List<QuestionModel>[cite: 2, 8]
                    _questions = JsonSerializer.Deserialize<List<QuestionModel>>(jsonResult, options) ?? new List<QuestionModel>();

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
                        q.Subject = monHoc;
                        q.Difficulty = doKho;
                        q.CategoryId = 1;
                        q.CreatedByUserId = _loginUser.Id;
                        q.CreatedAt = DateTime.Now;
                        q.IsActive = true;
                    }

                    // 4. Hiển thị kết quả
                    if (_questions.Count > 0)
                        {
                            LoadQuestions(_questions);
                            txtExamName.Text = $"Đề thi {monHoc} - {DateTime.Now:ddMMyyyy}";
                        }
                        else
                        {
                            UIMessageBox.ShowWarning2("AI trả về dữ liệu trống hoặc không đúng định dạng.");
                        }
                    }
                    else
                    {
                        // Hiển thị lỗi từ API nếu có (VD: Rate limit, Overload)
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (_questions == null || _questions.Count == 0)
            {
                UIMessageBox.ShowInfo("Không có câu hỏi nào để lưu.");
                return;
            }

            int successCount = 0;
            foreach (var question in _questions)
            {
                try
                {
                    bool isSuccess = _questionService.AddQuestion(question);
                    if (isSuccess) successCount++;
                }
                catch
                {
                    // ignore per-question errors to continue saving others
                }
            }

            if (successCount == _questions.Count)
                MessageBox.Show("Lưu tất cả câu hỏi thành công!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (successCount > 0)
                MessageBox.Show($"Chỉ lưu được {successCount} / {_questions.Count} câu hỏi.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Lưu thất bại! Kiểm tra lại kết nối hoặc ràng buộc dữ liệu.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (_questions == null || _questions.Count == 0)
            {
                UIMessageBox.ShowInfo("Không có câu hỏi nào.");
                return;
            }
            string examName = txtExamName.Text.Trim();
            if (string.IsNullOrEmpty(examName))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập tên đề thi.");
                return;
            }
            // Tạo đối tượng ExamModel
            ExamModel exam = new ExamModel
            {
                Title = examName,
                TotalQuestions = _questions.Count,
                Subject = cbMonHoc.Text,
                Duration = (int)iudTG.Value,
                CreatedByUserId = _loginUser.Id
            };
            try
            {
                bool isSaved = _examService.CreateExam(exam, _questions.Select(q => q.Id).ToList());
                if (isSaved)
                    UIMessageTip.ShowOk("Lưu đề thi thành công!");
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
