using exambank.data.Models;
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
    public partial class UC_DangKy : UserControl
    {
        public UC_DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // 2. Kiểm tra dữ liệu đầu vào (Validation)
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                UIMessageTip.ShowWarning("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (!IsValidEmail(email))
            {
                UIMessageTip.ShowWarning("Định dạng Email không hợp lệ!");
                return;
            }

            if (pass != confirmPass)
            {
                UIMessageTip.ShowWarning("Xác nhận mật khẩu không khớp!");
                return;
            }

            if (pass.Length < 6)
            {
                UIMessageTip.ShowWarning("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            // 3. Thực hiện lưu vào Database
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    // Kiểm tra trùng lặp tài khoản
                    if (db.Users.Any(u => u.Username == user))
                    {
                        UIMessageTip.ShowError("Tên đăng nhập đã tồn tại!");
                        return;
                    }

                    if (db.Users.Any(u => u.Email == email))
                    {
                        UIMessageTip.ShowError("Email này đã được sử dụng!");
                        return;
                    }

                    // Khởi tạo Model dựa trên UserModel.cs của bạn
                    var newUser = new UserModel
                    {
                        FullName = fullName,
                        Email = email,
                        Username = user,
                        Password = pass,
                        Role = "Teacher",
                        CreatedAt = DateTime.Now,
                        IsActive = true
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể đăng nhập ngay bây giờ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hàm kiểm tra định dạng Email
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is FormDangNhap mainForm)
            {
                mainForm.ucLogin.BringToFront();
            }
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtPassword);
        }

        private void txtConfirmPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtConfirmPassword);
        }
    }
}
