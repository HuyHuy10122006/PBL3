using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_ManageUsers : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly UserService _userService = new UserService();
        private List<UserModel> _currentUsers = new List<UserModel>();

        public UC_ManageUsers(UserModel user)
        {
            InitializeComponent();
            this._loginUser = user;
        }

        private async void UC_ManageUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoGenerateColumns = false;
            await LoadDataTable();
        }

        private void InitFilterDataAsync()
        {
            cbRole.DataSource = new string[] { "Tất cả", "Admin", "Teacher" };
            cbTT.DataSource = new string[] { "Tất cả", "Hoạt động", "Bị khóa" };
        }

        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _userService.GetAllUsers());
            _currentUsers.Clear();
            foreach (var u in newData) _currentUsers.Add(u);

            InitFilterDataAsync();
            BindGrid(_currentUsers);
        }

        private void BindGrid(List<UserModel> data)
        {
            var display = data.Select(u => new
            {
                ID = u.Id,
                STT = data.IndexOf(u) + 1,
                FullName = u.FullName,
                Username = u.Username,
                Email = u.Email,
                Status = u.IsActive ? "Hoạt động" : "Bị khóa",
                Role = u.Role,
                Actions = u.IsActive ? "Khóa" : "Mở khóa"
            }).ToList();

            dgvUsers.DataSource = display;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataTable();
        }

        private void Filter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string role = cbRole.Text;
            string status = cbTT.Text;

            var filtered = _currentUsers.Where(u =>
                (string.IsNullOrWhiteSpace(keyword) ||
                    (u.Username != null && u.Username.ToLower().Contains(keyword)) ||
                    (u.FullName != null && u.FullName.ToLower().Contains(keyword)) ||
                    (u.Email != null && u.Email.ToLower().Contains(keyword))
                ) &&
                (role == "Tất cả" || u.Role == role) &&
                (status == "Tất cả" || (status == "Hoạt động" && u.IsActive) || (status == "Bị khóa" && !u.IsActive))
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

        // Định dạng màu sắc cho các ô trong DataGridView dựa trên giá trị của chúng
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Đổi màu chữ của cột "Trạng thái" dựa trên giá trị của nó
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string status = e.Value.ToString().Trim();
                if (status.Equals("Bị khóa"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(197, 34, 31);   // Đỏ đậm
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 51);   // Xanh đậm
                }
            }

            // Đổi màu nền và chữ của cột "Thao tác" dựa trên giá trị của cột "Trạng thái" cùng hàng
            else if (dgvUsers.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Lấy giá trị của cột "Trạng thái" cùng hàng với nút bấm này
                var cellTrangThai = dgvUsers.Rows[e.RowIndex].Cells["colStatus"].Value;

                if (cellTrangThai != null && cellTrangThai.ToString().Trim().Equals("Bị khóa"))
                {
                    // Nếu tài khoản đã bị Khóa -> Đổi chữ hiển thị trên nút từ "Khóa" thành "Mở Khóa" có màu Xanh
                    e.Value = "Mở khóa";
                    e.CellStyle.BackColor = Color.FromArgb(230, 244, 234); // Xanh nhạt
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 51);   // Xanh đậm
                    e.CellStyle.Font = new Font(cbRole.Font, FontStyle.Bold);
                }
                else
                {
                    // Nếu tài khoản đang Hoạt động -> Đổi chữ hiển thị trên nút từ "Mở Khóa" thành "Khóa" có màu Đỏ
                    e.CellStyle.BackColor = Color.FromArgb(252, 232, 230); // Màu nền đỏ nhạt
                    e.CellStyle.ForeColor = Color.FromArgb(197, 34, 31);   // Màu chữ đỏ đậm
                    e.CellStyle.Font = new Font(cbRole.Font, FontStyle.Bold);
                }

                //Nếu là Admin thì không hiển thị nút Khóa/Mở khóa
                var cellRole = dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value;
                if (cellRole != null && cellRole.ToString().Trim().Equals("Admin"))
                {
                    e.Value = ""; // Không hiển thị nút nào
                }
            }
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Lấy thông tin của dòng hiện tại để xử lý
                string role = dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value?.ToString();
                if (role.Equals("Admin")) return;

                int userId = (int)dgvUsers.Rows[e.RowIndex].Cells["colID"].Value;
                string username = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value?.ToString();
                string hoTen = dgvUsers.Rows[e.RowIndex].Cells["colFullName"].Value?.ToString();
                string trangThaiHienTai = dgvUsers.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString();

                // Kiểm tra trạng thái hiện tại để quyết định hành động tiếp theo
                if (trangThaiHienTai == "Bị khóa")
                {
                    // Hỏi xác nhận trước khi Mở khóa
                    if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn MỞ KHÓA tài khoản của {hoTen} ({username}) không?"))
                    {
                        _userService.ToggleUserStatus(userId);
                        UIMessageBox.ShowSuccess2("Mở khóa tài khoản thành công!");
                        LoadDataTable();
                    }
                }
                else
                {
                    // Hỏi xác nhận trước khi Khóa
                    if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn KHÓA tài khoản của {hoTen} ({username}) không?"))
                    {
                        _userService.ToggleUserStatus(userId);
                        UIMessageBox.ShowSuccess2("Khóa tài khoản thành công!");
                        LoadDataTable();
                    }
                }
            }
        }
    }
}