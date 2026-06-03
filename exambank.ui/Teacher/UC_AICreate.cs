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
        private readonly QuestionService _questionService = new QuestionService();
        private readonly ExamService _examService = new ExamService();
        private List<QuestionModel> _questionsCreate = new List<QuestionModel>();
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
                UC_Question uc = new UC_Question(item, $"Câu {i + 1}");
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
                cbKhoi.Items.AddRange(Constants.List_Khoi);
                cbDoKho.Items.AddRange(Constants.List_DoKho);
                cbMonHoc.Items.AddRange(Constants.List_MonHoc);
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
                ofd.Title = "Chọn tài liệu nguồn để tạo câu hỏi";

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
                _questionsCreate = JsonSerializer.Deserialize<List<QuestionModel>>(jsonResult, options) ?? new List<QuestionModel>();
                var now = DateTime.Now;
                // Chuẩn hóa dữ liệu từng câu hỏi để khớp với ràng buộc của QuestionModel
                foreach (var q in _questionsCreate)
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

                    // 3. Gán Metadata
                    q.Id = 0;
                    q.Subject = string.IsNullOrWhiteSpace(cbMonHoc.Text) ? "..." : cbMonHoc.Text;
                    q.Difficulty = string.IsNullOrWhiteSpace(cbDoKho.Text) ? "..." : cbDoKho.Text;
                    q.Grade = string.IsNullOrWhiteSpace(cbKhoi.Text) ? "..." : cbKhoi.Text;
                    q.CategoryId = 1;
                    q.CreatedByUserId = _loginUser.Id;
                    q.CreatedAt = now;
                    q.IsActive = true;
                    q.IsAIGenerated = true;
                }
            }
            catch (JsonException ex)
            {
                UIMessageBox.ShowError2("Lỗi khi xử lý dữ liệu từ AI: " + ex.Message);
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

            //Kiểm tra phần thiết lập đề thi có hợp lệ không trước khi gọi API
            if (udtxtCountQuestion.IntValue < 1 || string.IsNullOrWhiteSpace(cbMonHoc.Text)
                || string.IsNullOrWhiteSpace(cbDoKho.Text) || string.IsNullOrWhiteSpace(cbKhoi.Text))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập đầy đủ thông tin thiết lập câu hỏi!");
                return;
            }

            // 2. Thiết lập trạng thái UI
            btnCreateQuestion.Enabled = false;
            btnCreateQuestion.Text = "AI đang soạn câu hỏi...";

            try
            {
                _questionsCreate.Clear();
                var now = DateTime.Now;
                // 3. GỌI AI VÀ XỬ LÝ DỮ LIỆU
                string jsonResult = await _aiService.GenerateQuestionsAsync(inputData, (int)udtxtCountQuestion.IntValue);
                FixJson(jsonResult);

                if (!string.IsNullOrWhiteSpace(jsonResult) && !jsonResult.StartsWith("Error"))
                {

                    // 4. Hiển thị kết quả
                    if (_questionsCreate.Count > 0)
                    {
                        string MonHoc = string.IsNullOrWhiteSpace(cbMonHoc.Text) ? "..." : cbMonHoc.Text;
                        LoadQuestions(_questionsCreate);
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
                btnCreateQuestion.Enabled = true;
                btnCreateQuestion.Text = "TẠO CÂU HỎI";
            }
        }

        //Xóa câu hỏi có isActive = false trước khi lưu hoặc xuất file
        private void  RefineQuestions()
        {
            _questionsCreate = _questionsCreate.Where(q => q.IsActive).ToList();
        }

        private async void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (!_questionsCreate.Any())
            {
                UIMessageBox.ShowWarning2("Không có câu hỏi nào.");
                return;
            }

            RefineQuestions();
            int successCount = 0;
            int totalActive = _questionsCreate.Count(q => q.IsActive);

            foreach (var question in _questionsCreate)
            {
                if (question.IsActive == false) continue;
                try
                {
                    bool isSuccess = await _questionService.AddQuestionAsync(question);
                    if (isSuccess) successCount++;
                }
                catch (Exception ex)
                {
                    // Lấy lỗi chi tiết nhất có thể
                    string errorMsg = ex.InnerException?.InnerException?.Message
                        ?? ex.InnerException?.Message
                        ?? ex.Message;
                    UIMessageBox.ShowError2($"Lỗi khi lưu câu hỏi (đã lưu {successCount}/{totalActive}):\n{errorMsg}");
                    Debug.WriteLine(ex);
                    return; // Dừng lại, không tiếp tục lưu
                }
            }

            if (successCount > 0 && tabSource.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                try
                {
                    using (var db = new ExamBankDbContext())
                    {
                        string tenFile = System.IO.Path.GetFileName(txtFilePath.Text);

                        var tonTai = db.Documents.FirstOrDefault(d => d.FileName == tenFile && d.UserId == _loginUser.Id);

                        if (tonTai == null)
                        {
                            string loaiFile = System.IO.Path.GetExtension(txtFilePath.Text);
                            var taiLieuMoi = new DocumentModel
                            {
                                FileName = tenFile,
                                DocumentType = loaiFile,
                                UserId = _loginUser.Id,
                                UploadedAt = DateTime.Now,
                                IsActive = true,
                                FilePath = txtFilePath.Text
                            };

                            db.Documents.Add(taiLieuMoi);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            // --- KẾT THÚC ĐOẠN CODE LƯU TÀI LIỆU ---

            if (successCount == totalActive)
                UIMessageBox.ShowSuccess2($"Lưu tất cả {successCount} câu hỏi thành công!");
            else if (successCount > 0)
                UIMessageBox.ShowInfo2($"Chỉ lưu được {successCount} / {totalActive} câu hỏi.");
            else
                UIMessageBox.ShowError2("Lưu thất bại! Không có câu hỏi nào được lưu.");
        }
    }
}
