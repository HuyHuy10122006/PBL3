namespace exambank.ui
{
    partial class UC_ManageUsers
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Sunny.UI.UIPanel();
            uiLabel3 = new Sunny.UI.UILabel();
            cbRole = new Sunny.UI.UIComboBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            cbTT = new Sunny.UI.UIComboBox();
            txtSearch = new Sunny.UI.UITextBox();
            pnlBody = new Sunny.UI.UIPanel();
            pnlDgv = new Sunny.UI.UIPanel();
            dgvUsers = new Sunny.UI.UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSTT = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewImageColumn();
            uiPanel2 = new Sunny.UI.UIPanel();
            btnRefresh = new Sunny.UI.UISymbolButton();
            cmsActions = new Sunny.UI.UIContextMenuStrip(components);
            miLock = new ToolStripMenuItem();
            miUnlock = new ToolStripMenuItem();
            sSuperAdmin = new ToolStripSeparator();
            miGgantAdminRole = new ToolStripMenuItem();
            miRevokeAdminRole = new ToolStripMenuItem();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            uiPanel2.SuspendLayout();
            cmsActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(uiLabel3);
            pnlHeader.Controls.Add(cbRole);
            pnlHeader.Controls.Add(uiLabel2);
            pnlHeader.Controls.Add(uiLabel1);
            pnlHeader.Controls.Add(cbTT);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.MidnightBlue;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 15;
            pnlHeader.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            pnlHeader.RectColor = Color.Gray;
            pnlHeader.Size = new Size(1224, 120);
            pnlHeader.TabIndex = 6;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("Times New Roman", 12F);
            uiLabel3.ForeColor = Color.WhiteSmoke;
            uiLabel3.Location = new Point(562, 26);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(164, 29);
            uiLabel3.TabIndex = 8;
            uiLabel3.Text = "Vai trò:";
            // 
            // cbRole
            // 
            cbRole.DataSource = null;
            cbRole.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbRole.FillColor = Color.White;
            cbRole.FillColor2 = Color.FromArgb(24, 24, 24);
            cbRole.Font = new Font("Times New Roman", 12F);
            cbRole.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbRole.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbRole.Location = new Point(562, 60);
            cbRole.Margin = new Padding(4, 5, 4, 5);
            cbRole.MinimumSize = new Size(63, 0);
            cbRole.Name = "cbRole";
            cbRole.Padding = new Padding(0, 0, 30, 2);
            cbRole.Radius = 10;
            cbRole.RectColor = Color.Black;
            cbRole.Size = new Size(149, 35);
            cbRole.Style = Sunny.UI.UIStyle.Custom;
            cbRole.SymbolSize = 24;
            cbRole.TabIndex = 7;
            cbRole.TextAlignment = ContentAlignment.MiddleLeft;
            cbRole.Watermark = "Chọn vai trò";
            cbRole.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("Times New Roman", 12F);
            uiLabel2.ForeColor = Color.WhiteSmoke;
            uiLabel2.Location = new Point(334, 26);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(164, 29);
            uiLabel2.TabIndex = 6;
            uiLabel2.Text = "Trạng thái:";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.WhiteSmoke;
            uiLabel1.Location = new Point(18, 26);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(282, 29);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "TÌM KIẾM TÀI KHOẢN";
            // 
            // cbTT
            // 
            cbTT.DataSource = null;
            cbTT.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbTT.FillColor = Color.White;
            cbTT.FillColor2 = Color.FromArgb(24, 24, 24);
            cbTT.Font = new Font("Times New Roman", 12F);
            cbTT.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbTT.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbTT.Location = new Point(334, 60);
            cbTT.Margin = new Padding(4, 5, 4, 5);
            cbTT.MinimumSize = new Size(63, 0);
            cbTT.Name = "cbTT";
            cbTT.Padding = new Padding(0, 0, 30, 2);
            cbTT.Radius = 10;
            cbTT.RectColor = Color.Black;
            cbTT.Size = new Size(182, 35);
            cbTT.Style = Sunny.UI.UIStyle.Custom;
            cbTT.SymbolSize = 24;
            cbTT.TabIndex = 1;
            cbTT.TextAlignment = ContentAlignment.MiddleLeft;
            cbTT.Watermark = "Chọn trạng thái";
            cbTT.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtSearch.ButtonStyleInherited = false;
            txtSearch.FillColor2 = Color.FromArgb(24, 24, 24);
            txtSearch.Font = new Font("Times New Roman", 12F);
            txtSearch.Location = new Point(18, 60);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Black;
            txtSearch.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtSearch.ScrollBarStyleInherited = false;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(282, 35);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolSize = 23;
            txtSearch.TabIndex = 1;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập tên, usename, email...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlDgv);
            pnlBody.Controls.Add(uiPanel2);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBody.Location = new Point(0, 120);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.RectColor = Color.Gray;
            pnlBody.Size = new Size(1224, 421);
            pnlBody.TabIndex = 8;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlDgv
            // 
            pnlDgv.BackColor = Color.Transparent;
            pnlDgv.Controls.Add(dgvUsers);
            pnlDgv.Dock = DockStyle.Fill;
            pnlDgv.FillColor = Color.Transparent;
            pnlDgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDgv.Location = new Point(0, 41);
            pnlDgv.Margin = new Padding(4, 5, 4, 5);
            pnlDgv.MinimumSize = new Size(1, 1);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Radius = 1;
            pnlDgv.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlDgv.Size = new Size(1224, 380);
            pnlDgv.TabIndex = 4;
            pnlDgv.Text = null;
            pnlDgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 32;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colID, colSTT, colFullName, colUsername, colEmail, colStatus, colRole, colActions });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle7;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Font = new Font("Microsoft Sans Serif", 12F);
            dgvUsers.GridColor = Color.Gray;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RectColor = Color.Transparent;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvUsers.RowTemplate.Height = 33;
            dgvUsers.ScrollBarColor = Color.DimGray;
            dgvUsers.ScrollBarRectColor = Color.DimGray;
            dgvUsers.ScrollBarStyleInherited = false;
            dgvUsers.SelectedIndex = -1;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1224, 380);
            dgvUsers.StripeOddColor = Color.WhiteSmoke;
            dgvUsers.TabIndex = 1;
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            dgvUsers.CellMouseDown += dgvUsers_CellMouseDown;
            dgvUsers.DataBindingComplete += dgvUsers_DataBindingComplete;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colID.DataPropertyName = "Id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colSTT
            // 
            colSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colSTT.DataPropertyName = "STT";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT.DefaultCellStyle = dataGridViewCellStyle3;
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 75;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ tên";
            colFullName.MinimumWidth = 200;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 123;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 86;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colStatus.DataPropertyName = "Status";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle4;
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // colRole
            // 
            colRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colRole.DataPropertyName = "Role";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colRole.DefaultCellStyle = dataGridViewCellStyle5;
            colRole.HeaderText = "Vai trò";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 95;
            // 
            // colActions
            // 
            colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colActions.DataPropertyName = "Actions";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.NullValue = null;
            colActions.DefaultCellStyle = dataGridViewCellStyle6;
            colActions.HeaderText = "Thao tác";
            colActions.Image = Properties.Resources.more_vert_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Resizable = DataGridViewTriState.True;
            colActions.Width = 89;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(btnRefresh);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.FillColor = Color.FromArgb(45, 80, 135);
            uiPanel2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiPanel2.ForeColor = Color.Gainsboro;
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel2.Size = new Size(1224, 41);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = "Danh sách tài khoản";
            uiPanel2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FillColor = Color.SteelBlue;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1100, 4);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Radius = 10;
            btnRefresh.RectColor = Color.Black;
            btnRefresh.Size = new Size(121, 34);
            btnRefresh.Style = Sunny.UI.UIStyle.Custom;
            btnRefresh.Symbol = 61473;
            btnRefresh.SymbolColor = Color.Black;
            btnRefresh.SymbolSize = 22;
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmsActions
            // 
            cmsActions.BackColor = Color.FromArgb(243, 249, 255);
            cmsActions.Font = new Font("Microsoft Sans Serif", 12F);
            cmsActions.ImageScalingSize = new Size(20, 20);
            cmsActions.Items.AddRange(new ToolStripItem[] { miLock, miUnlock, sSuperAdmin, miGgantAdminRole, miRevokeAdminRole });
            cmsActions.Name = "cmsActions";
            cmsActions.Size = new Size(215, 158);
            cmsActions.Opening += cmsActions_Opening;
            // 
            // miLock
            // 
            miLock.Font = new Font("Times New Roman", 13.2000008F);
            miLock.ForeColor = Color.Red;
            miLock.Image = Properties.Resources.lock_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            miLock.Name = "miLock";
            miLock.Size = new Size(214, 30);
            miLock.Text = "Khóa";
            miLock.Click += miLock_Click;
            // 
            // miUnlock
            // 
            miUnlock.Font = new Font("Times New Roman", 13.2000008F);
            miUnlock.ForeColor = Color.FromArgb(0, 192, 0);
            miUnlock.Image = Properties.Resources.lock_open_right_24dp_36D00B_FILL0_wght400_GRAD0_opsz24;
            miUnlock.Name = "miUnlock";
            miUnlock.Size = new Size(214, 30);
            miUnlock.Text = "Mở khóa";
            miUnlock.Click += miUnlock_Click;
            // 
            // sSuperAdmin
            // 
            sSuperAdmin.Name = "sSuperAdmin";
            sSuperAdmin.Size = new Size(211, 6);
            // 
            // miGgantAdminRole
            // 
            miGgantAdminRole.Font = new Font("Times New Roman", 13.2000008F);
            miGgantAdminRole.ForeColor = Color.FromArgb(0, 192, 0);
            miGgantAdminRole.Image = Properties.Resources.arrow_upward_24dp_36D00B_FILL0_wght400_GRAD0_opsz24;
            miGgantAdminRole.Name = "miGgantAdminRole";
            miGgantAdminRole.Size = new Size(214, 30);
            miGgantAdminRole.Text = "Nâng quyền";
            miGgantAdminRole.Click += miGgantAdminRole_Click;
            // 
            // miRevokeAdminRole
            // 
            miRevokeAdminRole.Font = new Font("Times New Roman", 13.2000008F);
            miRevokeAdminRole.ForeColor = Color.Red;
            miRevokeAdminRole.Image = Properties.Resources.arrow_downward_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            miRevokeAdminRole.Name = "miRevokeAdminRole";
            miRevokeAdminRole.Size = new Size(214, 30);
            miRevokeAdminRole.Text = "Hạ quyền";
            miRevokeAdminRole.Click += miRevokeAdminRole_Click;
            // 
            // UC_ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UC_ManageUsers";
            Size = new Size(1224, 541);
            Load += UC_ManageUsers_Load;
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            uiPanel2.ResumeLayout(false);
            cmsActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbTT;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UIPanel pnlDgv;
        private Sunny.UI.UIDataGridView dgvUsers;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox cbRole;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewImageColumn colActions;
        private Sunny.UI.UIContextMenuStrip cmsActions;
        private ToolStripMenuItem miLock;
        private ToolStripSeparator sLock;
        private ToolStripMenuItem miUnlock;
        private ToolStripSeparator sSuperAdmin;
        private ToolStripMenuItem miGgantAdminRole;
        private ToolStripSeparator sGgantAdminRole;
        private ToolStripMenuItem miRevokeAdminRole;
    }
}
