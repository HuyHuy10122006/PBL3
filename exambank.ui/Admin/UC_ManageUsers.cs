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
            InitFilterData();
        }

        private void InitFilterData()
        {
            cbRole.DataSource = new string[] { "Tất cả", "Admin", "Teacher" };
            cbTT.DataSource = new string[] { "Tất cả", "Hoạt động", "Bị khóa" };
        }

        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _userService.GetAllUsers());
            _currentUsers.Clear();
            foreach (var u in newData) _currentUsers.Add(u);
            
            Filter();
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
                (role == "Tất cả" || u.Role.Contains(role)) &&
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

        // Định dạng màu sắc cho ô trong DataGridView
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Đổi màu chữ của cột "Trạng thái"
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
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            // Kiểm tra chuột trái và đúng cột thao tác
            if (e.Button == MouseButtons.Left && dgvUsers.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Chọn hàng đó luôn
                dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];

                Rectangle rect = dgvUsers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsActions.Show(dgvUsers, rect.Left, rect.Bottom);
            }
        }

        private void cmsActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var row = dgvUsers.CurrentRow;
            if (row == null)
            {
                e.Cancel = true;
                return;
            }

            // Đọc thông tin từ dòng hiện tại
            int targetUserId = (int)row.Cells["colID"].Value;
            string targetRole = row.Cells["colRole"].Value?.ToString()?.Trim();
            string targetStatus = row.Cells["colStatus"].Value?.ToString()?.Trim();

            // Xác định vai trò của người đang đăng nhập và đối tượng bị tác động
            bool isSelf = targetUserId == _loginUser.Id;
            bool isCurrentSuperAdmin = _loginUser.Role == "SuperAdmin";
            bool isCurrentAdmin = _loginUser.Role == "Admin";
            bool isTargetSuperAdmin = targetRole == "SuperAdmin";
            bool isTargetAdmin = targetRole == "Admin";

            // 1. CHẶN HOÀN TOÀN: Không cho thao tác với chính mình hoặc tài khoản SuperAdmin
            if (isSelf || isTargetSuperAdmin)
            {
                e.Cancel = true;
                return;
            }

            // 2. CHẶN CHO ADMIN THƯỜNG: Admin thường không được quyền quản lý các Admin khác
            if (isCurrentAdmin && isTargetAdmin)
            {
                e.Cancel = true;
                return;
            }

            // Tính toán trạng thái hiển thị bằng biến thuần túy
            bool canLock = (targetStatus == "Hoạt động");
            bool canUnlock = (targetStatus == "Bị khóa");
            bool canGrant = isCurrentSuperAdmin && (targetRole == "Teacher") && canLock;
            bool canRevoke = isCurrentSuperAdmin && isTargetAdmin && canLock;

            // Kiểm tra điều kiện mở menu trước khi gán vào UI
            if (!canLock && !canUnlock && !canGrant && !canRevoke)
            {
                e.Cancel = true;
                return;
            }

            // Gán trạng thái thực tế lên UI
            miLock.Visible = canLock;
            miUnlock.Visible = canUnlock;
            miGgantAdminRole.Visible = canGrant;
            miRevokeAdminRole.Visible = canRevoke;
            sSuperAdmin.Visible = canGrant || canRevoke;
        }

        // Hàm xử lý chung (Helper) giúp tái sử dụng code, giảm trùng lặp khi tương tác với DataGridView
        private async Task ExecuteUserActionAsync(string confirmMessage, string successMessage, Action<int> userServiceAction)
        {
            var row = dgvUsers.CurrentRow;
            if (row == null) return;

            try
            {
                int userId = (int)row.Cells["colID"].Value;
                string username = row.Cells["colUsername"].Value?.ToString();
                string fullName = row.Cells["colFullName"].Value?.ToString();

                // Hiển thị hộp thoại xác nhận với thông tin chi tiết của User
                if (UIMessageBox.ShowAsk2(string.Format(confirmMessage, fullName, username)))
                {
                    // Chạy hàm ủy nhiệm (delegate) được truyền vào từ các sự kiện click
                    userServiceAction(userId);

                    UIMessageBox.ShowSuccess2(successMessage);
                    await LoadDataTable();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private async void miLock_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhanh trạng thái trước khi chạy
            if (dgvUsers.CurrentRow?.Cells["colStatus"].Value?.ToString() != "Hoạt động") return;

            await ExecuteUserActionAsync(
                confirmMessage: "Bạn có chắc chắn muốn KHÓA tài khoản của {0} ({1}) không?",
                successMessage: "Khóa tài khoản thành công!",
                userServiceAction: (userId) => _userService.ToggleUserStatus(userId, _loginUser.Id)
            );
        }

        private async void miUnlock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.Cells["colStatus"].Value?.ToString() != "Bị khóa") return;

            await ExecuteUserActionAsync(
                confirmMessage: "Bạn có chắc chắn muốn MỞ KHÓA tài khoản của {0} ({1}) không?",
                successMessage: "Mở khóa tài khoản thành công!",
                userServiceAction: (userId) => _userService.ToggleUserStatus(userId, _loginUser.Id)
            );
        }

        private async void miGgantAdminRole_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.Cells["colRole"].Value?.ToString() != "Teacher") return;

            await ExecuteUserActionAsync(
                confirmMessage: "Bạn có chắc chắn muốn NÂNG QUYỀN Admin cho {0} ({1}) không?",
                successMessage: "Nâng quyền Admin thành công!",
                userServiceAction: (userId) => _userService.SetUserRole(userId, "Admin", _loginUser.Id)
            );
        }

        private async void miRevokeAdminRole_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.Cells["colRole"].Value?.ToString() != "Admin") return;

            await ExecuteUserActionAsync(
                confirmMessage: "Bạn có chắc chắn muốn HẠ QUYỀN tài khoản {0} ({1}) xuống Teacher không?",
                successMessage: "Hạ quyền Teacher thành công!",
                userServiceAction: (userId) => _userService.SetUserRole(userId, "Teacher", _loginUser.Id)
            );
        }
    }
}