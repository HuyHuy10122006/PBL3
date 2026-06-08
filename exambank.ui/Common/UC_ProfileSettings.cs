using System;
using System.Drawing;
using System.Windows.Forms;
using exambank.data.Models;

namespace exambank.ui.Common
{
    public partial class UC_ProfileSettings : UserControl
    {
        private UserModel _currentUser;

        private bool _isViewOnly = false;

        // Hàm khởi tạo bắt buộc phải truyền User vào để biết là Admin hay Giáo viên
        public UC_ProfileSettings(UserModel user, bool isViewOnly = false)
        {
            InitializeComponent();
            _currentUser = user;
            _isViewOnly = isViewOnly;

            if (_isViewOnly)
            {
                btnEditProfile.Visible = false;
                btnChangePassword.Visible = false;
                btnLogout.Visible = false;
            }

            // Gọi hàm hiển thị thông tin ngay khi trang vừa tải xong
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            if (_currentUser == null) return;

            // Gắn dữ liệu thật vào các thẻ giao diện
            lblFullName.Text = _currentUser.FullName ?? "Chưa cập nhật";
            lblRole.Text = (_currentUser.Role == "Admin" || _currentUser.Role == "SuperAdmin") ? "Vai trò: Quản trị viên hệ thống" : "Vai trò: Giáo viên";
            lblEmail.Text = "📧 Email: " + (_currentUser.Email ?? "Chưa cập nhật");

            // Load info from DB
            lblPhone.Text = "📞 Điện thoại: " + (!string.IsNullOrWhiteSpace(_currentUser.Phone) ? _currentUser.Phone : "Chưa cập nhật");
            lblUniversity.Text = "🏫 Đơn vị: " + (!string.IsNullOrWhiteSpace(_currentUser.University) ? _currentUser.University : "Chưa cập nhật");
            lblSubjects.Text = "📚 Bộ môn: " + (!string.IsNullOrWhiteSpace(_currentUser.Subjects) ? _currentUser.Subjects : "Chưa cập nhật");
            lblAiDifficulty.Text = "⚙️ Mức độ AI ưu tiên: " + (!string.IsNullOrWhiteSpace(_currentUser.AiDifficulty) ? _currentUser.AiDifficulty : "Chưa cập nhật");
            lblAccountStatus.Text = "🟢 Trạng thái: " + (_currentUser.IsActive ? "Đang hoạt động" : "Bị khóa");

            // (Code load ảnh Avatar sau này viết vào đây)
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            using (var frm = new FormEditProfile(_currentUser))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại thông tin sau khi cập nhật thành công
                    LoadUserInfo();
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new DoiMatKhau(_currentUser))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở cửa sổ đổi mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Tìm Form cha (FormAdmin hoặc FormGiaoVien) và đóng nó lại
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.DialogResult = DialogResult.OK;
                    parentForm.Close();
                }
            }
        }
    }
}