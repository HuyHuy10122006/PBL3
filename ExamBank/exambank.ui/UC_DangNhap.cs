using exambank.data;
using exambank.data.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_DangNhap : UserControl
    {
        public UC_DangNhap()
        {
            InitializeComponent();
        }

        public UserModel CheckLogin(string username, string password)
        {
            using (var db = new ExamBankDbContext())
            {
                // Lưu ý: Trong thực tế nên dùng BCrypt để Verify password thay vì so sánh chuỗi thuần
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null && user.IsActive)
                {
                    return user;
                }
                return null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {

                UIMessageTip.ShowWarning("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            // Gọi hàm kiểm tra từ Database
            UserModel authenticatedUser = CheckLogin(user, pass);

            if (authenticatedUser != null)
            {
                // Ẩn form hiện tại
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Hide();

                    if (authenticatedUser.Role == "Admin")
                    {
                        FormAdmin adminForm = new FormAdmin(authenticatedUser);
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        FormGiaoVien teacherForm = new FormGiaoVien(authenticatedUser);
                        teacherForm.ShowDialog();
                    }
                }
            }
            else
            {
                UIMessageTip.ShowError("Tài khoản hoặc mật khẩu không đúng!");
            }


            txtUsername.Text = "";
            txtPassword.Text = "";
            // Hiện lại màn hình đăng nhập
            Form parentForm1 = this.FindForm();
            if (parentForm1 != null)
            {
                parentForm1.Show();
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is FormDangNhap mainForm)
            {
                mainForm.ucRegister.BringToFront();
            }
        }

        private void LnkForgotPassword_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is FormDangNhap mainForm)
            {
                mainForm.ucForgot.BringToFront();
            }
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtPassword);
        }
    }
}
