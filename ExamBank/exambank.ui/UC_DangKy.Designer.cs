namespace exambank.ui
{
    partial class UC_DangKy
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
            pnlRegisterCard = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            txtFullName = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            btnRegister = new Sunny.UI.UIButton();
            btnReturnLogin = new Sunny.UI.UIButton();
            pnlRegisterCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegisterCard
            // 
            pnlRegisterCard.Controls.Add(lblTitle);
            pnlRegisterCard.Controls.Add(lblSubTitle);
            pnlRegisterCard.Controls.Add(txtFullName);
            pnlRegisterCard.Controls.Add(txtEmail);
            pnlRegisterCard.Controls.Add(txtUsername);
            pnlRegisterCard.Controls.Add(txtPassword);
            pnlRegisterCard.Controls.Add(txtConfirmPassword);
            pnlRegisterCard.Controls.Add(btnRegister);
            pnlRegisterCard.Controls.Add(btnReturnLogin);
            pnlRegisterCard.Dock = DockStyle.Fill;
            pnlRegisterCard.FillColor = Color.White;
            pnlRegisterCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlRegisterCard.Location = new Point(0, 0);
            pnlRegisterCard.Margin = new Padding(4, 5, 4, 5);
            pnlRegisterCard.MinimumSize = new Size(1, 1);
            pnlRegisterCard.Name = "pnlRegisterCard";
            pnlRegisterCard.Radius = 10;
            pnlRegisterCard.RectColor = Color.FromArgb(220, 220, 220);
            pnlRegisterCard.Size = new Size(450, 600);
            pnlRegisterCard.TabIndex = 0;
            pnlRegisterCard.Text = null;
            pnlRegisterCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(10, 35, 81);
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ HỆ THỐNG";
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
            lblSubTitle.Text = "EduGenAI";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(60, 140);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.MinimumSize = new Size(1, 16);
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(5);
            txtFullName.ShowText = false;
            txtFullName.Size = new Size(330, 35);
            txtFullName.Symbol = 61447;
            txtFullName.TabIndex = 2;
            txtFullName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFullName.Watermark = "Họ tên";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(60, 195);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(330, 35);
            txtEmail.Symbol = 61664;
            txtEmail.TabIndex = 3;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Địa chỉ Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(60, 250);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(330, 35);
            txtUsername.Symbol = 61447;
            txtUsername.TabIndex = 4;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "Tên đăng nhập";
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
            txtPassword.ButtonRectHoverColor = Color.White;
            txtPassword.ButtonRectPressColor = Color.White;
            txtPassword.ButtonStyleInherited = false;
            txtPassword.ButtonSymbol = 61552;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(60, 305);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '*';
            txtPassword.ShowButton = true;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(330, 35);
            txtPassword.Symbol = 61475;
            txtPassword.TabIndex = 5;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Mật khẩu";
            txtPassword.ButtonClick += txtPassword_ButtonClick;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.ButtonFillColor = Color.White;
            txtConfirmPassword.ButtonFillHoverColor = Color.WhiteSmoke;
            txtConfirmPassword.ButtonFillPressColor = Color.WhiteSmoke;
            txtConfirmPassword.ButtonForeColor = Color.Black;
            txtConfirmPassword.ButtonForeHoverColor = Color.Black;
            txtConfirmPassword.ButtonForePressColor = Color.Black;
            txtConfirmPassword.ButtonRectColor = Color.White;
            txtConfirmPassword.ButtonRectHoverColor = Color.White;
            txtConfirmPassword.ButtonRectPressColor = Color.White;
            txtConfirmPassword.ButtonStyleInherited = false;
            txtConfirmPassword.ButtonSymbol = 61552;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(60, 360);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.ShowButton = true;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(330, 35);
            txtConfirmPassword.Symbol = 61475;
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "Xác nhận mật khẩu";
            txtConfirmPassword.ButtonClick += txtConfirmPassword_ButtonClick;
            // 
            // btnRegister
            // 
            btnRegister.FillColor = Color.FromArgb(10, 35, 81);
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.Location = new Point(60, 430);
            btnRegister.MinimumSize = new Size(1, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(330, 45);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturnLogin
            // 
            btnReturnLogin.FillColor = Color.White;
            btnReturnLogin.FillHoverColor = Color.FromArgb(240, 245, 255);
            btnReturnLogin.Font = new Font("Segoe UI", 11F);
            btnReturnLogin.ForeColor = Color.FromArgb(10, 35, 81);
            btnReturnLogin.ForeHoverColor = Color.Navy;
            btnReturnLogin.ForePressColor = Color.Navy;
            btnReturnLogin.ForeSelectedColor = Color.Navy;
            btnReturnLogin.Location = new Point(60, 497);
            btnReturnLogin.MinimumSize = new Size(1, 1);
            btnReturnLogin.Name = "btnReturnLogin";
            btnReturnLogin.RectColor = Color.FromArgb(10, 35, 81);
            btnReturnLogin.Size = new Size(330, 45);
            btnReturnLogin.TabIndex = 6;
            btnReturnLogin.Text = "QUAY LẠI ĐĂNG NHẬP";
            btnReturnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReturnLogin.Click += btnReturnLogin_Click;
            // 
            // UC_DangKy
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlRegisterCard);
            DoubleBuffered = true;
            Name = "UC_DangKy";
            Size = new Size(450, 600);
            pnlRegisterCard.ResumeLayout(false);
            ResumeLayout(false);
        }
        // Khai báo các thành phần SunnyUI
        private Sunny.UI.UIPanel pnlRegisterCard;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UIButton btnRegister;
        private Sunny.UI.UIButton btnReturnLogin;

        #endregion
    }
}
