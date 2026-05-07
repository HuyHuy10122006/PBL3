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
using exambank.ui.Base;

namespace exambank.ui
{
    public partial class UC_DangKy : BaseUserControl
    {
        private readonly LoginService _loginService;

        public UC_DangKy(LoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
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

            if (!UIHelper.IsValidEmail(email))
            {
                UIMessageTip.ShowError("Định dạng Email không hợp lệ!");
                return;
            }

            if (pass != confirmPass)
            {
                UIMessageTip.ShowError("Xác nhận mật khẩu không khớp!");
                return;
            }

            if (pass.Length < 6)
            {
                UIMessageTip.ShowError("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            // 3. Thực hiện lưu vào Database
            try
            {
                if (_loginService.RegisterUser(fullName, email, user, pass, out string mess))
                {
                    UIMessageTip.ShowOk(mess);
                }
                else
                {
                    UIMessageTip.ShowError(mess);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Đã xảy ra lỗi: " + ex.Message);
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
    }
}
