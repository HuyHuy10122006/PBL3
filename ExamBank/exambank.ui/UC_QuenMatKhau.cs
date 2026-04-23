using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using exambank.data;

namespace exambank.ui
{
    public partial class UC_QuenMatKhau : UserControl
    {
        public UC_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void lnkReturnLogin_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is FormDangNhap mainForm)
            {
                mainForm.ucLogin.BringToFront();
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(email))
            {
                UIMessageTip.ShowWarning("Vui lòng nhập địa chỉ Email!");
                return;
            }

            if (!IsValidEmail(email))
            {
                UIMessageTip.ShowError("Định dạng Email không hợp lệ!");
                return;
            }

            // 2. Kiểm tra sự tồn tại của Email trong Database
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Email == email);

                    if (user == null)
                    {
                        MessageBox.Show("Email này không tồn tại trong hệ thống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Xử lý gửi yêu cầu
                    bool isSent = SendRecoveryEmail(email, user.FullName);

                    if (isSent)
                    {
                        MessageBox.Show($"Hướng dẫn khôi phục mật khẩu đã được gửi đến email: {email}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi gửi email. Vui lòng thử lại sau!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Hàm mô phỏng gửi Email
        private bool SendRecoveryEmail(string email, string fullName)
        {
            // Tạm thời trả về true để mô phỏng thành công
            return true;
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
