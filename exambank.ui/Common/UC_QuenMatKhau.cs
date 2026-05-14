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
            ApplyFloatingLabels();
        }

        private void ApplyFloatingLabels()
        {
            CreateLabel(txtEmail, "Email");
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

        private void lnkReturnLogin_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(NavigationTarget.Login, null);
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ Email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UIHelper.IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_loginService.SendPasswordRecoveryRequest(email, out string message))
                {
                    MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}