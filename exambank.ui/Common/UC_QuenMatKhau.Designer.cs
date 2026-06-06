namespace exambank.ui
{
    partial class UC_QuenMatKhau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlForgotPassCard = new Sunny.UI.UIPanel();
            lstAdminEmails = new Sunny.UI.UIListBox();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            lblDescription = new Sunny.UI.UILabel();
            lnkReturnLogin = new Sunny.UI.UILinkLabel();
            pnlForgotPassCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForgotPassCard
            // 
            pnlForgotPassCard.Controls.Add(lstAdminEmails);
            pnlForgotPassCard.Controls.Add(lblTitle);
            pnlForgotPassCard.Controls.Add(lblSubTitle);
            pnlForgotPassCard.Controls.Add(lblDescription);
            pnlForgotPassCard.Controls.Add(lnkReturnLogin);
            pnlForgotPassCard.Dock = DockStyle.Fill;
            pnlForgotPassCard.FillColor = Color.White;
            pnlForgotPassCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlForgotPassCard.Location = new Point(0, 0);
            pnlForgotPassCard.Margin = new Padding(4, 5, 4, 5);
            pnlForgotPassCard.MinimumSize = new Size(1, 1);
            pnlForgotPassCard.Name = "pnlForgotPassCard";
            pnlForgotPassCard.Radius = 10;
            pnlForgotPassCard.RectColor = Color.FromArgb(220, 220, 220);
            pnlForgotPassCard.Size = new Size(450, 450);
            pnlForgotPassCard.TabIndex = 0;
            pnlForgotPassCard.Text = null;
            pnlForgotPassCard.TextAlignment = ContentAlignment.MiddleCenter;
            pnlForgotPassCard.Load += pnlForgotPassCard_Load;
            // 
            // lstAdminEmails
            // 
            lstAdminEmails.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAdminEmails.HoverColor = Color.FromArgb(155, 200, 255);
            lstAdminEmails.ItemSelectForeColor = Color.White;
            lstAdminEmails.Location = new Point(50, 198);
            lstAdminEmails.Margin = new Padding(4, 5, 4, 5);
            lstAdminEmails.MinimumSize = new Size(1, 1);
            lstAdminEmails.Name = "lstAdminEmails";
            lstAdminEmails.Padding = new Padding(5);
            lstAdminEmails.Radius = 10;
            lstAdminEmails.ShowText = false;
            lstAdminEmails.Size = new Size(350, 166);
            lstAdminEmails.TabIndex = 6;
            lstAdminEmails.Text = null;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(10, 35, 81);
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUÊN MẬT KHẨU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.FromArgb(10, 35, 81);
            lblSubTitle.Location = new Point(50, 70);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(350, 50);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "HỆ THỐNG EduGenAI";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(50, 130);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(350, 50);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Liên hệ 1 trong các địa chỉ Email dưới đây để được cấp lại mật khẩu.\r\n\r\n\r\n";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkReturnLogin
            // 
            lnkReturnLogin.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            lnkReturnLogin.Font = new Font("Segoe UI", 10F);
            lnkReturnLogin.ForeColor = Color.FromArgb(48, 48, 48);
            lnkReturnLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkReturnLogin.LinkColor = Color.FromArgb(10, 35, 81);
            lnkReturnLogin.Location = new Point(60, 388);
            lnkReturnLogin.Name = "lnkReturnLogin";
            lnkReturnLogin.Size = new Size(330, 40);
            lnkReturnLogin.TabIndex = 5;
            lnkReturnLogin.TabStop = true;
            lnkReturnLogin.Text = "QUAY LẠI ĐĂNG NHẬP";
            lnkReturnLogin.TextAlign = ContentAlignment.MiddleCenter;
            lnkReturnLogin.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            lnkReturnLogin.Click += lnkReturnLogin_Click;
            // 
            // UC_QuenMatKhau
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlForgotPassCard);
            DoubleBuffered = true;
            Name = "UC_QuenMatKhau";
            Size = new Size(450, 450);
            pnlForgotPassCard.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Sunny.UI.UIPanel pnlForgotPassCard;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UILabel lblDescription;
        private Sunny.UI.UILinkLabel lnkReturnLogin;

        #endregion

        private Sunny.UI.UIListBox lstAdminEmails;
    }
}
