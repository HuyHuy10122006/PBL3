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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Tạm thời chấp nhận mọi đăng nhập
            if (this.ParentForm is FormDangNhap mainForm)
            {
                mainForm.DialogResult = DialogResult.OK;
                mainForm.Close();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FormDangNhap mainForm)
            {
                mainForm.LoadUserControl(new UC_DangKy());
            }
        }

        private void LnkForgotPassword_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FormDangNhap mainForm)
            {
                mainForm.LoadUserControl(new UC_QuenMatKhau());
            }
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtPassword);
        }
    }
}
