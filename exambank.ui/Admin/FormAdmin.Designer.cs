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
            this.panelSidebar = new Sunny.UI.UIPanel();
            this.btnConfigAI = new Sunny.UI.UIButton();
            this.btnManageExamBank = new Sunny.UI.UIButton();
            this.btnManageAccount = new Sunny.UI.UIButton();
            this.btnHome = new Sunny.UI.UIButton();
            this.pnlSpacer = new Sunny.UI.UIPanel();
            this.lblLogo = new Sunny.UI.UILabel();
            this.pnlUser = new Sunny.UI.UIPanel();
            this.lblSidebarRole = new Sunny.UI.UILabel();
            this.lblSidebarName = new Sunny.UI.UILabel();
            this.avtUser = new Sunny.UI.UIAvatar();
            this.pnlBody = new Sunny.UI.UIPanel();
            this.panelSidebar.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelSidebar.Controls.Add(this.btnConfigAI);
            this.panelSidebar.Controls.Add(this.btnManageExamBank);
            this.panelSidebar.Controls.Add(this.btnManageAccount);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.pnlSpacer);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Controls.Add(this.pnlUser);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelSidebar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelSidebar.Location = new System.Drawing.Point(0, 35);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Radius = 0;
            this.panelSidebar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelSidebar.Size = new System.Drawing.Size(280, 765);
            this.panelSidebar.Style = Sunny.UI.UIStyle.Custom;
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Text = null;
            // 
            // btnConfigAI
            // 
            this.btnConfigAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigAI.FillColor = System.Drawing.Color.Transparent;
            this.btnConfigAI.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnConfigAI.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnConfigAI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfigAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnConfigAI.ForeHoverColor = System.Drawing.Color.White;
            this.btnConfigAI.Location = new System.Drawing.Point(0, 315);
            this.btnConfigAI.Name = "btnConfigAI";
            this.btnConfigAI.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfigAI.Radius = 0;
            this.btnConfigAI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnConfigAI.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnConfigAI.Size = new System.Drawing.Size(280, 65);
            this.btnConfigAI.Style = Sunny.UI.UIStyle.Custom;
            this.btnConfigAI.TabIndex = 5;
            this.btnConfigAI.Text = "Cấu hình tham số AI";
            this.btnConfigAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigAI.Click += new System.EventHandler(this.btnConfigAI_Click);
            // 
            // btnManageExamBank
            // 
            this.btnManageExamBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageExamBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageExamBank.FillColor = System.Drawing.Color.Transparent;
            this.btnManageExamBank.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnManageExamBank.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnManageExamBank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageExamBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnManageExamBank.ForeHoverColor = System.Drawing.Color.White;
            this.btnManageExamBank.Location = new System.Drawing.Point(0, 250);
            this.btnManageExamBank.Name = "btnManageExamBank";
            this.btnManageExamBank.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageExamBank.Radius = 0;
            this.btnManageExamBank.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnManageExamBank.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnManageExamBank.Size = new System.Drawing.Size(280, 65);
            this.btnManageExamBank.Style = Sunny.UI.UIStyle.Custom;
            this.btnManageExamBank.TabIndex = 4;
            this.btnManageExamBank.Text = "Quản lý ngân hàng đề thi";
            this.btnManageExamBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageExamBank.Click += new System.EventHandler(this.btnManageExamBank_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnManageAccount.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnManageAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnManageAccount.ForeHoverColor = System.Drawing.Color.White;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 185);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageAccount.Radius = 0;
            this.btnManageAccount.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnManageAccount.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnManageAccount.Size = new System.Drawing.Size(280, 65);
            this.btnManageAccount.Style = Sunny.UI.UIStyle.Custom;
            this.btnManageAccount.TabIndex = 3;
            this.btnManageAccount.Text = "Quản lý tài khoản";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnHome.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnHome.ForeHoverColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Radius = 0;
            this.btnHome.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnHome.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnHome.Size = new System.Drawing.Size(280, 65);
            this.btnHome.Style = Sunny.UI.UIStyle.Custom;
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSpacer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlSpacer.Location = new System.Drawing.Point(0, 100);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Radius = 0;
            this.pnlSpacer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSpacer.Size = new System.Drawing.Size(280, 20);
            this.pnlSpacer.Style = Sunny.UI.UIStyle.Custom;
            this.pnlSpacer.TabIndex = 7;
            this.pnlSpacer.Text = null;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(280, 100);
            this.lblLogo.Style = Sunny.UI.UIStyle.Custom;
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EduGenAI";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlUser.Controls.Add(this.lblSidebarRole);
            this.pnlUser.Controls.Add(this.lblSidebarName);
            this.pnlUser.Controls.Add(this.avtUser);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlUser.Location = new System.Drawing.Point(0, 665);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Radius = 0;
            this.pnlUser.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlUser.Size = new System.Drawing.Size(280, 100);
            this.pnlUser.Style = Sunny.UI.UIStyle.Custom;
            this.pnlUser.TabIndex = 6;
            this.pnlUser.Text = null;
            // 
            // lblSidebarRole
            // 
            this.lblSidebarRole.BackColor = System.Drawing.Color.Transparent;
            this.lblSidebarRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSidebarRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSidebarRole.Location = new System.Drawing.Point(90, 52);
            this.lblSidebarRole.Name = "lblSidebarRole";
            this.lblSidebarRole.Size = new System.Drawing.Size(160, 23);
            this.lblSidebarRole.Style = Sunny.UI.UIStyle.Custom;
            this.lblSidebarRole.TabIndex = 8;
            this.lblSidebarRole.Text = "Quản trị viên";
            this.lblSidebarRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSidebarName
            // 
            this.lblSidebarName.BackColor = System.Drawing.Color.Transparent;
            this.lblSidebarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSidebarName.ForeColor = System.Drawing.Color.White;
            this.lblSidebarName.Location = new System.Drawing.Point(90, 25);
            this.lblSidebarName.Name = "lblSidebarName";
            this.lblSidebarName.Size = new System.Drawing.Size(180, 28);
            this.lblSidebarName.Style = Sunny.UI.UIStyle.Custom;
            this.lblSidebarName.TabIndex = 7;
            this.lblSidebarName.Text = "Hoàng Hưng";
            this.lblSidebarName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avtUser
            // 
            this.avtUser.BackColor = System.Drawing.Color.Transparent;
            this.avtUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))); // Nền Avatar đỏ tươi cho Admin
            this.avtUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.avtUser.Location = new System.Drawing.Point(20, 20);
            this.avtUser.Name = "avtUser";
            this.avtUser.Size = new System.Drawing.Size(60, 60);
            this.avtUser.TabIndex = 6;
            this.avtUser.Text = "AD";
            this.avtUser.Click += new System.EventHandler(this.avtUser_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlBody.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlBody.Location = new System.Drawing.Point(280, 35);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Radius = 0;
            this.pnlBody.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlBody.Size = new System.Drawing.Size(920, 765);
            this.pnlBody.Style = Sunny.UI.UIStyle.Custom;
            this.pnlBody.TabIndex = 1;
            this.pnlBody.Text = null;
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panelSidebar);
            this.Name = "FormAdmin";
            this.Text = "Hệ thống Quản lý EduGenAI - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.ResumeLayout(false);

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