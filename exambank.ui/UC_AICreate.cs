using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using exambank.logic;

namespace exambank.ui
{
    public partial class UC_AICreate : UserControl
    {
        private BindingList<exambank.data.Models.QuestionModel> listQuestions = new BindingList<exambank.data.Models.QuestionModel>();

        public UC_AICreate()
        {
            InitializeComponent();
            dgvQuestions.DataSource = listQuestions;
            dgvQuestions.Visible = false;

            dgvQuestions.DataBindingComplete += DgvQuestions_DataBindingComplete;
            dgvQuestions.DataError += DgvQuestions_DataError;
        }

        private void DgvQuestions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Tránh spam hộp thoại lỗi DataGridView
            e.ThrowException = false;
        }

        private void DgvQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] visibleCols = { "Id", "Question", "OptionA", "OptionB", "OptionC", "OptionD", "Answer" };
            foreach (DataGridViewColumn col in dgvQuestions.Columns)
            {
                if (Array.Exists(visibleCols, c => c == col.Name))
                {
                    col.Visible = true;
                }
                else
                {
                    col.Visible = false;
                }
            }
        }

        // Hàm dùng để nạp dữ liệu mẫu từ Class
        private void NapDuLieuChuong(List<string> danhSach)
        {
        }

        private void txtSelectedChuong_Click(object sender, EventArgs e)
        {
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
        }

        private void HienThiDuLieuMau()
        {
            var dsCauHoi = new List<dynamic>
            {
                new { ID = 1, NoiDung = "Phep bien doi nao sau day khong lam thay doi hinh dang doi tuong?", DapAn = new[] {"Tinh tien", "Ti le", "Bien dang", "Doi xung"}},
                new { ID = 2, NoiDung = "Trong he toa do WCS, truc dung thuong la truc nao?", DapAn = new[] {"Truc X", "Truc Y", "Truc Z", "Truc W"}},
                new { ID = 3, NoiDung = "Thuat toan Bresenham dung de ve duong gi?", DapAn = new[] {"Duong thang", "Duong tron", "Duong Ellipse", "Tat ca deu dung"}}
            };

            foreach (var item in dsCauHoi)
            {
                listQuestions.Add(new exambank.data.Models.QuestionModel
                {
                    Id = listQuestions.Count + 1, // Gán Id cho dữ liệu mẫu
                    Question = item.NoiDung,
                    OptionA = item.DapAn[0],
                    OptionB = item.DapAn[1],
                    OptionC = item.DapAn[2],
                    OptionD = item.DapAn[3],
                    Answer = "A"
                });
            }
        }

        private void UC_AICreate_Load(object sender, EventArgs e)
        {

        }

        private string _extractedText = "";

        private async void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lblUploadInfo.Text = "Đang đọc file...";
                        var docService = new DocumentService();
                        _extractedText = docService.ExtractTextFromPdf(ofd.FileName);
                        lblUploadInfo.Text = System.IO.Path.GetFileName(ofd.FileName);
                        lblUploadInfo.ForeColor = Color.Green;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file: {ex.Message}");
                        lblUploadInfo.Text = "Lỗi đọc file!";
                        lblUploadInfo.ForeColor = Color.Red;
                    }
                }
            }
        }

        private async void btnGenerateAI_Click(object sender, EventArgs e)
        {
            try
            {
                btnGenerate.Enabled = false;
                lblUploadInfo.Text = "Đang tạo câu hỏi bằng AI...";

                string textToAnalyze = _extractedText;

                // Nếu người dùng nhập vào TextBox thì dùng văn bản đó (kết hợp hoặc thay thế)
                textToAnalyze = _extractedText; // Currently using text from file

                if (string.IsNullOrWhiteSpace(textToAnalyze))
                {
                    MessageBox.Show("Vui lòng tải file lên hoặc nhập văn bản trước khi tạo.");
                    lblUploadInfo.Text = "Chưa có dữ liệu";
                    lblUploadInfo.ForeColor = Color.Red;
                    return;
                }

                // --------- GIỚI HẠN ĐỘ DÀI ĐẦU VÀO CAO NHẤT (INPUT TOKENS) ---------
                // Theo gợi ý: cắt bớt phần văn bản gửi cho AI để giảm Input Tokens
                // Giúp AI đọc hiểu nhanh hơn và tránh quá tải API (Too Many Requests).
                int maxLength = 3000; 
                if (textToAnalyze.Length > maxLength)
                {
                    textToAnalyze = textToAnalyze.Substring(0, maxLength);
                    Console.WriteLine($"Văn bản đã được cắt tới {maxLength} ký tự.");
                }
                // ---------------------------------------------------------------------

                int questionCount = 40; // Tạo 40 câu hỏi như yêu cầu

                var geminiService = new GeminiService();

                listQuestions.Clear();
                dgvQuestions.Visible = true;
                int totalCreated = 0;

                try 
                {
                    await foreach (string jsonResult in geminiService.GenerateQuestionsStreamAsync(textToAnalyze, questionCount))
                    {
                        if (string.IsNullOrWhiteSpace(jsonResult) || jsonResult == "[]") continue;

                        if (jsonResult.StartsWith("Error"))
                        {
                            MessageBox.Show($"Lỗi trong quá trình tạo câu hỏi:\n{jsonResult}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        string cleanJson = jsonResult.Trim();
                        int firstBracket = cleanJson.IndexOf('[');
                        int lastBracket = cleanJson.LastIndexOf(']');
                        if (firstBracket >= 0 && lastBracket > firstBracket) 
                        {
                            cleanJson = cleanJson.Substring(firstBracket, lastBracket - firstBracket + 1);
                        }
                        else
                        {
                            // Nếu không tìm thấy mảng JSON hợp lệ
                            continue;
                        }

                        var options = new System.Text.Json.JsonSerializerOptions { 
                            PropertyNameCaseInsensitive = true,
                            AllowTrailingCommas = true,
                            ReadCommentHandling = System.Text.Json.JsonCommentHandling.Skip,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
                        };
                        var questions = System.Text.Json.JsonSerializer.Deserialize<List<exambank.data.Models.QuestionModel>>(cleanJson, options);

                        if (questions != null && questions.Count > 0)
                        {
                            foreach (var qDict in questions)
                            {
                                if (string.IsNullOrWhiteSpace(qDict.Question)) qDict.Question = "N/A";
                                if (qDict.OptionA == null) qDict.OptionA = "";
                                if (qDict.OptionB == null) qDict.OptionB = "";
                                if (qDict.OptionC == null) qDict.OptionC = "";
                                if (qDict.OptionD == null) qDict.OptionD = "";

                                if (string.IsNullOrWhiteSpace(qDict.Answer)) 
                                {
                                    qDict.Answer = "A";
                                }
                                else
                                {
                                    string ans = qDict.Answer.Trim().ToUpper();
                                    if (ans.StartsWith("OPTION") && ans.Length > 6)
                                    {
                                        ans = ans.Substring(6, 1);
                                    }
                                    if (ans.Length > 1)
                                    {
                                        // Chỉ lấy ký tự đầu tiên
                                        ans = ans.Substring(0, 1);
                                    }
                                    if (ans != "A" && ans != "B" && ans != "C" && ans != "D") 
                                    {
                                        ans = "A";
                                    }
                                    qDict.Answer = ans;
                                }

                                qDict.Id = listQuestions.Count + 1; // Tạo ID hiển thị tăng dần bắt đầu từ 1

                                listQuestions.Add(qDict);
                                totalCreated++;
                            }

                            lblUploadInfo.Text = $"Đang tạo... ({totalCreated}/{questionCount} câu)";

                            // Kéo đến dòng cuối cùng để hiển thị tạo tới đâu thấy tới đó
                            if (dgvQuestions.Rows.Count > 0)
                            {
                                dgvQuestions.FirstDisplayedScrollingRowIndex = dgvQuestions.RowCount - 1;
                            }
                        }
                    }

                    if (totalCreated > 0)
                    {
                        MessageBox.Show($"Đã tạo thành công {totalCreated} câu hỏi!", "Thành công");
                        lblUploadInfo.Text = "Tạo câu hỏi hoàn tất!";
                        lblUploadInfo.ForeColor = Color.Blue;
                    }
                    else
                    {
                        MessageBox.Show($"Kết quả rỗng. Vui lòng kiểm tra lại phản hồi từ AI.", "Lỗi JSON Rỗng");
                        lblUploadInfo.Text = "Lỗi rỗng!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi trong quá trình xử lý stream:\n{ex.Message}", "Lỗi Phân Tích JSON");
                    lblUploadInfo.Text = "Lỗi stream AI!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                lblUploadInfo.Text = "Lỗi API!";
                lblUploadInfo.ForeColor = Color.Red;
            }
            finally
            {
                btnGenerate.Enabled = true;
            }
        }

        private async void btnSaveDb_Click(object sender, EventArgs e)
        {
            try
            {
                btnSaveDb.Enabled = false; // Ngăn người dùng click liên tục
                var questionsToSave = new List<exambank.data.Models.QuestionModel>();

                foreach (var item in listQuestions)
                {
                    if (string.IsNullOrWhiteSpace(item.Question)) continue;

                    var q = new exambank.data.Models.QuestionModel
                    {
                        Question = item.Question,
                        OptionA = item.OptionA ?? "",
                        OptionB = item.OptionB ?? "",
                        OptionC = item.OptionC ?? "",
                        OptionD = item.OptionD ?? "",
                        Answer = string.IsNullOrWhiteSpace(item.Answer) ? "A" : item.Answer,
                        CategoryId = 1, // Default category
                        CreatedByUserId = 1, // Default user
                        CreatedAt = DateTime.Now,
                        IsActive = true
                    };
                    questionsToSave.Add(q);
                }

                if (questionsToSave.Count == 0)
                {
                    MessageBox.Show("Không có câu hỏi hợp lệ nào để lưu!", "Thông báo");
                    return;
                }

                using (var db = new exambank.data.ExamBankDbContext())
                {
                    var repo = new exambank.data.DatabaseRepository(db);

                    // Lấy danh sách nội dung câu hỏi đã có trong Database để kiểm tra trùng lặp
                    var existingQuestions = new HashSet<string>(
                        db.Questions.Select(q => q.Question.Trim().ToLower())
                    );

                    var uniqueQuestionsToSave = new List<exambank.data.Models.QuestionModel>();
                    int duplicateCount = 0;

                    foreach (var q in questionsToSave)
                    {
                        var normalizedQuestion = q.Question.Trim().ToLower();
                        if (existingQuestions.Contains(normalizedQuestion))
                        {
                            duplicateCount++;
                        }
                        else
                        {
                            uniqueQuestionsToSave.Add(q);
                            existingQuestions.Add(normalizedQuestion); // Tránh trùng lặp ngay trong danh sách mới
                        }
                    }

                    if (uniqueQuestionsToSave.Count == 0)
                    {
                        MessageBox.Show($"Tất cả {duplicateCount} câu hỏi đều đã tồn tại trong Ngân hàng đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    await repo.AddQuestionsAsync(uniqueQuestionsToSave);

                    string msg = $"Đã lưu {uniqueQuestionsToSave.Count} câu hỏi mới vào cơ sở dữ liệu thành công!";
                    if (duplicateCount > 0)
                    {
                        msg += $"\nĐã bỏ qua {duplicateCount} câu hỏi vì đã tồn tại (trùng lặp).";
                    }

                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nChi tiết: {ex.InnerException.Message}" : "";
                MessageBox.Show($"Lỗi khi lưu Database: {ex.Message}{innerEx}", "Lỗi Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSaveDb.Enabled = true;
            }
        }
    }
}
