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
            btnManageExams = new Sunny.UI.UIButton();
            btnManageQuestions = new Sunny.UI.UIButton();
            btnCreateQuestion = new Sunny.UI.UIButton();
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
            pnlMenu.Controls.Add(btnManageExams);
            pnlMenu.Controls.Add(btnManageQuestions);
            pnlMenu.Controls.Add(btnCreateQuestion);
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
            // 
            // btnManageExams
            // 
            btnManageExams.BackColor = Color.FromArgb(44, 62, 80);
            btnManageExams.FillColor = Color.FromArgb(44, 62, 80);
            btnManageExams.FillColor2 = Color.FromArgb(44, 62, 80);
            btnManageExams.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnManageExams.FillPressColor = Color.FromArgb(40, 55, 75);
            btnManageExams.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnManageExams.Font = new Font("Times New Roman", 13.8F);
            btnManageExams.ForeDisableColor = Color.Black;
            btnManageExams.Location = new Point(3, 258);
            btnManageExams.MinimumSize = new Size(1, 1);
            btnManageExams.Name = "btnManageExams";
            btnManageExams.Radius = 15;
            btnManageExams.RectColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectPressColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnManageExams.RectSides = ToolStripStatusLabelBorderSides.None;
            btnManageExams.Size = new Size(273, 80);
            btnManageExams.TabIndex = 2;
            btnManageExams.Text = "Cấu hình tham số AI";
            btnManageExams.TextAlign = ContentAlignment.MiddleLeft;
            btnManageExams.TipsFont = new Font("Times New Roman", 9F);
            // 
            // btnManageQuestions
            // 
            btnManageQuestions.BackColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillColor2 = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnManageQuestions.FillPressColor = Color.FromArgb(40, 55, 75);
            btnManageQuestions.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnManageQuestions.Font = new Font("Times New Roman", 13.8F);
            btnManageQuestions.ForeDisableColor = Color.Black;
            btnManageQuestions.Location = new Point(3, 176);
            btnManageQuestions.MinimumSize = new Size(1, 1);
            btnManageQuestions.Name = "btnManageQuestions";
            btnManageQuestions.Radius = 15;
            btnManageQuestions.RectColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectPressColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnManageQuestions.RectSides = ToolStripStatusLabelBorderSides.None;
            btnManageQuestions.Size = new Size(273, 80);
            btnManageQuestions.TabIndex = 1;
            btnManageQuestions.Text = "Quản lý ngân hàng đề thi";
            btnManageQuestions.TextAlign = ContentAlignment.MiddleLeft;
            btnManageQuestions.TipsFont = new Font("Times New Roman", 9F);
            // 
            // btnCreateQuestion
            // 
            btnCreateQuestion.BackColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillColor2 = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnCreateQuestion.FillPressColor = Color.FromArgb(40, 55, 75);
            btnCreateQuestion.FillSelectedColor = Color.FromArgb(70, 90, 110);
            btnCreateQuestion.Font = new Font("Times New Roman", 13.8F);
            btnCreateQuestion.ForeDisableColor = Color.Black;
            btnCreateQuestion.Location = new Point(3, 94);
            btnCreateQuestion.MinimumSize = new Size(1, 1);
            btnCreateQuestion.Name = "btnCreateQuestion";
            btnCreateQuestion.Radius = 15;
            btnCreateQuestion.RectColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectPressColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnCreateQuestion.RectSides = ToolStripStatusLabelBorderSides.None;
            btnCreateQuestion.Selected = true;
            btnCreateQuestion.Size = new Size(273, 80);
            btnCreateQuestion.TabIndex = 0;
            btnCreateQuestion.Text = "Quản lý tài khoản";
            btnCreateQuestion.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateQuestion.TipsFont = new Font("Times New Roman", 9F);
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
            Controls.Add(pnlBody);
            Controls.Add(pnlSidebar);
            Name = "FormAdmin";
            Text = "FormAdmin";
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
        private Sunny.UI.UIButton btnManageExams;
        private Sunny.UI.UIButton btnManageQuestions;
        private Sunny.UI.UIButton btnCreateQuestion;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UISymbolButton btnLog;
    }
}