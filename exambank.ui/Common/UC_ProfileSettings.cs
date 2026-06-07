using System;
using System.Drawing;
using System.Windows.Forms;
using exambank.data.Models;

namespace exambank.ui.Common
{
    public partial class UC_ProfileSettings : UserControl
    {
        private UserModel _currentUser;

        // Hàm khởi tạo bắt buộc phải truyền User vào để biết là Admin hay Giáo viên
        public UC_ProfileSettings(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;

            // Gọi hàm hiển thị thông tin ngay khi trang vừa tải xong
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            if (_currentUser == null) return;

            // Gắn dữ liệu thật vào các thẻ giao diện
            lblFullName.Text = _currentUser.FullName ?? "Chưa cập nhật";
            lblRole.Text = _currentUser.Role == "1" ? "Vai trò: Quản trị viên hệ thống" : "Vai trò: Giáo viên";
            lblEmail.Text = "📧 Email: " + (_currentUser.Email ?? "Chưa cập nhật");

            // Các thông tin dưới đây bạn có thể lấy từ Database sau, hiện tại để hiển thị demo
            lblPhone.Text = "📞 Điện thoại: Chưa cập nhật";
            lblUniversity.Text = "🏫 Đơn vị: ĐH Bách Khoa - DUT";
            lblSubjects.Text = "📚 Bộ môn: Công nghệ thông tin";
            lblAiDifficulty.Text = "⚙️ Mức độ AI ưu tiên: Vận dụng";
            lblAccountStatus.Text = "🟢 Trạng thái: Đang hoạt động";

            // (Code load ảnh Avatar sau này viết vào đây)
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