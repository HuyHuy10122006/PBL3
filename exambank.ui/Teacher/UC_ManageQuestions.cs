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
            InitFilterData();
            LoadData();
        }

        private void InitFilterData()
        {
            // Nạp dữ liệu vào ComboBox (Sử dụng Constants đã có trong Summary)
            cbMonHoc.Items.Clear();
            cbMonHoc.Items.Add("Chọn môn");
            cbMonHoc.Items.AddRange(Constants.List_MonHoc.ToArray());
            cbMonHoc.SelectedIndex = 0;

            cbDoKho.Items.Clear();
            cbDoKho.Items.Add("Chọn mức độ");
            cbDoKho.Items.AddRange(Constants.List_DoKho.ToArray());
            cbDoKho.SelectedIndex = 0;

            // Nạp dữ liệu Khối (Grade)[cite: 2]
            cbKhoi.Items.Clear();
            cbKhoi.Items.Add("Chọn khối");
            cbKhoi.Items.AddRange(Constants.List_Khoi.ToArray());
            cbKhoi.SelectedIndex = 0;
        }

        private void LoadData()
        {
            string keyword = txtSearch.Text.Trim();
            string mon = cbMonHoc.SelectedItem?.ToString();
            string doKho = cbDoKho.SelectedItem?.ToString();
            string khoi = cbKhoi.SelectedItem?.ToString();

            _questions = _questionService.GetQuestions(keyword, mon, khoi, doKho);
            BindGrid(_questions);
        }

        private void BindGrid(List<QuestionModel> data)
        {
            dgvQuestions.DataSource = data.Select(q => new
            {
                ID = q.Id,
                Content = q.Question,
                MonHoc = q.Subject,
                DoKho = q.Difficulty,
                Sua = Properties.Resources.icon_edit,
                Xoa = Properties.Resources.icon_trash
            }).ToList();

        }

        // Sự kiện khi nhấn nút Làm mới
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            //cbMonHoc.SelectedIndex = 0;
            //cbDoKho.SelectedIndex = 0;
            //cbKhoi.SelectedIndex = 0;
            LoadData();
            flpQuestion.Controls.Clear();
        }

        // Sự kiện khi nhấn nút Xóa mục đã chọn (Nút màu đỏ phía dưới)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvQuestions.SelectedRows;
            if (selectedRows.Count == 0) return;

            if (UIMessageBox.ShowAsk($"Bạn có chắc chắn muốn xóa {selectedRows.Count} câu hỏi này?"))
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow row in selectedRows)
                {
                    ids.Add((int)row.Cells["colID"].Value);
                }

                if (_questionService.DeleteMultiple(ids))
                {
                    UIMessageBox.ShowSuccess("Đã xóa thành công!");
                    LoadData();
                    flpQuestion.Controls.Clear();
                }
            }
        }

        // Sự kiện khi Click vào Grid để xem chi tiết hoặc xóa lẻ
        private async void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra điều kiện biên và trạng thái đang bận
            if (e.RowIndex < 0 || dgvQuestions.Rows[e.RowIndex].IsNewRow) return;
            if (_isBusy) return;

            try
            {
                _isBusy = true; // Khóa luồng ngay khi bắt đầu xử lý

                if (e.ColumnIndex == dgvQuestions.Columns["colXoa"].Index)
                {
                    var idValue = dgvQuestions.Rows[e.RowIndex].Cells["colID"].Value;
                    if (idValue != null && int.TryParse(idValue.ToString(), out int questionId))
                    {
                        if (UIMessageBox.ShowAsk($"Bạn có chắc chắn muốn xóa câu hỏi ID: {questionId}?"))
                        {
                            // Gọi thông qua service thay vì hàm nội bộ không tồn tại
                            if (_questionService.DeleteQuestion(questionId))
                            {
                                UIMessageBox.ShowSuccess("Xóa thành công!");
                                LoadData(); // Tải lại lưới dữ liệu
                                flpQuestion.Controls.Clear(); // Xóa chi tiết bên phải[cite: 8]
                            }
                        }
                    }
                    return;
                }

                // 3. Hiển thị chi tiết câu hỏi (Tác vụ gây tốn tài nguyên nhất)
                var cellValue = dgvQuestions.Rows[e.RowIndex].Cells["colID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int qId))
                {
                    var question = _questions.FirstOrDefault(q => q.Id == qId);
                    if (question != null)
                    {
                        // Sử dụng phương thức hiển thị chi tiết đã tách biệt
                        // isEditMode = true nếu click vào cột Sửa[cite: 2]
                        bool isEdit = (e.ColumnIndex == dgvQuestions.Columns["colSua"].Index);
                        ShowDetail(question, isEdit);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Chờ một khoảng thời gian cực ngắn để UI kịp phản hồi trước khi mở khóa
                await Task.Delay(50);
                _isBusy = false; // Giải phóng luồng[cite: 8]
            }
        }

        private void ShowDetail(QuestionModel q, bool isEditMode)
        {
            // Kiểm tra xem có cần Invoke để chuyển về luồng chính không
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowDetail(q, isEditMode)));
                return;
            }

            try
            {
                flpQuestion.SuspendLayout(); // Tạm dừng vẽ để tránh lỗi Handle

                // Giải phóng Control cũ một cách an toàn
                foreach (Control ctrl in flpQuestion.Controls)
                {
                    ctrl.Dispose();
                }
                flpQuestion.Controls.Clear();

                UC_Question uc = new UC_Question();
                uc.SetData(q, $"ID: {q.Id}");
        if (isEditMode) uc.SwapEditMode();

                uc.Width = flpQuestion.ClientSize.Width - 20;
                flpQuestion.Controls.Add(uc);
            }
            finally
            {
                flpQuestion.ResumeLayout(true); // Tiếp tục vẽ giao diện
            }
        }

        // Nút Lưu (Góc dưới cùng bên phải) - Dùng để lưu các thay đổi nếu UC_Question đang ở mode sửa
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            // Duyệt trong flpQuestion lấy UC_Question hiện tại và gọi hàm Save
            foreach (Control ctrl in flpQuestion.Controls)
            {
                if (ctrl is UC_Question uc)
                {
                    // Giả sử UC_Question có hàm GetUpdatedData() trả về QuestionModel
                    var updated = uc.GetUpdatedData();
                    if (updated == null)
                    {
                        MessageBox.Show("Không tìm thấy UC_Question để lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        if (updated != null && _questionService.UpdateQuestion(updated))
                    {
                        UIMessageBox.ShowSuccess("Đã lưu thay đổi.");
                        LoadData();
                    }
                }
            }
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            // Chuyển sang chức năng tạo đề từ các câu đã chọn
            UIMessageBox.ShowInfo("Chức năng chưa có.");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadData();
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra an toàn Handle trước khi truy cập
            if (!dgvQuestions.IsHandleCreated || dgvQuestions.IsDisposed) return;

            // 2. Sử dụng BeginInvoke để đưa việc cập nhật vào hàng đợi xử lý của UI
            // Điều này giúp tránh việc xung đột Handle khi người dùng quét chuột quá nhanh
            this.BeginInvoke(new Action(() =>
            {
            try
            {
                // Kiểm tra lại một lần nữa trong delegate để chắc chắn không bị lỗi luồng
                if (dgvQuestions.SelectedRows != null)
                {
                    int count = dgvQuestions.SelectedRows.Count;

                        lblSelect.Text = $"{count} câu hỏi đang được chọn";
            }
    }
        catch (Exception)
        {
            // Bỏ qua lỗi nếu Handle bị hủy trong lúc đang xử lý
        }
    }));
}
    }
}