namespace exambank.ui
{
    partial class UC_DangNhap
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
            pnlLoginCard = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            lnkForgotPassword = new Sunny.UI.UILinkLabel();
            btnLogin = new Sunny.UI.UIButton();
            btnRegister = new Sunny.UI.UIButton();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Controls.Add(lblSubTitle);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(lnkForgotPassword);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(btnRegister);
            pnlLoginCard.Dock = DockStyle.Fill;
            pnlLoginCard.FillColor = Color.White;
            pnlLoginCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlLoginCard.Location = new Point(0, 0);
            pnlLoginCard.Margin = new Padding(4, 5, 4, 5);
            pnlLoginCard.MinimumSize = new Size(1, 1);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Radius = 10;
            pnlLoginCard.RectColor = Color.FromArgb(220, 220, 220);
            pnlLoginCard.Size = new Size(450, 600);
            pnlLoginCard.TabIndex = 0;
            pnlLoginCard.Text = null;
            pnlLoginCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(10, 35, 81);
            lblTitle.Location = new Point(50, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.FromArgb(10, 35, 81);
            lblSubTitle.Location = new Point(50, 80);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(350, 50);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "EduGenAI";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(60, 160);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(330, 35);
            txtUsername.Symbol = 61447;
            txtUsername.TabIndex = 2;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "Email/Tên đăng nhập";
            txtUsername.WatermarkActiveColor = Color.White;
            // 
            // txtPassword
            // 
            txtPassword.ButtonFillColor = Color.White;
            txtPassword.ButtonFillHoverColor = Color.WhiteSmoke;
            txtPassword.ButtonFillPressColor = Color.WhiteSmoke;
            txtPassword.ButtonForeColor = Color.Black;
            txtPassword.ButtonForeHoverColor = Color.Black;
            txtPassword.ButtonForePressColor = Color.Black;
            txtPassword.ButtonRectColor = Color.White;
            txtPassword.ButtonStyleInherited = false;
            txtPassword.ButtonSymbol = 61552;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(60, 220);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '*';
            txtPassword.ShowButton = true;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(330, 35);
            txtPassword.Symbol = 61475;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Mật khẩu";
            txtPassword.WatermarkActiveColor = Color.White;
            txtPassword.ButtonClick += txtPassword_ButtonClick;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            lnkForgotPassword.Font = new Font("Segoe UI", 9F);
            lnkForgotPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lnkForgotPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkForgotPassword.LinkColor = Color.DimGray;
            lnkForgotPassword.Location = new Point(270, 260);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(120, 20);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Quên mật khẩu?";
            lnkForgotPassword.TextAlign = ContentAlignment.MiddleRight;
            lnkForgotPassword.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            lnkForgotPassword.Click += LnkForgotPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.FillColor = Color.FromArgb(10, 35, 81);
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.Location = new Point(60, 310);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.FillColor = Color.White;
            btnRegister.FillHoverColor = Color.FromArgb(240, 245, 255);
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.ForeColor = Color.FromArgb(10, 35, 81);
            btnRegister.ForeHoverColor = Color.Navy;
            btnRegister.ForePressColor = Color.Navy;
            btnRegister.ForeSelectedColor = Color.Navy;
            btnRegister.Location = new Point(60, 370);
            btnRegister.MinimumSize = new Size(1, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.RectColor = Color.FromArgb(10, 35, 81);
            btnRegister.Size = new Size(330, 45);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRegister.Click += BtnRegister_Click;
            // 
            // UC_DangNhap
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlLoginCard);
            DoubleBuffered = true;
            Name = "UC_DangNhap";
            Size = new Size(450, 600);
            pnlLoginCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlLoginCard;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UIButton btnRegister;
        private Sunny.UI.UILinkLabel lnkForgotPassword;

        #endregion
    }
}
