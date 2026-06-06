namespace exambank.ui
{
    partial class FormAdmin
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
            panelSidebar = new Sunny.UI.UIPanel();
            btnConfigAI = new Sunny.UI.UIButton();
            btnManageExamBank = new Sunny.UI.UIButton();
            btnManageAccount = new Sunny.UI.UIButton();
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
            panelSidebar.Controls.Add(btnConfigAI);
            panelSidebar.Controls.Add(btnManageExamBank);
            panelSidebar.Controls.Add(btnManageAccount);
            panelSidebar.Controls.Add(btnHome);
            panelSidebar.Controls.Add(pnlSpacer);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(pnlUser);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.FillColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Font = new Font("Segoe UI", 12F);
            panelSidebar.Location = new Point(0, 35);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.MinimumSize = new Size(1, 1);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Radius = 0;
            panelSidebar.RectColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Size = new Size(280, 765);
            panelSidebar.Style = Sunny.UI.UIStyle.Custom;
            panelSidebar.TabIndex = 0;
            panelSidebar.Text = null;
            panelSidebar.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnConfigAI
            // 
            btnConfigAI.Cursor = Cursors.Hand;
            btnConfigAI.Dock = DockStyle.Top;
            btnConfigAI.FillColor = Color.Transparent;
            btnConfigAI.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnConfigAI.FillPressColor = Color.FromArgb(15, 23, 42);
            btnConfigAI.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfigAI.ForeColor = Color.FromArgb(203, 213, 225);
            btnConfigAI.Location = new Point(0, 315);
            btnConfigAI.MinimumSize = new Size(1, 1);
            btnConfigAI.Name = "btnConfigAI";
            btnConfigAI.Padding = new Padding(30, 0, 0, 0);
            btnConfigAI.Radius = 0;
            btnConfigAI.RectColor = Color.FromArgb(30, 41, 59);
            btnConfigAI.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnConfigAI.Size = new Size(280, 65);
            btnConfigAI.Style = Sunny.UI.UIStyle.Custom;
            btnConfigAI.TabIndex = 5;
            btnConfigAI.Text = "Cấu hình tham số AI";
            btnConfigAI.TextAlign = ContentAlignment.MiddleLeft;
            btnConfigAI.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnConfigAI.Click += btnConfigAI_Click;
            // 
            // btnManageExamBank
            // 
            btnManageExamBank.Cursor = Cursors.Hand;
            btnManageExamBank.Dock = DockStyle.Top;
            btnManageExamBank.FillColor = Color.Transparent;
            btnManageExamBank.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnManageExamBank.FillPressColor = Color.FromArgb(15, 23, 42);
            btnManageExamBank.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageExamBank.ForeColor = Color.FromArgb(203, 213, 225);
            btnManageExamBank.Location = new Point(0, 250);
            btnManageExamBank.MinimumSize = new Size(1, 1);
            btnManageExamBank.Name = "btnManageExamBank";
            btnManageExamBank.Padding = new Padding(30, 0, 0, 0);
            btnManageExamBank.Radius = 0;
            btnManageExamBank.RectColor = Color.FromArgb(30, 41, 59);
            btnManageExamBank.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnManageExamBank.Size = new Size(280, 65);
            btnManageExamBank.Style = Sunny.UI.UIStyle.Custom;
            btnManageExamBank.TabIndex = 4;
            btnManageExamBank.Text = "Quản lý ngân hàng đề thi";
            btnManageExamBank.TextAlign = ContentAlignment.MiddleLeft;
            btnManageExamBank.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageExamBank.Click += btnManageExamBank_Click;
            // 
            // btnManageAccount
            // 
            btnManageAccount.Cursor = Cursors.Hand;
            btnManageAccount.Dock = DockStyle.Top;
            btnManageAccount.FillColor = Color.Transparent;
            btnManageAccount.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnManageAccount.FillPressColor = Color.FromArgb(15, 23, 42);
            btnManageAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageAccount.ForeColor = Color.FromArgb(203, 213, 225);
            btnManageAccount.Location = new Point(0, 185);
            btnManageAccount.MinimumSize = new Size(1, 1);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Padding = new Padding(30, 0, 0, 0);
            btnManageAccount.Radius = 0;
            btnManageAccount.RectColor = Color.FromArgb(30, 41, 59);
            btnManageAccount.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnManageAccount.Size = new Size(280, 65);
            btnManageAccount.Style = Sunny.UI.UIStyle.Custom;
            btnManageAccount.TabIndex = 3;
            btnManageAccount.Text = "Quản lý tài khoản";
            btnManageAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnManageAccount.Click += btnManageAccount_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FillColor = Color.Transparent;
            btnHome.FillHoverColor = Color.FromArgb(51, 65, 85);
            btnHome.FillPressColor = Color.FromArgb(15, 23, 42);
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(203, 213, 225);
            btnHome.Location = new Point(0, 120);
            btnHome.MinimumSize = new Size(1, 1);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Radius = 0;
            btnHome.RectColor = Color.FromArgb(30, 41, 59);
            btnHome.RectHoverColor = Color.FromArgb(51, 65, 85);
            btnHome.Size = new Size(280, 65);
            btnHome.Style = Sunny.UI.UIStyle.Custom;
            btnHome.TabIndex = 1;
            btnHome.Text = "Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnHome.Click += btnHome_Click;
            // 
            // pnlSpacer
            // 
            pnlSpacer.Dock = DockStyle.Top;
            pnlSpacer.FillColor = Color.FromArgb(30, 41, 59);
            pnlSpacer.Font = new Font("Segoe UI", 12F);
            pnlSpacer.Location = new Point(0, 100);
            pnlSpacer.Margin = new Padding(4, 5, 4, 5);
            pnlSpacer.MinimumSize = new Size(1, 1);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Radius = 0;
            pnlSpacer.RectColor = Color.FromArgb(30, 41, 59);
            pnlSpacer.Size = new Size(280, 20);
            pnlSpacer.Style = Sunny.UI.UIStyle.Custom;
            pnlSpacer.TabIndex = 7;
            pnlSpacer.Text = null;
            pnlSpacer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(56, 189, 248);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(280, 100);
            lblLogo.Style = Sunny.UI.UIStyle.Custom;
            lblLogo.TabIndex = 0;
            lblLogo.Text = "EduGenAI";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.FromArgb(15, 23, 42);
            pnlUser.Controls.Add(lblSidebarRole);
            pnlUser.Controls.Add(lblSidebarName);
            pnlUser.Controls.Add(avtUser);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.FillColor = Color.FromArgb(15, 23, 42);
            pnlUser.Font = new Font("Segoe UI", 12F);
            pnlUser.Location = new Point(0, 665);
            pnlUser.Margin = new Padding(4, 5, 4, 5);
            pnlUser.MinimumSize = new Size(1, 1);
            pnlUser.Name = "pnlUser";
            pnlUser.Radius = 0;
            pnlUser.RectColor = Color.FromArgb(15, 23, 42);
            pnlUser.Size = new Size(280, 100);
            pnlUser.Style = Sunny.UI.UIStyle.Custom;
            pnlUser.TabIndex = 6;
            pnlUser.Text = null;
            pnlUser.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSidebarRole
            // 
            lblSidebarRole.BackColor = Color.Transparent;
            lblSidebarRole.Font = new Font("Segoe UI", 10F);
            lblSidebarRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblSidebarRole.Location = new Point(90, 52);
            lblSidebarRole.Name = "lblSidebarRole";
            lblSidebarRole.Size = new Size(160, 23);
            lblSidebarRole.Style = Sunny.UI.UIStyle.Custom;
            lblSidebarRole.TabIndex = 8;
            lblSidebarRole.Text = "Quản trị viên";
            lblSidebarRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSidebarName
            // 
            lblSidebarName.BackColor = Color.Transparent;
            lblSidebarName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSidebarName.ForeColor = Color.White;
            lblSidebarName.Location = new Point(90, 25);
            lblSidebarName.Name = "lblSidebarName";
            lblSidebarName.Size = new Size(180, 28);
            lblSidebarName.Style = Sunny.UI.UIStyle.Custom;
            lblSidebarName.TabIndex = 7;
            lblSidebarName.Text = "Hoàng Hưng";
            lblSidebarName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avtUser
            // 
            avtUser.BackColor = Color.Transparent;
            avtUser.Cursor = Cursors.Hand;
            avtUser.FillColor = Color.FromArgb(239, 68, 68);
            avtUser.Font = new Font("Segoe UI", 14F);
            avtUser.Location = new Point(20, 20);
            avtUser.MinimumSize = new Size(1, 1);
            avtUser.Name = "avtUser";
            avtUser.Size = new Size(60, 60);
            avtUser.TabIndex = 6;
            avtUser.Text = "AD";
            avtUser.Click += avtUser_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 244, 246);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.FillColor = Color.FromArgb(243, 244, 246);
            pnlBody.Font = new Font("Segoe UI", 12F);
            pnlBody.Location = new Point(280, 35);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.Radius = 0;
            pnlBody.RectColor = Color.FromArgb(243, 244, 246);
            pnlBody.Size = new Size(920, 765);
            pnlBody.Style = Sunny.UI.UIStyle.Custom;
            pnlBody.TabIndex = 1;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlBody);
            Controls.Add(panelSidebar);
            Name = "FormAdmin";
            Text = "Hệ thống Quản lý EduGenAI - Admin";
            WindowState = FormWindowState.Maximized;
            ZoomScaleRect = new Rectangle(19, 19, 1200, 800);
            FormClosing += FormAdmin_FormClosing;
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
        private Sunny.UI.UIButton btnManageAccount;
        private Sunny.UI.UIButton btnManageExamBank;
        private Sunny.UI.UIButton btnConfigAI;
        private Sunny.UI.UIPanel pnlUser;
        private Sunny.UI.UILabel lblSidebarName;
        private Sunny.UI.UILabel lblSidebarRole;
        private Sunny.UI.UIAvatar avtUser;
    }
}