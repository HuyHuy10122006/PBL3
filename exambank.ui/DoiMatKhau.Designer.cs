namespace exambank.ui
{
    partial class DoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOldPass = new Sunny.UI.UITextBox();
            txtNewPass = new Sunny.UI.UITextBox();
            txtConfirmPass = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            pnlBtm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.Location = new Point(1, 320);
            pnlBtm.Size = new Size(548, 55);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FillColor = Color.FromArgb(192, 0, 0);
            btnCancel.FillColor2 = Color.FromArgb(192, 0, 0);
            btnCancel.FillHoverColor = Color.FromArgb(235, 115, 115);
            btnCancel.FillPressColor = Color.FromArgb(184, 64, 64);
            btnCancel.FillSelectedColor = Color.FromArgb(184, 64, 64);
            btnCancel.Font = new Font("Times New Roman", 12F);
            btnCancel.LightColor = Color.FromArgb(253, 243, 243);
            btnCancel.Location = new Point(370, 10);
            btnCancel.Radius = 10;
            btnCancel.RectColor = Color.FromArgb(230, 80, 80);
            btnCancel.RectHoverColor = Color.FromArgb(235, 115, 115);
            btnCancel.RectPressColor = Color.FromArgb(184, 64, 64);
            btnCancel.RectSelectedColor = Color.FromArgb(184, 64, 64);
            btnCancel.Style = Sunny.UI.UIStyle.Custom;
            btnCancel.Text = "Hủy";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.FillColor = Color.FromArgb(0, 0, 192);
            btnOK.FillColor2 = Color.FromArgb(0, 0, 192);
            btnOK.Font = new Font("Times New Roman", 12F);
            btnOK.Location = new Point(255, 10);
            btnOK.Radius = 10;
            btnOK.Size = new Size(98, 35);
            btnOK.Text = "Đổi";
            // 
            // txtOldPass
            // 
            txtOldPass.ButtonFillColor = Color.White;
            txtOldPass.ButtonForeColor = Color.Black;
            txtOldPass.ButtonRectColor = Color.White;
            txtOldPass.ButtonStyleInherited = false;
            txtOldPass.ButtonSymbol = 61552;
            txtOldPass.Font = new Font("Times New Roman", 12F);
            txtOldPass.Location = new Point(276, 93);
            txtOldPass.Margin = new Padding(4, 5, 4, 5);
            txtOldPass.MinimumSize = new Size(1, 16);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Padding = new Padding(5);
            txtOldPass.PasswordChar = '*';
            txtOldPass.RectColor = Color.Silver;
            txtOldPass.ShowButton = true;
            txtOldPass.ShowText = false;
            txtOldPass.Size = new Size(220, 36);
            txtOldPass.TabIndex = 0;
            txtOldPass.TextAlignment = ContentAlignment.MiddleLeft;
            txtOldPass.Watermark = "";
            txtOldPass.ButtonClick += txtOldPass_ButtonClick;
            // 
            // txtNewPass
            // 
            txtNewPass.ButtonFillColor = Color.White;
            txtNewPass.ButtonForeColor = Color.Black;
            txtNewPass.ButtonRectColor = Color.White;
            txtNewPass.ButtonStyleInherited = false;
            txtNewPass.ButtonSymbol = 61552;
            txtNewPass.Font = new Font("Times New Roman", 12F);
            txtNewPass.Location = new Point(276, 160);
            txtNewPass.Margin = new Padding(4, 5, 4, 5);
            txtNewPass.MinimumSize = new Size(1, 16);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Padding = new Padding(5);
            txtNewPass.PasswordChar = '*';
            txtNewPass.RectColor = Color.Silver;
            txtNewPass.ShowButton = true;
            txtNewPass.ShowText = false;
            txtNewPass.Size = new Size(220, 36);
            txtNewPass.TabIndex = 1;
            txtNewPass.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPass.Watermark = "";
            txtNewPass.ButtonClick += txtNewPass_ButtonClick;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.ButtonFillColor = Color.White;
            txtConfirmPass.ButtonForeColor = Color.Black;
            txtConfirmPass.ButtonRectColor = Color.White;
            txtConfirmPass.ButtonStyleInherited = false;
            txtConfirmPass.ButtonSymbol = 61552;
            txtConfirmPass.Font = new Font("Times New Roman", 12F);
            txtConfirmPass.Location = new Point(276, 229);
            txtConfirmPass.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPass.MinimumSize = new Size(1, 16);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Padding = new Padding(5);
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.RectColor = Color.Silver;
            txtConfirmPass.ShowButton = true;
            txtConfirmPass.ShowText = false;
            txtConfirmPass.Size = new Size(220, 36);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPass.Watermark = "";
            txtConfirmPass.ButtonClick += txtConfirmPass_ButtonClick;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Times New Roman", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(44, 93);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(215, 36);
            uiLabel1.TabIndex = 3;
            uiLabel1.Text = "Mật khẩu cũ:";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Times New Roman", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(44, 160);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(215, 36);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "Mật khẩu mới:";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Times New Roman", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(44, 229);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(215, 36);
            uiLabel3.TabIndex = 5;
            uiLabel3.Text = "Xác nhận mật khẩu mới:";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoiMatKhau
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(550, 378);
            ControlBoxForeColor = Color.Black;
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Name = "DoiMatKhau";
            RectColor = Color.Gray;
            Text = "Đổi mật khẩu";
            TitleColor = SystemColors.ActiveCaption;
            TitleFont = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleForeColor = Color.Black;
            Controls.SetChildIndex(txtOldPass, 0);
            Controls.SetChildIndex(txtNewPass, 0);
            Controls.SetChildIndex(txtConfirmPass, 0);
            Controls.SetChildIndex(uiLabel1, 0);
            Controls.SetChildIndex(uiLabel2, 0);
            Controls.SetChildIndex(uiLabel3, 0);
            Controls.SetChildIndex(pnlBtm, 0);
            pnlBtm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtOldPass;
        private Sunny.UI.UITextBox txtNewPass;
        private Sunny.UI.UITextBox txtConfirmPass;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}