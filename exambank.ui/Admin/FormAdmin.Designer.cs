namespace exambank.ui
{
    partial class FormAdmin
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
            pnlSidebar = new Sunny.UI.UIPanel();
            pnlMenu = new Sunny.UI.UIPanel();
            btnLog = new Sunny.UI.UISymbolButton();
            btnHome = new Sunny.UI.UIButton();
            btnAIConfig = new Sunny.UI.UIButton();
            btnExamBank = new Sunny.UI.UIButton();
            btnManageUsers = new Sunny.UI.UIButton();
            pnlLogo = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            pnlBody = new Sunny.UI.UIPanel();
            pnlSidebar.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlMenu);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.FillColor = Color.FromArgb(242, 245, 248);
            pnlSidebar.Font = new Font("Segoe UI", 12F);
            pnlSidebar.Location = new Point(0, 35);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.MinimumSize = new Size(1, 1);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.RectColor = Color.FromArgb(210, 210, 210);
            pnlSidebar.Size = new Size(280, 665);
            pnlSidebar.Style = Sunny.UI.UIStyle.Custom;
            pnlSidebar.TabIndex = 1;
            pnlSidebar.Text = null;
            pnlSidebar.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MidnightBlue;
            pnlMenu.Controls.Add(btnLog);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnAIConfig);
            pnlMenu.Controls.Add(btnExamBank);
            pnlMenu.Controls.Add(btnManageUsers);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.FillColor = Color.FromArgb(44, 62, 80);
            pnlMenu.Font = new Font("Microsoft Sans Serif", 12F);
            pnlMenu.Location = new Point(0, 184);
            pnlMenu.Margin = new Padding(4, 5, 4, 5);
            pnlMenu.MinimumSize = new Size(1, 1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Radius = 0;
            pnlMenu.RectColor = Color.FromArgb(44, 62, 80);
            pnlMenu.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlMenu.Size = new Size(280, 481);
            pnlMenu.TabIndex = 1;
            pnlMenu.Text = null;
            pnlMenu.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnLog
            // 
            btnLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLog.BackColor = Color.MediumBlue;
            btnLog.FillColor = Color.Gainsboro;
            btnLog.FillColor2 = Color.Gainsboro;
            btnLog.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.Black;
            btnLog.ForeDisableColor = Color.Black;
            btnLog.ForeHoverColor = Color.Black;
            btnLog.ForePressColor = Color.Black;
            btnLog.ForeSelectedColor = Color.Black;
            btnLog.Location = new Point(30, 391);
            btnLog.MinimumSize = new Size(1, 1);
            btnLog.Name = "btnLog";
            btnLog.Radius = 10;
            btnLog.Size = new Size(221, 45);
            btnLog.Style = Sunny.UI.UIStyle.Custom;
            btnLog.Symbol = 0;
            btnLog.SymbolColor = Color.Black;
            btnLog.SymbolHoverColor = Color.Black;
            btnLog.SymbolPressColor = Color.Black;
            btnLog.SymbolSelectedColor = Color.Black;
            btnLog.TabIndex = 8;
            btnLog.Text = "Đăng xuất";
            btnLog.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLog.Click += btnLog_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(44, 62, 80);
            btnHome.FillColor = Color.FromArgb(44, 62, 80);
            btnHome.FillColor2 = Color.FromArgb(44, 62, 80);
            btnHome.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnHome.FillPressColor = Color.FromArgb(40, 55, 75);
            btnHome.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnHome.Font = new Font("Times New Roman", 13.8F);
            btnHome.ForeDisableColor = Color.Black;
            btnHome.Location = new Point(3, 8);
            btnHome.MinimumSize = new Size(1, 1);
            btnHome.Name = "btnHome";
            btnHome.Radius = 15;
            btnHome.RectColor = Color.FromArgb(44, 62, 80);
            btnHome.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnHome.RectPressColor = Color.FromArgb(44, 62, 80);
            btnHome.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnHome.RectSides = ToolStripStatusLabelBorderSides.None;
            btnHome.Size = new Size(273, 80);
            btnHome.TabIndex = 4;
            btnHome.Text = "Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TipsFont = new Font("Times New Roman", 9F);
            btnHome.Click += btnHome_Click;
            // 
            // btnAIConfig
            // 
            btnAIConfig.BackColor = Color.FromArgb(44, 62, 80);
            btnAIConfig.FillColor = Color.FromArgb(44, 62, 80);
            btnAIConfig.FillColor2 = Color.FromArgb(44, 62, 80);
            btnAIConfig.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnAIConfig.FillPressColor = Color.FromArgb(40, 55, 75);
            btnAIConfig.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnAIConfig.Font = new Font("Times New Roman", 13.8F);
            btnAIConfig.ForeDisableColor = Color.Black;
            btnAIConfig.Location = new Point(3, 258);
            btnAIConfig.MinimumSize = new Size(1, 1);
            btnAIConfig.Name = "btnAIConfig";
            btnAIConfig.Radius = 15;
            btnAIConfig.RectColor = Color.FromArgb(44, 62, 80);
            btnAIConfig.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnAIConfig.RectPressColor = Color.FromArgb(44, 62, 80);
            btnAIConfig.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnAIConfig.RectSides = ToolStripStatusLabelBorderSides.None;
            btnAIConfig.Size = new Size(273, 80);
            btnAIConfig.TabIndex = 2;
            btnAIConfig.Text = "Cấu hình tham số AI";
            btnAIConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnAIConfig.TipsFont = new Font("Times New Roman", 9F);
            btnAIConfig.Click += btnAIConfig_Click;
            // 
            // btnExamBank
            // 
            btnExamBank.BackColor = Color.FromArgb(44, 62, 80);
            btnExamBank.FillColor = Color.FromArgb(44, 62, 80);
            btnExamBank.FillColor2 = Color.FromArgb(44, 62, 80);
            btnExamBank.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnExamBank.FillPressColor = Color.FromArgb(40, 55, 75);
            btnExamBank.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnExamBank.Font = new Font("Times New Roman", 13.8F);
            btnExamBank.ForeDisableColor = Color.Black;
            btnExamBank.Location = new Point(3, 176);
            btnExamBank.MinimumSize = new Size(1, 1);
            btnExamBank.Name = "btnExamBank";
            btnExamBank.Radius = 15;
            btnExamBank.RectColor = Color.FromArgb(44, 62, 80);
            btnExamBank.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnExamBank.RectPressColor = Color.FromArgb(44, 62, 80);
            btnExamBank.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnExamBank.RectSides = ToolStripStatusLabelBorderSides.None;
            btnExamBank.Size = new Size(273, 80);
            btnExamBank.TabIndex = 1;
            btnExamBank.Text = "Quản lý ngân hàng đề thi";
            btnExamBank.TextAlign = ContentAlignment.MiddleLeft;
            btnExamBank.TipsFont = new Font("Times New Roman", 9F);
            btnExamBank.Click += btnExamBank_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.FromArgb(44, 62, 80);
            btnManageUsers.FillColor = Color.FromArgb(44, 62, 80);
            btnManageUsers.FillColor2 = Color.FromArgb(44, 62, 80);
            btnManageUsers.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnManageUsers.FillPressColor = Color.FromArgb(40, 55, 75);
            btnManageUsers.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnManageUsers.Font = new Font("Times New Roman", 13.8F);
            btnManageUsers.ForeDisableColor = Color.Black;
            btnManageUsers.Location = new Point(3, 94);
            btnManageUsers.MinimumSize = new Size(1, 1);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Radius = 15;
            btnManageUsers.RectColor = Color.FromArgb(44, 62, 80);
            btnManageUsers.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnManageUsers.RectPressColor = Color.FromArgb(44, 62, 80);
            btnManageUsers.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnManageUsers.RectSides = ToolStripStatusLabelBorderSides.None;
            btnManageUsers.Selected = true;
            btnManageUsers.Size = new Size(273, 80);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Quản lý tài khoản";
            btnManageUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.TipsFont = new Font("Times New Roman", 9F);
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pnlLogo.Controls.Add(lblTitle);
            pnlLogo.Controls.Add(lblSubTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.FillColor = Color.FromArgb(44, 62, 80);
            pnlLogo.Font = new Font("Microsoft Sans Serif", 12F);
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(4, 5, 4, 5);
            pnlLogo.MinimumSize = new Size(1, 1);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Radius = 0;
            pnlLogo.RectColor = Color.FromArgb(44, 62, 80);
            pnlLogo.RectDisableColor = Color.FromArgb(44, 62, 80);
            pnlLogo.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlLogo.Size = new Size(280, 184);
            pnlLogo.Style = Sunny.UI.UIStyle.Custom;
            pnlLogo.TabIndex = 0;
            pnlLogo.Text = null;
            pnlLogo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(44, 62, 80);
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.ImeMode = ImeMode.NoControl;
            lblTitle.Location = new Point(3, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Hệ thống";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.BackColor = Color.FromArgb(44, 62, 80);
            lblSubTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.ImeMode = ImeMode.NoControl;
            lblSubTitle.Location = new Point(3, 79);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(255, 55);
            lblSubTitle.TabIndex = 3;
            lblSubTitle.Text = "EduGenAI";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.FillColor = Color.White;
            pnlBody.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBody.Location = new Point(280, 35);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.RectColor = Color.FromArgb(44, 62, 80);
            pnlBody.Size = new Size(770, 665);
            pnlBody.TabIndex = 2;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1050, 700);
            ControlBoxForeColor = Color.Black;
            Controls.Add(pnlBody);
            Controls.Add(pnlSidebar);
            Name = "FormAdmin";
            RectColor = Color.Gray;
            Text = "Form Admin";
            TitleColor = SystemColors.ActiveCaption;
            TitleFont = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleForeColor = Color.Black;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            FormClosing += FormAdmin_FormClosing;
            pnlSidebar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlSidebar;
        private Sunny.UI.UIPanel pnlMenu;
        private Sunny.UI.UIButton btnHome;
        private Sunny.UI.UIButton btnAIConfig;
        private Sunny.UI.UIButton btnExamBank;
        private Sunny.UI.UIButton btnManageUsers;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UISymbolButton btnLog;
    }
}