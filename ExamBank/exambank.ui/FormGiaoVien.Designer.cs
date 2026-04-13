namespace exambank.ui
{
    partial class FormGiaoVien
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoVien));
            SidebarPanel = new Sunny.UI.UIPanel();
            pnlMenu = new Sunny.UI.UIPanel();
            btnViewExamBank = new Sunny.UI.UIButton();
            btnManageExams = new Sunny.UI.UIButton();
            btnManageQuestions = new Sunny.UI.UIButton();
            btnCreateQuestion = new Sunny.UI.UIButton();
            pnlLogo = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            pnlBody = new Sunny.UI.UIPanel();
            SidebarPanel.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(pnlMenu);
            SidebarPanel.Controls.Add(pnlLogo);
            resources.ApplyResources(SidebarPanel, "SidebarPanel");
            SidebarPanel.FillColor = Color.FromArgb(242, 245, 248);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.RectColor = Color.FromArgb(210, 210, 210);
            SidebarPanel.Style = Sunny.UI.UIStyle.Custom;
            SidebarPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MidnightBlue;
            pnlMenu.Controls.Add(btnViewExamBank);
            pnlMenu.Controls.Add(btnManageExams);
            pnlMenu.Controls.Add(btnManageQuestions);
            pnlMenu.Controls.Add(btnCreateQuestion);
            resources.ApplyResources(pnlMenu, "pnlMenu");
            pnlMenu.FillColor = Color.FromArgb(44, 62, 80);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Radius = 0;
            pnlMenu.RectColor = Color.FromArgb(44, 62, 80);
            pnlMenu.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlMenu.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnViewExamBank
            // 
            btnViewExamBank.BackColor = Color.FromArgb(44, 62, 80);
            btnViewExamBank.FillColor = Color.FromArgb(44, 62, 80);
            btnViewExamBank.FillColor2 = Color.FromArgb(44, 62, 80);
            btnViewExamBank.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnViewExamBank.FillPressColor = Color.FromArgb(40, 55, 75);
            btnViewExamBank.FillSelectedColor = Color.FromArgb(70, 90, 110);
            resources.ApplyResources(btnViewExamBank, "btnViewExamBank");
            btnViewExamBank.ForeDisableColor = Color.Black;
            btnViewExamBank.Name = "btnViewExamBank";
            btnViewExamBank.Radius = 15;
            btnViewExamBank.RectColor = Color.FromArgb(44, 62, 80);
            btnViewExamBank.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnViewExamBank.RectPressColor = Color.FromArgb(44, 62, 80);
            btnViewExamBank.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnViewExamBank.RectSides = ToolStripStatusLabelBorderSides.None;
            btnViewExamBank.TextAlign = ContentAlignment.MiddleLeft;
            btnViewExamBank.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnViewExamBank.Click += btnViewExamBank_Click;
            // 
            // btnManageExams
            // 
            btnManageExams.BackColor = Color.FromArgb(44, 62, 80);
            btnManageExams.FillColor = Color.FromArgb(44, 62, 80);
            btnManageExams.FillColor2 = Color.FromArgb(44, 62, 80);
            btnManageExams.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnManageExams.FillPressColor = Color.FromArgb(40, 55, 75);
            btnManageExams.FillSelectedColor = Color.FromArgb(70, 90, 110);
            resources.ApplyResources(btnManageExams, "btnManageExams");
            btnManageExams.ForeDisableColor = Color.Black;
            btnManageExams.Name = "btnManageExams";
            btnManageExams.Radius = 15;
            btnManageExams.RectColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectPressColor = Color.FromArgb(44, 62, 80);
            btnManageExams.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnManageExams.RectSides = ToolStripStatusLabelBorderSides.None;
            btnManageExams.TextAlign = ContentAlignment.MiddleLeft;
            btnManageExams.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageExams.Click += btnManageExams_Click;
            // 
            // btnManageQuestions
            // 
            btnManageQuestions.BackColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillColor2 = Color.FromArgb(44, 62, 80);
            btnManageQuestions.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnManageQuestions.FillPressColor = Color.FromArgb(40, 55, 75);
            btnManageQuestions.FillSelectedColor = Color.FromArgb(70, 90, 110);
            resources.ApplyResources(btnManageQuestions, "btnManageQuestions");
            btnManageQuestions.ForeDisableColor = Color.Black;
            btnManageQuestions.Name = "btnManageQuestions";
            btnManageQuestions.Radius = 15;
            btnManageQuestions.RectColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectPressColor = Color.FromArgb(44, 62, 80);
            btnManageQuestions.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnManageQuestions.RectSides = ToolStripStatusLabelBorderSides.None;
            btnManageQuestions.TextAlign = ContentAlignment.MiddleLeft;
            btnManageQuestions.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageQuestions.Click += btnManageQuestions_Click;
            // 
            // btnCreateQuestion
            // 
            btnCreateQuestion.BackColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillColor2 = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.FillHoverColor = Color.FromArgb(55, 75, 95);
            btnCreateQuestion.FillPressColor = Color.FromArgb(40, 55, 75);
            btnCreateQuestion.FillSelectedColor = Color.FromArgb(70, 90, 110);
            resources.ApplyResources(btnCreateQuestion, "btnCreateQuestion");
            btnCreateQuestion.ForeDisableColor = Color.Black;
            btnCreateQuestion.Name = "btnCreateQuestion";
            btnCreateQuestion.Radius = 15;
            btnCreateQuestion.RectColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectHoverColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectPressColor = Color.FromArgb(44, 62, 80);
            btnCreateQuestion.RectSelectedColor = Color.FromArgb(30, 50, 60);
            btnCreateQuestion.RectSides = ToolStripStatusLabelBorderSides.None;
            btnCreateQuestion.Selected = true;
            btnCreateQuestion.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateQuestion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCreateQuestion.Click += btnCreateQuestion_Click;
            // 
            // pnlLogo
            // 
            resources.ApplyResources(pnlLogo, "pnlLogo");
            pnlLogo.Controls.Add(lblTitle);
            pnlLogo.Controls.Add(lblSubTitle);
            pnlLogo.FillColor = Color.FromArgb(44, 62, 80);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Radius = 0;
            pnlLogo.RectColor = Color.FromArgb(44, 62, 80);
            pnlLogo.RectDisableColor = Color.FromArgb(44, 62, 80);
            pnlLogo.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlLogo.Style = Sunny.UI.UIStyle.Custom;
            pnlLogo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(44, 62, 80);
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            // 
            // lblSubTitle
            // 
            lblSubTitle.BackColor = Color.FromArgb(44, 62, 80);
            resources.ApplyResources(lblSubTitle, "lblSubTitle");
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Name = "lblSubTitle";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            resources.ApplyResources(pnlBody, "pnlBody");
            pnlBody.FillColor = Color.White;
            pnlBody.Name = "pnlBody";
            pnlBody.RectColor = Color.FromArgb(44, 62, 80);
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormGiaoVien
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(pnlBody);
            Controls.Add(SidebarPanel);
            Name = "FormGiaoVien";
            Resizable = true;
            ZoomScaleRect = new Rectangle(19, 19, 1050, 700);
            SidebarPanel.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel SidebarPanel;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UIPanel pnlMenu;
        private Sunny.UI.UIButton btnViewExamBank;
        private Sunny.UI.UIButton btnManageExams;
        private Sunny.UI.UIButton btnManageQuestions;
        private Sunny.UI.UIButton btnCreateQuestion;
    }

        #endregion
}