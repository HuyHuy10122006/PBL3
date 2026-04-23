using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormDangNhap : UIForm
    {
        public UC_DangKy ucRegister = new UC_DangKy();
        public UC_QuenMatKhau ucForgot = new UC_QuenMatKhau();
        public FormDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadUserControl(ucRegister);
            LoadUserControl(ucForgot);
        }

        private void FormDangNhap_Resize(object sender, EventArgs e)
        {
            CenterLoginCard();
        }

        private void CenterLoginCard()
        {
            if (pnlLoginCard != null)
            {
                pnlLoginCard.Left = (this.ClientSize.Width - pnlLoginCard.Width) / 2;
                pnlLoginCard.Top = (this.ClientSize.Height - pnlLoginCard.Height) / 2;
            }
        }

        public void LoadUserControl(UserControl uc)
        {
            //pnlLoginCard.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlLoginCard.Controls.Add(uc);
            //CenterLoginCard();
        }
    }
}