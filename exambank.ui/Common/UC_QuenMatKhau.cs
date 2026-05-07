using exambank.data;
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
    public partial class UC_QuenMatKhau : BaseUserControl
    {
        private readonly LoginService _loginService;

        public UC_QuenMatKhau(LoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }

        private void lnkReturnLogin_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(NavigationTarget.Login, null);
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

            if (!UIHelper.IsValidEmail(email))
            {
                UIMessageTip.ShowError("Định dạng Email không hợp lệ!");
                return;
            }

            // 2. Kiểm tra sự tồn tại của Email trong Database
            try
            {
                if (_loginService.SendPasswordRecoveryRequest(email, out string message))
                {
                    UIMessageTip.ShowOk(message);
                }
                else
                {
                    UIMessageTip.ShowError(message);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Đã xảy ra lỗi: " + ex.Message);
            }
        }
     
    }
}
