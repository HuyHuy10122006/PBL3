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
        
        private Label lblStatus;
        private Sunny.UI.UIUpDownTextBox udtxtCountTrueFalse;
        private Sunny.UI.UIUpDownTextBox udtxtCountShortAnswer;
        private Sunny.UI.UILabel uiLabelTrueFalse;
        private Sunny.UI.UILabel uiLabelShortAnswer;

        public UC_AICreate(UserModel loginUser)
        {
            _loginUser = loginUser;
            InitializeComponent();
            InitStatusLabel();
            InitAdditionalFields();
        }

        private void InitAdditionalFields()
        {
            // Rename existing label
            uiLabel7.Text = "Trắc nghiệm";

            // Add True/False Label
            uiLabelTrueFalse = new Sunny.UI.UILabel();
            uiLabelTrueFalse.Font = uiLabel7.Font;
            uiLabelTrueFalse.ForeColor = uiLabel7.ForeColor;
            uiLabelTrueFalse.Location = new Point(6, 216);
            uiLabelTrueFalse.Size = new Size(142, 35);
            uiLabelTrueFalse.Text = "Đúng / Sai";
            uiLabelTrueFalse.BackColor = Color.White;
            pnlCauHinh.Controls.Add(uiLabelTrueFalse);

            // Add True/False UpDownTextBox
            udtxtCountTrueFalse = new Sunny.UI.UIUpDownTextBox();
            udtxtCountTrueFalse.Font = udtxtCountQuestion.Font;
            udtxtCountTrueFalse.Location = new Point(155, 216);
            udtxtCountTrueFalse.Size = new Size(206, 36);
            udtxtCountTrueFalse.TextAlignment = ContentAlignment.MiddleRight;
            udtxtCountTrueFalse.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtxtCountTrueFalse.DoubleStep = 1D;
            udtxtCountTrueFalse.Text = "0";
            pnlCauHinh.Controls.Add(udtxtCountTrueFalse);

            // Add Short Answer Label
            uiLabelShortAnswer = new Sunny.UI.UILabel();
            uiLabelShortAnswer.Font = uiLabel7.Font;
            uiLabelShortAnswer.ForeColor = uiLabel7.ForeColor;
            uiLabelShortAnswer.Location = new Point(6, 256);
            uiLabelShortAnswer.Size = new Size(142, 35);
            uiLabelShortAnswer.Text = "Trả lời ngắn";
            uiLabelShortAnswer.BackColor = Color.White;
            pnlCauHinh.Controls.Add(uiLabelShortAnswer);

            // Add Short Answer UpDownTextBox
            udtxtCountShortAnswer = new Sunny.UI.UIUpDownTextBox();
            udtxtCountShortAnswer.Font = udtxtCountQuestion.Font;
            udtxtCountShortAnswer.Location = new Point(155, 256);
            udtxtCountShortAnswer.Size = new Size(206, 36);
            udtxtCountShortAnswer.TextAlignment = ContentAlignment.MiddleRight;
            udtxtCountShortAnswer.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtxtCountShortAnswer.DoubleStep = 1D;
            udtxtCountShortAnswer.Text = "0";
            pnlCauHinh.Controls.Add(udtxtCountShortAnswer);

            // Increase panel height to fit new controls
            int moveDown = 85;
            pnlCauHinh.Height += moveDown;
            
            // Push button down further, but don't move lblStatus down
            btnCreateQuestion.Top += moveDown;
        }

        private void InitStatusLabel()
        {
            lblStatus = new Label();
            lblStatus.Text = "";
            lblStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.AutoSize = false;
            lblStatus.Width = pnlNguonDuLieu.Width;
            lblStatus.Height = 40;
            
            // Adjust layout to make room for the status label
            int moveDown = 20;
            pnlCauHinh.Top += moveDown;
            btnCreateQuestion.Top += moveDown;

            lblStatus.Location = new Point(pnlNguonDuLieu.Left, pnlNguonDuLieu.Bottom + 5);
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            pnlLeft.Controls.Add(lblStatus);
            lblStatus.BringToFront();
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

        private async void btnSelectFile_Click(object sender, EventArgs e)
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
                    
                    btnSelectFile.Enabled = false;
                    lblStatus.ForeColor = Color.Blue;
                    lblStatus.Text = "Đang phân tích file...";

                    try
                    {
                        // Chỉ trích xuất 5 trang đầu tiên để AI nhận diện môn học và khối lớp nhanh hơn
                        string text = await Task.Run(() => _docService.ExtractTextFromPdf(ofd.FileName, 5));
                        string analyzeContent = string.IsNullOrWhiteSpace(text) ? $"Tên file tài liệu: {Path.GetFileName(ofd.FileName)}" : $"Tên file tài liệu: {Path.GetFileName(ofd.FileName)}\nNội dung: {text}";

                        var aiService = new GeminiService();
                        string result = await aiService.AnalyzeDocumentAsync(analyzeContent);
                        if (!string.IsNullOrWhiteSpace(result))
                        {
                            using (JsonDocument doc = JsonDocument.Parse(result))
                            {
                                var root = doc.RootElement;
                                bool isSgk = true; 
                                if (root.TryGetProperty("IsSGK", out JsonElement isSgkProp))
                                {
                                    if (isSgkProp.ValueKind == JsonValueKind.True || isSgkProp.ValueKind == JsonValueKind.False)
                                        isSgk = isSgkProp.GetBoolean();
                                }
                                
                                string grade = "";
                                if (root.TryGetProperty("Grade", out JsonElement gradeProp) && gradeProp.ValueKind == JsonValueKind.String)
                                {
                                    grade = gradeProp.GetString();
                                    if (!string.IsNullOrWhiteSpace(grade) && cbKhoi.Items.Contains(grade))
                                    {
                                        cbKhoi.SelectedItem = grade;
                                    }
                                }

                                string subject = "";
                                if (root.TryGetProperty("Subject", out JsonElement subjectProp) && subjectProp.ValueKind == JsonValueKind.String)
                                {
                                    subject = subjectProp.GetString();
                                    if (!string.IsNullOrWhiteSpace(subject) && cbMonHoc.Items.Contains(subject))
                                    {
                                        cbMonHoc.SelectedItem = subject;
                                    }
                                }

                                if (!isSgk)
                                {
                                    lblStatus.ForeColor = Color.Red;
                                    lblStatus.Text = "Cảnh báo: File không giống định dạng Sách Giáo Khoa\nhoặc không rõ môn học";
                                }
                                else
                                {
                                    lblStatus.ForeColor = Color.Green;
                                    if (string.IsNullOrWhiteSpace(text))
                                    {
                                        lblStatus.Text = $"Nhận diện từ tên file: {(string.IsNullOrWhiteSpace(subject) ? "không rõ môn" : subject)} - {(string.IsNullOrWhiteSpace(grade) ? "không rõ lớp" : grade)}";
                                    }
                                    else
                                    {
                                        lblStatus.Text = $"Đã nhận diện: SGK {(string.IsNullOrWhiteSpace(subject) ? "không rõ môn" : subject)} - {(string.IsNullOrWhiteSpace(grade) ? "không rõ lớp" : grade)}";
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(text))
                            {
                                lblStatus.ForeColor = Color.Red;
                                lblStatus.Text = "File rỗng hoặc không thể trích xuất chữ (có thể là file ảnh/scan).";
                            }
                            else
                            {
                                lblStatus.ForeColor = Color.Red;
                                lblStatus.Text = "Không thể nhận diện tài liệu.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi phân tích tài liệu: " + ex.Message);
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Lỗi phân tích tài liệu.";
                    }
                    finally
                    {
                        btnSelectFile.Enabled = true;
                    }
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

                    // Đảm bảo không bị null
                    q.OptionA = q.OptionA ?? "";
                    q.OptionB = q.OptionB ?? "";
                    q.OptionC = q.OptionC ?? "";
                    q.OptionD = q.OptionD ?? "";

                    // Bỏ qua câu thiếu dữ liệu quan trọng (chỉ bắt buộc Question và OptionA vì Option B,C,D có thể rỗng đối với câu T/F hoặc Trả lời ngắn)
                    if (string.IsNullOrWhiteSpace(q.Question) ||
                        string.IsNullOrWhiteSpace(q.OptionA) ||
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
            if ((udtxtCountQuestion.IntValue < 1 && udtxtCountTrueFalse.IntValue < 1 && udtxtCountShortAnswer.IntValue < 1) || string.IsNullOrWhiteSpace(cbMonHoc.Text)
                || string.IsNullOrWhiteSpace(cbDoKho.Text) || string.IsNullOrWhiteSpace(cbKhoi.Text))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập thông tin đầy đủ và hợp lệ trên phần thiết lập câu hỏi (cần ít nhất 1 câu hỏi)!");
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
                string jsonResult = await _aiService.GenerateQuestionsAsync(inputData, (int)udtxtCountQuestion.IntValue, (int)udtxtCountTrueFalse.IntValue, (int)udtxtCountShortAnswer.IntValue, cbMonHoc.Text, cbKhoi.Text);
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
