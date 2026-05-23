using exambank.data;
using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_DangKy : BaseUserControl
    {
        private readonly LoginService _loginService;
        private string selectedAvatarPath = string.Empty;

        public UC_DangKy(LoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
            ApplyFloatingLabels();
        }

        private void ApplyFloatingLabels()
        {
            CreateLabel(txtFullName, "Họ tên");
            CreateLabel(txtEmail, "Email");
            CreateLabel(txtUsername, "Username");
            CreateLabel(txtPassword, "Password");
            CreateLabel(txtConfirmPassword, "Nhập lại Password");
        }

        private void CreateLabel(Control txtBox, string text)
        {
            if (txtBox is UITextBox uiTxt)
            {
                uiTxt.Watermark = "";
            }

            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.Navy;
            lbl.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lbl.Location = new Point(txtBox.Location.X + 23, txtBox.Location.Y - 11);

            this.Controls.Add(lbl);
            lbl.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UIHelper.IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Cảnh báo bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tiến hành băm mật khẩu
                string hashedPassword = UIHelper.HashPassword(pass);

                if (_loginService.RegisterUser(fullName, email, user, hashedPassword, out string mess))
                {
                    MessageBox.Show(mess, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnNavigate?.Invoke(NavigationTarget.Login, null);
                }
                else
                {
                    MessageBox.Show(mess, "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(NavigationTarget.Login, null);
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtPassword);
        }

        private void txtConfirmPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtConfirmPassword);
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedAvatarPath = openFileDialog.FileName;

                if (sender is PictureBox pic)
                {
                    pic.ImageLocation = selectedAvatarPath;
                }
                else if (sender is UIAvatar avatar)
                {
                    avatar.Image = Image.FromFile(selectedAvatarPath);
                }
            }
        }
    }
}