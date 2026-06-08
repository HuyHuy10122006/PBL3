namespace exambank.ui.Common
{
    partial class UC_ProfileSettings
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            uiPanelHeader = new Sunny.UI.UIPanel();
            btnEditProfile = new Sunny.UI.UIButton();
            btnLogout = new Sunny.UI.UIButton();
            btnChangePassword = new Sunny.UI.UIButton();
            lblRole = new Sunny.UI.UILabel();
            lblFullName = new Sunny.UI.UILabel();
            avtProfile = new Sunny.UI.UIAvatar();
            uiPanelContact = new Sunny.UI.UIPanel();
            lblUniversity = new Sunny.UI.UILabel();
            lblPhone = new Sunny.UI.UILabel();
            lblEmail = new Sunny.UI.UILabel();
            uiLineContact = new Sunny.UI.UILine();
            uiPanelExpertise = new Sunny.UI.UIPanel();
            lblAccountStatus = new Sunny.UI.UILabel();
            lblAiDifficulty = new Sunny.UI.UILabel();
            lblSubjects = new Sunny.UI.UILabel();
            uiLineExpertise = new Sunny.UI.UILine();
            tlpMain.SuspendLayout();
            uiPanelHeader.SuspendLayout();
            uiPanelContact.SuspendLayout();
            uiPanelExpertise.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(243, 244, 246);
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(uiPanelHeader, 0, 0);
            tlpMain.Controls.Add(uiPanelContact, 0, 1);
            tlpMain.Controls.Add(uiPanelExpertise, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(3, 2, 3, 2);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(951, 525);
            tlpMain.TabIndex = 0;
            // 
            // uiPanelHeader
            // 
            tlpMain.SetColumnSpan(uiPanelHeader, 2);
            uiPanelHeader.Controls.Add(btnEditProfile);
            uiPanelHeader.Controls.Add(btnLogout);
            uiPanelHeader.Controls.Add(btnChangePassword);
            uiPanelHeader.Controls.Add(lblRole);
            uiPanelHeader.Controls.Add(lblFullName);
            uiPanelHeader.Controls.Add(avtProfile);
            uiPanelHeader.Dock = DockStyle.Fill;
            uiPanelHeader.FillColor = Color.White;
            uiPanelHeader.Font = new Font("Segoe UI", 12F);
            uiPanelHeader.Location = new Point(18, 15);
            uiPanelHeader.Margin = new Padding(18, 15, 18, 8);
            uiPanelHeader.MinimumSize = new Size(1, 1);
            uiPanelHeader.Name = "uiPanelHeader";
            uiPanelHeader.Radius = 15;
            uiPanelHeader.Size = new Size(915, 89);
            uiPanelHeader.TabIndex = 0;
            uiPanelHeader.Text = null;
            uiPanelHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProfile.Cursor = Cursors.Hand;
            btnEditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditProfile.Location = new Point(440, 25);
            btnEditProfile.MinimumSize = new Size(1, 1);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Radius = 8;
            btnEditProfile.Size = new Size(150, 45);
            btnEditProfile.TabIndex = 5;
            btnEditProfile.Text = "Sửa thông tin";
            btnEditProfile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FillColor = Color.FromArgb(231, 76, 60);
            btnLogout.FillHoverColor = Color.FromArgb(192, 57, 43);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.Location = new Point(782, 25);
            btnLogout.MinimumSize = new Size(1, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Radius = 8;
            btnLogout.Size = new Size(130, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogout.Click += btnLogout_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangePassword.Location = new Point(605, 25);
            btnChangePassword.MinimumSize = new Size(1, 1);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Radius = 8;
            btnChangePassword.Size = new Size(150, 45);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblRole
            // 
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 12F);
            lblRole.ForeColor = Color.Gray;
            lblRole.Location = new Point(123, 65);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(300, 30);
            lblRole.Style = Sunny.UI.UIStyle.Custom;
            lblRole.TabIndex = 2;
            lblRole.Text = "Vai trò: Giáo viên";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(48, 48, 48);
            lblFullName.Location = new Point(120, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(400, 35);
            lblFullName.Style = Sunny.UI.UIStyle.Custom;
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên";
            // 
            // avtProfile
            // 
            avtProfile.Font = new Font("Segoe UI", 12F);
            avtProfile.Location = new Point(20, 6);
            avtProfile.MinimumSize = new Size(1, 1);
            avtProfile.Name = "avtProfile";
            avtProfile.Size = new Size(80, 80);
            avtProfile.TabIndex = 0;
            avtProfile.Text = "User";
            // 
            // uiPanelContact
            // 
            uiPanelContact.Controls.Add(lblUniversity);
            uiPanelContact.Controls.Add(lblPhone);
            uiPanelContact.Controls.Add(lblEmail);
            uiPanelContact.Controls.Add(uiLineContact);
            uiPanelContact.Dock = DockStyle.Fill;
            uiPanelContact.FillColor = Color.White;
            uiPanelContact.Font = new Font("Segoe UI", 12F);
            uiPanelContact.Location = new Point(18, 120);
            uiPanelContact.Margin = new Padding(18, 8, 9, 15);
            uiPanelContact.MinimumSize = new Size(1, 1);
            uiPanelContact.Name = "uiPanelContact";
            uiPanelContact.Radius = 15;
            uiPanelContact.Size = new Size(448, 390);
            uiPanelContact.TabIndex = 1;
            uiPanelContact.Text = null;
            uiPanelContact.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblUniversity
            // 
            lblUniversity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUniversity.BackColor = Color.Transparent;
            lblUniversity.Font = new Font("Segoe UI", 12F);
            lblUniversity.ForeColor = Color.FromArgb(48, 48, 48);
            lblUniversity.Location = new Point(30, 200);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(447, 30);
            lblUniversity.Style = Sunny.UI.UIStyle.Custom;
            lblUniversity.TabIndex = 3;
            lblUniversity.Text = "🏫 Đơn vị: ĐH Bách Khoa - DUT";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 12F);
            lblPhone.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhone.Location = new Point(30, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(447, 30);
            lblPhone.Style = Sunny.UI.UIStyle.Custom;
            lblPhone.TabIndex = 2;
            lblPhone.Text = "📞 Điện thoại: Chưa cập nhật";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(30, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(447, 30);
            lblEmail.Style = Sunny.UI.UIStyle.Custom;
            lblEmail.TabIndex = 1;
            lblEmail.Text = "📧 Email: ";
            // 
            // uiLineContact
            // 
            uiLineContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiLineContact.BackColor = Color.Transparent;
            uiLineContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            uiLineContact.ForeColor = Color.FromArgb(80, 160, 255);
            uiLineContact.Location = new Point(20, 20);
            uiLineContact.MinimumSize = new Size(1, 1);
            uiLineContact.Name = "uiLineContact";
            uiLineContact.Size = new Size(467, 30);
            uiLineContact.Style = Sunny.UI.UIStyle.Custom;
            uiLineContact.TabIndex = 0;
            uiLineContact.Text = "Thông tin liên hệ";
            // 
            // uiPanelExpertise
            // 
            uiPanelExpertise.Controls.Add(lblAccountStatus);
            uiPanelExpertise.Controls.Add(lblAiDifficulty);
            uiPanelExpertise.Controls.Add(lblSubjects);
            uiPanelExpertise.Controls.Add(uiLineExpertise);
            uiPanelExpertise.Dock = DockStyle.Fill;
            uiPanelExpertise.FillColor = Color.White;
            uiPanelExpertise.Font = new Font("Segoe UI", 12F);
            uiPanelExpertise.Location = new Point(484, 120);
            uiPanelExpertise.Margin = new Padding(9, 8, 18, 15);
            uiPanelExpertise.MinimumSize = new Size(1, 1);
            uiPanelExpertise.Name = "uiPanelExpertise";
            uiPanelExpertise.Radius = 15;
            uiPanelExpertise.Size = new Size(449, 390);
            uiPanelExpertise.TabIndex = 2;
            uiPanelExpertise.Text = null;
            uiPanelExpertise.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAccountStatus.BackColor = Color.Transparent;
            lblAccountStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccountStatus.ForeColor = Color.MediumSeaGreen;
            lblAccountStatus.Location = new Point(30, 200);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(448, 30);
            lblAccountStatus.Style = Sunny.UI.UIStyle.Custom;
            lblAccountStatus.TabIndex = 3;
            lblAccountStatus.Text = "\U0001f7e2 Trạng thái: Đang hoạt động";
            // 
            // lblAiDifficulty
            // 
            lblAiDifficulty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAiDifficulty.BackColor = Color.Transparent;
            lblAiDifficulty.Font = new Font("Segoe UI", 12F);
            lblAiDifficulty.ForeColor = Color.FromArgb(48, 48, 48);
            lblAiDifficulty.Location = new Point(30, 140);
            lblAiDifficulty.Name = "lblAiDifficulty";
            lblAiDifficulty.Size = new Size(448, 30);
            lblAiDifficulty.Style = Sunny.UI.UIStyle.Custom;
            lblAiDifficulty.TabIndex = 2;
            lblAiDifficulty.Text = "⚙️ Mức độ AI ưu tiên: Vận dụng";
            // 
            // lblSubjects
            // 
            lblSubjects.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubjects.BackColor = Color.Transparent;
            lblSubjects.Font = new Font("Segoe UI", 12F);
            lblSubjects.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubjects.Location = new Point(30, 80);
            lblSubjects.Name = "lblSubjects";
            lblSubjects.Size = new Size(448, 30);
            lblSubjects.Style = Sunny.UI.UIStyle.Custom;
            lblSubjects.TabIndex = 1;
            lblSubjects.Text = "📚 Bộ môn: Công nghệ thông tin";
            // 
            // uiLineExpertise
            // 
            uiLineExpertise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiLineExpertise.BackColor = Color.Transparent;
            uiLineExpertise.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            uiLineExpertise.ForeColor = Color.FromArgb(80, 160, 255);
            uiLineExpertise.Location = new Point(20, 20);
            uiLineExpertise.MinimumSize = new Size(1, 1);
            uiLineExpertise.Name = "uiLineExpertise";
            uiLineExpertise.Size = new Size(468, 30);
            uiLineExpertise.Style = Sunny.UI.UIStyle.Custom;
            uiLineExpertise.TabIndex = 0;
            uiLineExpertise.Text = "Chuyên môn & Hệ thống AI";
            // 
            // UC_ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tlpMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_ProfileSettings";
            Size = new Size(951, 525);
            tlpMain.ResumeLayout(false);
            uiPanelHeader.ResumeLayout(false);
            uiPanelContact.ResumeLayout(false);
            uiPanelExpertise.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Sunny.UI.UIPanel uiPanelHeader;
        private Sunny.UI.UIButton btnEditProfile;
        private Sunny.UI.UIButton btnLogout;
        private Sunny.UI.UIButton btnChangePassword;
        private Sunny.UI.UILabel lblRole;
        private Sunny.UI.UILabel lblFullName;
        private Sunny.UI.UIAvatar avtProfile;
        private Sunny.UI.UIPanel uiPanelContact;
        private Sunny.UI.UILabel lblUniversity;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILine uiLineContact;
        private Sunny.UI.UIPanel uiPanelExpertise;
        private Sunny.UI.UILabel lblAccountStatus;
        private Sunny.UI.UILabel lblAiDifficulty;
        private Sunny.UI.UILabel lblSubjects;
        private Sunny.UI.UILine uiLineExpertise;
    }
}