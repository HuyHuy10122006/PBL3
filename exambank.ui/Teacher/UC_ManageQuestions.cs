using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace exambank.ui
{
    public partial class UC_ManageQuestions : UserControl
    {
        private readonly UserModel _loginUser;
        private readonly QuestionService _questionService = new QuestionService();
        private readonly ExamService _examService = new ExamService();
        private List<QuestionModel> _currentQuestions;
        private bool _isBusy = false; // Cờ trạng thái bận

        public UC_ManageQuestions(UserModel loginUser, List<QuestionModel> questions)
        {
            _loginUser = loginUser;
            _currentQuestions = questions;
            InitializeComponent();
        }

        private void UC_ManageQuestions_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            dgvQuestions.AutoGenerateColumns = false;

            // Reload dữ liệu mỗi khi UC được hiển thị lại (chuyển tab)
            this.VisibleChanged += (s, args) =>
            {
                if (this.Visible)
                {
                    LoadDataTable();
                }
            };
        }

        // Nạp dữ liệu vào ComboBox
        private void InitFilterDataAsync(List<QuestionModel> data)
        {
            List<string> subjects = _questionService.GetCboValuesAsync(data, q => q.Subject);
            subjects.Insert(0, "Tất cả");
            cbMonHoc.DataSource = subjects;

            List<string> grades = _questionService.GetCboValuesAsync(data, q => q.Grade);
            grades.Insert(0, "Tất cả");
            cbKhoi.DataSource = grades;

            List<string> difficulties = Constants.List_DoKho.ToList();
            difficulties.Insert(0, "Tất cả");
            cbDoKho.DataSource = difficulties;
        }

        // Nạp dữ liệu vào DataGridView
        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _questionService.GetQuestionsAsync(_loginUser.Id));
            _currentQuestions.Clear();
            foreach (var item in newData)
            {
                _currentQuestions.Add(item);
            }
            InitFilterDataAsync(_currentQuestions);
            BindGrid(_currentQuestions);
        }

        private void BindGrid(List<QuestionModel> data)
        {
            var displayList = data.Select(q => new
            {
                ID = q.Id,
                STT = data.IndexOf(q) + 1,
                Content = q.Question,
                MonHoc = q.Subject,
                Khoi = q.Grade,
                DoKho = q.Difficulty
            }).ToList();
            dgvQuestions.DataSource = displayList;
        }


        // Sự kiện khi Click vào Grid
        private async void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra điều kiện biên và trạng thái đang bận
            if (e.RowIndex < 0 || dgvQuestions.Rows[e.RowIndex].IsNewRow) return;
            if (_isBusy) return;

            try
            {
                _isBusy = true;

                // 2. Hiển thị chi tiết câu hỏi
                var cellValue = dgvQuestions.Rows[e.RowIndex].Cells["colID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int qId))
                {
                    var question = _currentQuestions.FirstOrDefault(q => q.Id == qId);
                    if (question != null)
                    {
                        ShowDetail(question);
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Có lỗi xảy ra: {ex.Message}");
            }
            finally
            {
                // Chờ một khoảng thời gian cực ngắn để UI kịp phản hồi trước khi mở khóa
                await Task.Delay(50);
                _isBusy = false;
            }
        }

        private void ShowDetail(QuestionModel q)
        {
            // Kiểm tra xem có cần Invoke để chuyển về luồng chính không
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowDetail(q)));
                return;
            }

            try
            {
                flpQuestion.SuspendLayout(); // Tạm dừng vẽ để tránh lỗi Handle

                // Giải phóng Control cũ
                foreach (Control ctrl in flpQuestion.Controls)
                {
                    ctrl.Dispose();
                }
                flpQuestion.Controls.Clear();

                UC_Question uc = new UC_Question(q, $"ID: {q.Id}");
                uc.isFull(true);
                uc.Width = flpQuestion.ClientSize.Width - 20;
                flpQuestion.Controls.Add(uc);
            }
            finally
            {
                flpQuestion.ResumeLayout(true); // Tiếp tục vẽ giao diện
            }
        }

        // Sự kiện khi nhấn nút Làm mới
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataTable();
            flpQuestion.Controls.Clear();
        }


        // Nút Lưu
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Nếu không có UC_Question nào đang hiển thị
            if (flpQuestion.Controls.Count == 0)
            {
                UIMessageTip.ShowWarning("Không tìm thấy câu hỏi nào đang hiển thị.");
                return;
            }

            try
            {
                // Duyệt trong flpQuestion lấy UC_Question hiện tại và gọi hàm Save
                foreach (Control ctrl in flpQuestion.Controls)
                {
                    if (ctrl is UC_Question uc)
                    {
                        //GetData() trả về QuestionModel
                        var updated = uc.GetData();
                        if (updated == null)
                        {
                            UIMessageBox.ShowError2("Không tìm thấy câu hỏi để lưu.");
                        }
                        if (updated != null && await _questionService.UpdateQuestionAsync(updated))
                        {
                            UIMessageBox.ShowSuccess2("Lưu câu hỏi thành công.");
                            LoadDataTable();
                        }
                        else UIMessageBox.ShowError2("Lưu thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Lỗi khi lưu câu hỏi." + ex.Message);
            }
        }

        private async void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            //Nếu không có UC_Question nào đang hiển thị
            if (flpQuestion.Controls.Count == 0)
            {
                UIMessageTip.ShowWarning("Không tìm thấy câu hỏi nào đang hiển thị.");
                return;
            }

            // Duyệt trong flpQuestion lấy UC_Question hiện tại và gọi hàm Save
            foreach (Control ctrl in flpQuestion.Controls)
            {
                if (ctrl is UC_Question uc)
                {
                    // GetData() trả về QuestionModel
                    var updated = uc.GetData();
                    if (updated == null)
                    {
                        UIMessageBox.ShowError2("Không tìm thấy câu hỏi để xóa.");
                    }
                    if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa câu hỏi này?"))
                    {
                        if (updated != null && await _questionService.DeleteMultipleAsync(new List<int> { updated.Id }))
                        {
                            UIMessageTip.ShowOk("Đã xóa thành công.");
                            LoadDataTable();
                            flpQuestion.Controls.Clear();
                        }
                    }
                }
            }
        }

        // Sự kiện khi nhấn nút Xóa câu hỏi đã chọn
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvQuestions.SelectedRows;
            if (selectedRows.Count == 0) return;

            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa {selectedRows.Count} câu hỏi này?"))
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow row in selectedRows)
                {
                    ids.Add((int)row.Cells["colID"].Value);
                }

                if (await _questionService.DeleteMultipleAsync(ids))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công!");
                    LoadDataTable();
                    flpQuestion.Controls.Clear();
                }
            }
        }

        private async void btnTaoDe_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có câu hỏi nào được chọn không
            var selectedRows = dgvQuestions.SelectedRows;
            if (selectedRows.Count == 0)
            {
                UIMessageBox.ShowWarning2("Vui lòng chọn ít nhất một câu hỏi để tạo đề thi.");
                return;
            }

            // 2. Thu thập danh sách ID câu hỏi đã chọn
            List<int> selectedQuestionIds = new List<int>();
            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.Cells["colID"].Value != null)
                {
                    selectedQuestionIds.Add((int)row.Cells["colID"].Value);
                }
            }

            string subject = _currentQuestions.FirstOrDefault(q => q.Id == selectedQuestionIds[0])?.Subject ?? "...";

            // 3. Hiển thị Form nhập thông tin đề thi
            using (var frm = new FormTaoDe_CauHoi(selectedQuestionIds.Count, subject))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _isBusy = true;

                        // Khởi tạo model đề thi
                        var newExam = new ExamModel
                        {
                            Title = frm.ExamName,
                            ExamCode = frm.ExamCode,
                            Duration = frm.Duration,
                            TotalQuestions = selectedQuestionIds.Count,
                            CreatedByUserId = _loginUser.Id,
                            CreatedAt = DateTime.Now,
                            Subject = subject
                        };

                        bool result = await _examService.CreateExamAsync(newExam, selectedQuestionIds);

                        if (result)
                        {
                            UIMessageBox.ShowSuccess2($"Đã tạo đề thi '{newExam.Title}' thành công với {newExam.TotalQuestions} câu hỏi.");
                            dgvQuestions.ClearSelection();
                        }
                        else
                        {
                            UIMessageBox.ShowError2("Lưu đề thi thất bại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        UIMessageBox.ShowError2($"Lỗi hệ thống: {ex.Message}");
                    }
                    finally
                    {
                        _isBusy = false;
                    }
                }
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestions.IsDisposed) return;

            try
            {
                lblSelect.Text = $"{dgvQuestions.SelectedRows.Count} câu hỏi đang được chọn";
            }
            catch (ObjectDisposedException)
            {
            }
        }

        private void Filter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string mon = cbMonHoc.Text;
            string doKho = cbDoKho.Text;
            string khoi = cbKhoi.Text;

            var filtered = _currentQuestions.Where(q =>
                (string.IsNullOrWhiteSpace(keyword) || q.Question.ToLower().Contains(keyword)) &&
                (mon == "Tất cả" || q.Subject == mon) &&
                (khoi == "Tất cả" || q.Grade == khoi) &&
                (doKho == "Tất cả" || q.Difficulty == doKho)
            ).ToList();

            BindGrid(filtered);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnAddManual_Click(object sender, EventArgs e)
        {
            try
            {
                flpQuestion.SuspendLayout(); // Tạm dừng vẽ để tránh lỗi Handle

                // Giải phóng Control cũ
                foreach (Control ctrl in flpQuestion.Controls)
                {
                    ctrl.Dispose();
                }
                flpQuestion.Controls.Clear();

                QuestionModel question = new QuestionModel
                {
                    Question = "<Nội dung câu hỏi>\n",
                    OptionA = " ",
                    OptionB = " ",
                    OptionC = " ",
                    OptionD = " ",
                    Answer = "A",
                    Subject = cbMonHoc.Text != "Tất cả" ? cbMonHoc.Text : "Lịch sử",
                    Grade = cbKhoi.Text != "Tất cả" ? cbKhoi.Text : "12",
                    Difficulty = cbDoKho.Text != "Tất cả" ? cbDoKho.Text : "Nhận biết",
                    CreatedByUserId = _loginUser.Id,
                    CreatedAt = DateTime.Now,
                    CategoryId = 1,
                    IsActive = true
                };

                UC_Question uc = new UC_Question(question, "Câu mới");
                uc.isFull(true);
                uc.Width = flpQuestion.ClientSize.Width - 20;
                flpQuestion.Controls.Add(uc);

                uc.SetReadOnlyMode(false);
            }
            finally
            {
                flpQuestion.ResumeLayout(true); // Tiếp tục vẽ giao diện
            }
        }

        private void dgvQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvQuestions.ClearSelection();
        }
    }
}