using exambank.data.Models;
using exambank.ui.Base;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private FlowLayoutPanel _flpUsers;
        private Panel _pnlListHeader;
        private UserModel _selectedUserAction;

        public UC_ManageUsers(UserModel user)
        {
            InitializeComponent();
            this._loginUser = user;
        }

        private async void UC_ManageUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.Visible = false; // Ẩn DataGridView cũ
            SetupFlowLayout();

            await LoadDataTable();
            InitFilterData();
        }

        private void SetupFlowLayout()
        {
            _pnlListHeader = new Panel { Dock = DockStyle.Top, Height = 45, BackColor = Color.White };
            _pnlListHeader.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font fontBold = new Font("Segoe UI", 10, FontStyle.Bold);
                Brush textBrush = new SolidBrush(Color.FromArgb(100, 100, 100));

                g.DrawString("#", fontBold, textBrush, new Point(30, 12));
                g.DrawString("Người dùng", fontBold, textBrush, new Point(120, 12));
                g.DrawString("Email", fontBold, textBrush, new Point(350, 12));
                g.DrawString("Vai trò", fontBold, textBrush, new Point(610, 12));
                g.DrawString("Trạng thái", fontBold, textBrush, new Point(765, 12));
                g.DrawString("Đăng nhập cuối", fontBold, textBrush, new Point(900, 12));
                g.DrawString("Thao tác", fontBold, textBrush, new Point(1090, 12));

                g.DrawLine(new Pen(Color.FromArgb(235, 235, 235)), 0, 44, _pnlListHeader.Width, 44);
            };

            _flpUsers = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(250, 250, 250),
                WrapContents = false,
                FlowDirection = FlowDirection.TopDown
            };

            _flpUsers.SizeChanged += (s, ev) =>
            {
                _flpUsers.SuspendLayout();
                foreach (Control c in _flpUsers.Controls)
                {
                    c.Width = _flpUsers.ClientSize.Width - 15;
                }
                _flpUsers.ResumeLayout();
            };

            pnlDgv.Controls.Add(_flpUsers);
            pnlDgv.Controls.Add(_pnlListHeader);
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
            if (_flpUsers == null) return;

            _flpUsers.SuspendLayout();
            // Xóa các row cũ
            foreach (Control ctrl in _flpUsers.Controls)
            {
                ctrl.Dispose();
            }
            _flpUsers.Controls.Clear();

            int index = 1;
            foreach (var u in data)
            {
                var row = new Admin.UC_UserRow(u, index++, u.Id == _loginUser.Id);
                row.Width = _flpUsers.ClientSize.Width - 15; // Trừ hao scrollbar
                row.ActionClicked += Row_ActionClicked;
                _flpUsers.Controls.Add(row);
            }

            _flpUsers.ResumeLayout();
        }

        private void Row_ActionClicked(object sender, UserModel user)
        {
            _selectedUserAction = user;
            Admin.UC_UserRow row = sender as Admin.UC_UserRow;

            // Xác định quyền để hiển thị menu
            int targetUserId = user.Id;
            string targetRole = user.Role;
            bool targetStatus = user.IsActive;

            bool isSelf = targetUserId == _loginUser.Id;
            bool isCurrentSuperAdmin = _loginUser.Role == "SuperAdmin";
            bool isCurrentAdmin = _loginUser.Role == "Admin";
            bool isTargetSuperAdmin = targetRole == "SuperAdmin";
            bool isTargetAdmin = targetRole == "Admin";

            // Mặc định luôn cho phép xem chi tiết
            miViewDetails.Visible = true;

            // 1. CHẶN HOÀN TOÀN TÁC ĐỘNG VÀO BẢN THÂN HOẶC SUPERADMIN
            bool canEdit = !(isSelf || isTargetSuperAdmin);

            // 2. CHẶN CHO ADMIN THƯỜNG KHÔNG ĐƯỢC TÁC ĐỘNG VÀO ADMIN KHÁC
            if (isCurrentAdmin && isTargetAdmin)
            {
                canEdit = false;
            }

            bool canLock = canEdit && targetStatus;
            bool canUnlock = canEdit && !targetStatus;
            bool canGrant = canEdit && isCurrentSuperAdmin && (targetRole == "Teacher") && canLock;
            bool canRevoke = canEdit && isCurrentSuperAdmin && isTargetAdmin && canLock;

            miLock.Visible = canLock;
            miUnlock.Visible = canUnlock;
            miGgantAdminRole.Visible = canGrant;
            miRevokeAdminRole.Visible = canRevoke;
            sSuperAdmin.Visible = canGrant || canRevoke;
            miResetPass.Visible = sResetPass.Visible = canEdit;

            // Hiển thị context menu
            Point pt = row.PointToScreen(new Point(1100, 45));
            cmsActions.Show(pt);
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

        // CÁC HÀM CŨ CỦA DATAGRIDVIEW KHÔNG CÒN SỬ DỤNG NHƯNG GIỮ LẠI ĐỂ TRÁNH LỖI DESIGNER
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) { }
        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) { }
        private void cmsActions_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }

        // Hàm xử lý chung (Helper)
        private async Task ExecuteUserActionAsync(string confirmMessage, string successMessage, Action<int> userServiceAction)
        {
            if (_selectedUserAction == null) return;

            try
            {
                int userId = _selectedUserAction.Id;
                string username = _selectedUserAction.Username;
                string fullName = _selectedUserAction.FullName;

                if (UIMessageBox.ShowAsk2(string.Format(confirmMessage, fullName, username)))
                {
                    userServiceAction(userId);
                    UIMessageBox.ShowSuccess2(successMessage);
                    await LoadDataTable();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi hệ thống: {ex.Message}");
            }
            finally
            {
                _selectedUserAction = null;
            }
        }

        private void miViewDetails_Click(object sender, EventArgs e)
        {
            if (_selectedUserAction == null) return;
            try
            {
                var userFull = _userService.GetUserById(_selectedUserAction.Id);
                if (userFull != null)
                {
                    using (var frm = new Sunny.UI.UIForm())
                    {
                        frm.Text = "Chi tiết hồ sơ";
                        frm.Size = new Size(1000, 600);
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowRadius = false;
                        frm.ShowShadow = true;
                        
                        var uc = new exambank.ui.Common.UC_ProfileSettings(userFull, true);
                        uc.Dock = DockStyle.Fill;
                        frm.Controls.Add(uc);

                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Sunny.UI.UIMessageBox.ShowError("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private async void miLock_Click(object sender, EventArgs e)
        {
            if (_selectedUserAction == null || !_selectedUserAction.IsActive) return;
            try
            {
                await ExecuteUserActionAsync(
                    confirmMessage: "Bạn có chắc chắn muốn KHÓA tài khoản của {0} ({1}) không?",
                    successMessage: "Khóa tài khoản thành công!",
                    userServiceAction: (userId) => _userService.ToggleUserStatus(userId, _loginUser.Id)
                );
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miUnlock_Click(object sender, EventArgs e)
        {
            if (_selectedUserAction == null || _selectedUserAction.IsActive) return;
            try
            {
                await ExecuteUserActionAsync(
                    confirmMessage: "Bạn có chắc chắn muốn MỞ KHÓA tài khoản của {0} ({1}) không?",
                    successMessage: "Mở khóa tài khoản thành công!",
                    userServiceAction: (userId) => _userService.ToggleUserStatus(userId, _loginUser.Id)
                );
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miGgantAdminRole_Click(object sender, EventArgs e)
        {
            if (_selectedUserAction == null || _selectedUserAction.Role != "Teacher") return;
            try
            {
                await ExecuteUserActionAsync(
                    confirmMessage: "Bạn có chắc chắn muốn NÂNG QUYỀN Admin cho {0} ({1}) không?",
                    successMessage: "Nâng quyền Admin thành công!",
                    userServiceAction: (userId) => _userService.SetUserRole(userId, "Admin", _loginUser.Id)
                );
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miRevokeAdminRole_Click(object sender, EventArgs e)
        {
            if (_selectedUserAction == null || _selectedUserAction.Role != "Admin") return;
            try
            {
                await ExecuteUserActionAsync(
                    confirmMessage: "Bạn có chắc chắn muốn HẠ QUYỀN tài khoản {0} ({1}) xuống Teacher không?",
                    successMessage: "Hạ quyền Teacher thành công!",
                    userServiceAction: (userId) => _userService.SetUserRole(userId, "Teacher", _loginUser.Id)
                );
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miResetPass_Click(object sender, EventArgs e)
        {
            // Reset mật khẩu về 123456 và hiển thị thông báo
            if (_selectedUserAction == null) return;
            try
            {
                await ExecuteUserActionAsync(
                    confirmMessage: "Bạn có chắc chắn muốn RESET mật khẩu cho tài khoản {0} ({1}) không?",
                    successMessage: $"Reset mật khẩu thành công!\nMật khẩu hiện tại của \"{_selectedUserAction.Username}\" là 123456.",
                    userServiceAction: (userId) => _userService.ResetPassword(userId, "123456", _loginUser.Id)
                );
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }
    }
}