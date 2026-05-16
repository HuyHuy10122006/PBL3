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
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_DangNhap : BaseUserControl
    {
        private readonly LoginService _loginService;

        public UC_DangNhap(LoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
            ApplyFloatingLabels();
        }

        private void ApplyFloatingLabels()
        {
            CreateLabel(txtUsername, "Email / Tên đăng nhập");
            CreateLabel(txtPassword, "Mật khẩu");
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
            lbl.ForeColor = Color.DimGray;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.Location = new Point(txtBox.Location.X + 12, txtBox.Location.Y - 8);

            this.Controls.Add(lbl);
            lbl.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Cảnh báo bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserModel authenticatedUser = _loginService.CheckLogin(user, pass);

                if (authenticatedUser != null)
                {
                    OnNavigate?.Invoke(NavigationTarget.Home, authenticatedUser);
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(NavigationTarget.Register, null);
        }

        private void LnkForgotPassword_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(NavigationTarget.ForgotPassword, null);
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtPassword);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Nếu người dùng nhấn phím Enter
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}