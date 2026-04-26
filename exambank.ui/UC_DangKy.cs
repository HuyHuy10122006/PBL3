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
    public partial class UC_DangKy : UserControl
    {
        public UC_DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UIMessageTip.ShowOk("Đăng ký thành công!");
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FormDangNhap mainForm)
            {
                mainForm.LoadUserControl(new UC_DangNhap());
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
