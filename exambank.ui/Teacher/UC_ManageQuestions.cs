using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace exambank.ui
{
    public partial class UC_ManageQuestions : UserControl
    {
        private readonly UserModel _loginUser;
        private readonly QuestionService _questionService = new QuestionService();
        private List<QuestionModel> _questions = new List<QuestionModel>();
        private List<int> _selectedIds = new List<int>();
        private bool _isBusy = false; // Cờ trạng thái bận

        public UC_ManageQuestions(UserModel loginUser)
        {
            _loginUser = loginUser;
            InitializeComponent();
        }

        private void UC_ManageQuestions_Load(object sender, EventArgs e)
        {
            InitFilterDataAsync();
            LoadDataTable();
            dgvQuestions.AutoGenerateColumns = false;
        }

        // Nạp dữ liệu vào ComboBox
        private async Task InitFilterDataAsync()
        {
            List<string> subjects = await _questionService.GetUniqueValuesAsync(q => q.Subject);
            subjects.Insert(0, "Tất cả");
            cbMonHoc.DataSource = subjects;

            List<string> grades = await _questionService.GetUniqueValuesAsync(q => q.Grade);
            grades.Insert(0, "Tất cả");
            cbKhoi.DataSource = grades;

            List<string> difficulties = Constants.List_DoKho.ToList();
            difficulties.Insert(0, "Tất cả");
            cbDoKho.DataSource = difficulties;
        }

        // Nạp dữ liệu vào DataGridView
        private async Task LoadDataTable()
        {
            string keyword = txtSearch.Text.Trim();
            string mon = cbMonHoc.Text == "Tất cả" ? null : cbMonHoc.Text;
            string doKho = cbDoKho.Text == "Tất cả" ? null : cbDoKho.Text;
            string khoi = cbKhoi.Text == "Tất cả" ? null : cbKhoi.Text;

            _questions = await Task.Run(() => _questionService.GetQuestions(keyword, mon, khoi, doKho));
            BindGrid(_questions);
        }

        private void BindGrid(List<QuestionModel> data)
        {
            var displayList = data.Select(q => new
            {
                ID = q.Id,
                Content = q.Question,
                MonHoc = q.Subject,
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

                // 3. Hiển thị chi tiết câu hỏi
                var cellValue = dgvQuestions.Rows[e.RowIndex].Cells["colID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int qId))
                {
                    var question = _questions.FirstOrDefault(q => q.Id == qId);
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

                UC_Question uc = new UC_Question();
                uc.SetData(q, $"ID: {q.Id}");
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
        private void btnSave_Click(object sender, EventArgs e)
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
                    //GetData() trả về QuestionModel
                    var updated = uc.GetData();
                    if (updated == null)
                    {
                        UIMessageBox.ShowError2("Không tìm thấy câu hỏi để lưu.");
                    }
                    if (updated != null && _questionService.UpdateQuestion(updated))
                    {
                        UIMessageTip.ShowOk("Đã lưu thay đổi.");
                        LoadDataTable();
                    }
                }
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
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
                        if (updated != null && _questionService.DeleteMultiple(new List<int> { updated.Id }))
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
        private void btnDelete_Click(object sender, EventArgs e)
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

                if (_questionService.DeleteMultiple(ids))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công!");
                    LoadDataTable();
                    flpQuestion.Controls.Clear();
                }
            }
        }
        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            // Chuyển sang chức năng tạo đề từ các câu đã chọn
            UIMessageBox.ShowInfo2("Chức năng chưa có.");
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

            var filtered = _questions.Where(q =>
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
    }
}