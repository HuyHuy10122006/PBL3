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
    public partial class UC_QuenMatKhau : UserControl
    {
        public UC_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            UIMessageTip.ShowOk("Gửi yêu cầu thành công!");
        }

        private void lnkReturnLogin_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FormDangNhap mainForm)
            {
                mainForm.LoadUserControl(new UC_DangNhap());
            }
        }
    }
}
