namespace exambank.ui
{
    partial class FormGiaoVien
    {
        private System.ComponentModel.IContainer components = null;

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
            panelSidebar = new Sunny.UI.UIPanel();
            btnViewExamBank = new Sunny.UI.UIButton();
            btnManageExams = new Sunny.UI.UIButton();
            btnManageQuestions = new Sunny.UI.UIButton();
            btnCreateQuestion = new Sunny.UI.UIButton();
            btnHome = new Sunny.UI.UIButton();
            pnlSpacer = new Sunny.UI.UIPanel();
            lblLogo = new Sunny.UI.UILabel();
            pnlUser = new Sunny.UI.UIPanel();
            lblSidebarRole = new Sunny.UI.UILabel();
            lblSidebarName = new Sunny.UI.UILabel();
            avtUser = new Sunny.UI.UIAvatar();
            pnlBody = new Sunny.UI.UIPanel();
            panelSidebar.SuspendLayout();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(btnViewExamBank);
            panelSidebar.Controls.Add(btnManageExams);
            panelSidebar.Controls.Add(btnManageQuestions);
            panelSidebar.Controls.Add(btnCreateQuestion);
            panelSidebar.Controls.Add(btnHome);
            panelSidebar.Controls.Add(pnlSpacer);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(pnlUser);
            resources.ApplyResources(panelSidebar, "panelSidebar");
            panelSidebar.FillColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Radius = 0;
            panelSidebar.RectColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Style = Sunny.UI.UIStyle.Custom;
            panelSidebar.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnViewExamBank
            // 
            btnViewExamBank.Cursor = Cursors.Hand;
            resources.ApplyResources(btnViewExamBank, "btnViewExamBank");
            btnViewExamBank.FillColor = Color.Transparent;
            btnViewExamBank.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnViewExamBank.FillPressColor = Color.FromArgb(15, 23, 42);
            btnViewExamBank.ForeColor = Color.FromArgb(203, 213, 225);
            btnViewExamBank.Name = "btnViewExamBank";
            btnViewExamBank.Radius = 0;
            btnViewExamBank.RectColor = Color.FromArgb(30, 41, 59);
            btnViewExamBank.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnViewExamBank.Style = Sunny.UI.UIStyle.Custom;
            btnViewExamBank.TextAlign = ContentAlignment.MiddleLeft;
            btnViewExamBank.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnViewExamBank.Click += btnViewExamBank_Click;
            // 
            // btnManageExams
            // 
            btnManageExams.Cursor = Cursors.Hand;
            resources.ApplyResources(btnManageExams, "btnManageExams");
            btnManageExams.FillColor = Color.Transparent;
            btnManageExams.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnManageExams.FillPressColor = Color.FromArgb(15, 23, 42);
            btnManageExams.ForeColor = Color.FromArgb(203, 213, 225);
            btnManageExams.Name = "btnManageExams";
            btnManageExams.Radius = 0;
            btnManageExams.RectColor = Color.FromArgb(30, 41, 59);
            btnManageExams.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnManageExams.Style = Sunny.UI.UIStyle.Custom;
            btnManageExams.TextAlign = ContentAlignment.MiddleLeft;
            btnManageExams.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageExams.Click += btnManageExams_Click;
            // 
            // btnManageQuestions
            // 
            btnManageQuestions.Cursor = Cursors.Hand;
            resources.ApplyResources(btnManageQuestions, "btnManageQuestions");
            btnManageQuestions.FillColor = Color.Transparent;
            btnManageQuestions.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnManageQuestions.FillPressColor = Color.FromArgb(15, 23, 42);
            btnManageQuestions.ForeColor = Color.FromArgb(203, 213, 225);
            btnManageQuestions.Name = "btnManageQuestions";
            btnManageQuestions.Radius = 0;
            btnManageQuestions.RectColor = Color.FromArgb(30, 41, 59);
            btnManageQuestions.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnManageQuestions.Style = Sunny.UI.UIStyle.Custom;
            btnManageQuestions.TextAlign = ContentAlignment.MiddleLeft;
            btnManageQuestions.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageQuestions.Click += btnManageQuestions_Click;
            // 
            // btnCreateQuestion
            // 
            btnCreateQuestion.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCreateQuestion, "btnCreateQuestion");
            btnCreateQuestion.FillColor = Color.Transparent;
            btnCreateQuestion.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnCreateQuestion.FillPressColor = Color.FromArgb(15, 23, 42);
            btnCreateQuestion.ForeColor = Color.FromArgb(203, 213, 225);
            btnCreateQuestion.Name = "btnCreateQuestion";
            btnCreateQuestion.Radius = 0;
            btnCreateQuestion.RectColor = Color.FromArgb(30, 41, 59);
            btnCreateQuestion.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnCreateQuestion.Style = Sunny.UI.UIStyle.Custom;
            btnCreateQuestion.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateQuestion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCreateQuestion.Click += btnCreateQuestion_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            resources.ApplyResources(btnHome, "btnHome");
            btnHome.FillColor = Color.Transparent;
            btnHome.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnHome.FillPressColor = Color.FromArgb(15, 23, 42);
            btnHome.ForeColor = Color.FromArgb(203, 213, 225);
            btnHome.Name = "btnHome";
            btnHome.Radius = 0;
            btnHome.RectColor = Color.FromArgb(30, 41, 59);
            btnHome.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnHome.Style = Sunny.UI.UIStyle.Custom;
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnHome.Click += btnHome_Click;
            // 
            // pnlSpacer
            // 
            resources.ApplyResources(pnlSpacer, "pnlSpacer");
            pnlSpacer.FillColor = Color.FromArgb(30, 41, 59);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Radius = 0;
            pnlSpacer.RectColor = Color.FromArgb(30, 41, 59);
            pnlSpacer.Style = Sunny.UI.UIStyle.Custom;
            pnlSpacer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            resources.ApplyResources(lblLogo, "lblLogo");
            lblLogo.ForeColor = Color.FromArgb(56, 189, 248);
            lblLogo.Name = "lblLogo";
            lblLogo.Style = Sunny.UI.UIStyle.Custom;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.FromArgb(15, 23, 42);
            pnlUser.Controls.Add(lblSidebarRole);
            pnlUser.Controls.Add(lblSidebarName);
            pnlUser.Controls.Add(avtUser);
            resources.ApplyResources(pnlUser, "pnlUser");
            pnlUser.FillColor = Color.FromArgb(15, 23, 42);
            pnlUser.Name = "pnlUser";
            pnlUser.Radius = 0;
            pnlUser.RectColor = Color.FromArgb(15, 23, 42);
            pnlUser.Style = Sunny.UI.UIStyle.Custom;
            pnlUser.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSidebarRole
            // 
            lblSidebarRole.BackColor = Color.Transparent;
            resources.ApplyResources(lblSidebarRole, "lblSidebarRole");
            lblSidebarRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblSidebarRole.Name = "lblSidebarRole";
            lblSidebarRole.Style = Sunny.UI.UIStyle.Custom;
            // 
            // lblSidebarName
            // 
            lblSidebarName.BackColor = Color.Transparent;
            resources.ApplyResources(lblSidebarName, "lblSidebarName");
            lblSidebarName.ForeColor = Color.White;
            lblSidebarName.Name = "lblSidebarName";
            lblSidebarName.Style = Sunny.UI.UIStyle.Custom;
            // 
            // avtUser
            // 
            avtUser.BackColor = Color.Transparent;
            avtUser.Cursor = Cursors.Hand;
            avtUser.FillColor = Color.FromArgb(56, 189, 248);
            resources.ApplyResources(avtUser, "avtUser");
            avtUser.Name = "avtUser";
            avtUser.Click += avtUser_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 244, 246);
            resources.ApplyResources(pnlBody, "pnlBody");
            pnlBody.FillColor = Color.FromArgb(243, 244, 246);
            pnlBody.Name = "pnlBody";
            pnlBody.Radius = 0;
            pnlBody.RectColor = Color.FromArgb(243, 244, 246);
            pnlBody.Style = Sunny.UI.UIStyle.Custom;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormGiaoVien
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            Controls.Add(pnlBody);
            Controls.Add(panelSidebar);
            Name = "FormGiaoVien";
            WindowState = FormWindowState.Maximized;
            ZoomScaleRect = new Rectangle(15, 15, 1200, 800);
            FormClosing += FormGiaoVien_FormClosing;
            panelSidebar.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelSidebar;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UILabel lblLogo;
        private Sunny.UI.UIPanel pnlSpacer;
        private Sunny.UI.UIButton btnHome;
        private Sunny.UI.UIButton btnCreateQuestion;
        private Sunny.UI.UIButton btnManageQuestions;
        private Sunny.UI.UIButton btnManageExams;
        private Sunny.UI.UIButton btnViewExamBank;
        private Sunny.UI.UIPanel pnlUser;
        private Sunny.UI.UILabel lblSidebarName;
        private Sunny.UI.UILabel lblSidebarRole;
        private Sunny.UI.UIAvatar avtUser;
    }
}