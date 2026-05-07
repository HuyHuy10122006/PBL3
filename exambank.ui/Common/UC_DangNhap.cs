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
            if (pass.Length < 6)
            {
                UIMessageTip.ShowError("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            try
            {
                // Gọi hàm kiểm tra từ Database
                UserModel authenticatedUser = _loginService.CheckLogin(user, pass);

                if (authenticatedUser != null)
                {
                    OnNavigate?.Invoke(NavigationTarget.Home, authenticatedUser);
                }
                else
                {
                    UIMessageTip.ShowError("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Đã xảy ra lỗi: {ex.Message}");
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
    }
}
