using exambank.data;
using exambank.ui.Base;
using exambank.logic.Service;
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

        private void pnlForgotPassCard_Load(object sender, EventArgs e)
        {
            // Đưa danh sách email admin lên ListBox
            var adminEmails = _loginService.GetAdminEmails();
            lstAdminEmails.Items.Clear();
            foreach (var email in adminEmails)
            {
                lstAdminEmails.Items.Add(email);
            }
        }
    }
}