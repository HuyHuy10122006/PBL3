using exambank.data;
using exambank.data.Models;
using exambank.logic.Service;
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
using static Azure.Core.HttpHeader;
using System.Linq;
using System.Diagnostics;

namespace exambank.ui
{
    public partial class UC_AICreate : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private GeminiService _aiService;
        private readonly DocumentService _docService = new DocumentService();
        private readonly LogService _logService = new LogService();
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
                }
            }
        }

        private void ProcessResult(string jsonResult)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    AllowTrailingCommas = true
                };

                var questions = JsonSerializer.Deserialize<List<QuestionModel>>(jsonResult, options);

                if (questions == null)
                {
                    return;
                }

                var now = DateTime.Now;

                foreach (var q in questions)
                {
                    // Chuẩn hóa đáp án
                    string answer = (q.Answer ?? "").Trim().ToUpper();
                    char ans = answer.FirstOrDefault(c => "ABCD".Contains(c));

                    // Bỏ qua câu thiếu dữ liệu quan trọng
                    if (string.IsNullOrWhiteSpace(q.Question) ||
                        string.IsNullOrWhiteSpace(q.OptionA) ||
                        string.IsNullOrWhiteSpace(q.OptionB) ||
                        string.IsNullOrWhiteSpace(q.OptionC) ||
                        string.IsNullOrWhiteSpace(q.OptionD) ||
                        ans == default)
                    {
                        continue;
                    }

                    q.Answer = ans.ToString();

                    // Metadata
                    q.Id = 0;
                    q.Subject = cbMonHoc.Text;
                    q.Grade = cbKhoi.Text;
                    q.Difficulty = cbDoKho.Text;
                    q.CategoryId = 1;
                    q.CreatedByUserId = _loginUser.Id;
                    q.CreatedAt = now;
                    q.IsActive = true;
                    q.IsAIGenerated = true;

                    _questionsCreate.Add(q);
                }
            }
            catch (Exception ex)
            {
                _questionsCreate.Clear();
                UIMessageBox.ShowError2($"Lỗi xử lý dữ liệu AI:\n{ex.Message}");
            }
        }

        private async void btnCreateQuestion_Click(object sender, EventArgs e)
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
                UIMessageBox.ShowWarning2("Vui lòng nhập thông tin đầy đủ và hợp lệ trên phần thiết lập câu hỏi!");
                return;
            }

            // 2. Thiết lập trạng thái UI
            btnCreateQuestion.Enabled = false;
            btnCreateQuestion.Text = "AI đang soạn câu hỏi...";

            try
            {
                _aiService = await Task.Run(() => new GeminiService());
                _questionsCreate.Clear();
                var now = DateTime.Now;
                // 3. Gọi AI để tạo câu hỏi
                string jsonResult = await _aiService.GenerateQuestionsAsync(inputData, (int)udtxtCountQuestion.IntValue);
                ProcessResult(jsonResult);

                // Ghi lại nhật ký sử dụng AI
                _logService.SaveCreateQuestion(now, _questionsCreate.Count, _loginUser.Username, _loginUser.Id);

                if (!string.IsNullOrWhiteSpace(jsonResult) && !jsonResult.StartsWith("Error"))
                {

                    // 4. Hiển thị kết quả
                    if (_questionsCreate.Count > 0)
                    {
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
                    UIMessageBox.ShowError2("AI không thể tạo được câu hỏi.");
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
                    Debug.WriteLine(ex);
                }
            }

            //Lưu file tài liệu nguồn
            if (successCount > 0 && tabSource.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                _logService.SaveSourceDocument(_loginUser.Id, txtFilePath.Text);
            }

            if (successCount == totalActive)
                UIMessageBox.ShowSuccess2($"Lưu tất cả {successCount} câu hỏi thành công!");
            else if (successCount > 0)
                UIMessageBox.ShowInfo2($"Chỉ lưu được {successCount} / {totalActive} câu hỏi.");
            else
                UIMessageBox.ShowError2("Lưu thất bại! Không có câu hỏi nào được lưu.");
        }
    }
}
