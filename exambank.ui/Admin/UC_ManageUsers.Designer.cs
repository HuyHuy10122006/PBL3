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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlHeader = new Sunny.UI.UIPanel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            cbSubject = new Sunny.UI.UIComboBox();
            txtSearch = new Sunny.UI.UITextBox();
            pnlBody = new Sunny.UI.UIPanel();
            pnlDgv = new Sunny.UI.UIPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            colMaGV = new DataGridViewTextBoxColumn();
            colTenGV = new DataGridViewTextBoxColumn();
            colTT = new DataGridViewTextBoxColumn();
            colXem = new DataGridViewImageColumn();
            uiPanel2 = new Sunny.UI.UIPanel();
            btnRefresh = new Sunny.UI.UISymbolButton();
            pnlUser = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            btnSave = new Sunny.UI.UISymbolButton();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            uiPanel2.SuspendLayout();
            pnlUser.SuspendLayout();
            uiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(uiLabel2);
            pnlHeader.Controls.Add(uiLabel1);
            pnlHeader.Controls.Add(cbSubject);
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
            pnlHeader.Size = new Size(1224, 120);
            pnlHeader.TabIndex = 6;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("Times New Roman", 12F);
            uiLabel2.ForeColor = Color.WhiteSmoke;
            uiLabel2.Location = new Point(323, 26);
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
            // cbSubject
            // 
            cbSubject.DataSource = null;
            cbSubject.FillColor = Color.White;
            cbSubject.FillColor2 = Color.FromArgb(24, 24, 24);
            cbSubject.Font = new Font("Microsoft Sans Serif", 12F);
            cbSubject.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbSubject.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbSubject.Location = new Point(323, 60);
            cbSubject.Margin = new Padding(4, 5, 4, 5);
            cbSubject.MinimumSize = new Size(63, 0);
            cbSubject.Name = "cbSubject";
            cbSubject.Padding = new Padding(0, 0, 30, 2);
            cbSubject.Radius = 10;
            cbSubject.RectColor = Color.Black;
            cbSubject.Size = new Size(194, 35);
            cbSubject.Style = Sunny.UI.UIStyle.Custom;
            cbSubject.SymbolSize = 24;
            cbSubject.TabIndex = 1;
            cbSubject.TextAlignment = ContentAlignment.MiddleLeft;
            cbSubject.Watermark = "Chọn trạng thái";
            // 
            // txtSearch
            // 
            txtSearch.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtSearch.ButtonStyleInherited = false;
            txtSearch.FillColor2 = Color.FromArgb(24, 24, 24);
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtSearch.Watermark = "Nhập tên, usename...";
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
            pnlBody.RectColor = Color.Black;
            pnlBody.Size = new Size(825, 421);
            pnlBody.TabIndex = 8;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlDgv
            // 
            pnlDgv.BackColor = Color.Transparent;
            pnlDgv.Controls.Add(uiDataGridView1);
            pnlDgv.Dock = DockStyle.Fill;
            pnlDgv.FillColor = Color.Transparent;
            pnlDgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDgv.Location = new Point(0, 41);
            pnlDgv.Margin = new Padding(4, 5, 4, 5);
            pnlDgv.MinimumSize = new Size(1, 1);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Radius = 1;
            pnlDgv.Size = new Size(825, 380);
            pnlDgv.TabIndex = 4;
            pnlDgv.Text = null;
            pnlDgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaGV, colTenGV, colTT, colXem });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.Black;
            uiDataGridView1.Location = new Point(0, 0);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RectColor = Color.Black;
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersVisible = false;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.ScrollBarColor = Color.Black;
            uiDataGridView1.ScrollBarRectColor = Color.Black;
            uiDataGridView1.ScrollBarStyleInherited = false;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(825, 380);
            uiDataGridView1.StripeOddColor = Color.White;
            uiDataGridView1.TabIndex = 1;
            // 
            // colMaGV
            // 
            colMaGV.DataPropertyName = "MaGV";
            colMaGV.HeaderText = "Mã GV";
            colMaGV.MinimumWidth = 6;
            colMaGV.Name = "colMaGV";
            colMaGV.ReadOnly = true;
            colMaGV.Width = 80;
            // 
            // colTenGV
            // 
            colTenGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenGV.DataPropertyName = "TenGV";
            colTenGV.HeaderText = "Tên giáo viên";
            colTenGV.MinimumWidth = 200;
            colTenGV.Name = "colTenGV";
            // 
            // colTT
            // 
            colTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colTT.DataPropertyName = "TT";
            colTT.HeaderText = "Trạng thái";
            colTT.MinimumWidth = 6;
            colTT.Name = "colTT";
            colTT.Width = 125;
            // 
            // colXem
            // 
            colXem.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colXem.DataPropertyName = "Xem";
            colXem.HeaderText = "Xem chi tiết";
            colXem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colXem.MinimumWidth = 6;
            colXem.Name = "colXem";
            colXem.Width = 116;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(btnRefresh);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.FillColor = Color.FromArgb(0, 192, 0);
            uiPanel2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.Size = new Size(825, 41);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = "Danh sách tài khoản";
            uiPanel2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FillColor = Color.DarkSeaGreen;
            btnRefresh.FillColor2 = Color.Transparent;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(701, 4);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Radius = 10;
            btnRefresh.RectColor = Color.Black;
            btnRefresh.Size = new Size(121, 34);
            btnRefresh.Symbol = 61473;
            btnRefresh.SymbolColor = Color.Black;
            btnRefresh.SymbolSize = 22;
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.Transparent;
            pnlUser.Controls.Add(uiPanel1);
            pnlUser.Controls.Add(uiPanel3);
            pnlUser.Dock = DockStyle.Right;
            pnlUser.FillColor = Color.White;
            pnlUser.Font = new Font("Microsoft Sans Serif", 12F);
            pnlUser.Location = new Point(825, 120);
            pnlUser.Margin = new Padding(4, 5, 4, 5);
            pnlUser.MinimumSize = new Size(1, 1);
            pnlUser.Name = "pnlUser";
            pnlUser.Radius = 10;
            pnlUser.Size = new Size(399, 421);
            pnlUser.TabIndex = 9;
            pnlUser.Text = null;
            pnlUser.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.FillColor = Color.FromArgb(0, 192, 0);
            uiPanel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            uiPanel1.RectColor = Color.Transparent;
            uiPanel1.Size = new Size(399, 41);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = "Chi tiết tài khoản";
            uiPanel1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiPanel3
            // 
            uiPanel3.BackColor = Color.Transparent;
            uiPanel3.Controls.Add(btnSave);
            uiPanel3.Dock = DockStyle.Bottom;
            uiPanel3.FillColor = Color.WhiteSmoke;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(0, 352);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = Color.Gainsboro;
            uiPanel3.Size = new Size(399, 69);
            uiPanel3.TabIndex = 3;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FillColor = Color.FromArgb(230, 80, 80);
            btnSave.FillColor2 = Color.FromArgb(230, 80, 80);
            btnSave.FillHoverColor = Color.FromArgb(235, 115, 115);
            btnSave.FillPressColor = Color.FromArgb(184, 64, 64);
            btnSave.FillSelectedColor = Color.FromArgb(184, 64, 64);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.LightColor = Color.FromArgb(253, 243, 243);
            btnSave.Location = new Point(268, 17);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(230, 80, 80);
            btnSave.RectHoverColor = Color.FromArgb(235, 115, 115);
            btnSave.RectPressColor = Color.FromArgb(184, 64, 64);
            btnSave.RectSelectedColor = Color.FromArgb(184, 64, 64);
            btnSave.Size = new Size(119, 40);
            btnSave.Style = Sunny.UI.UIStyle.Custom;
            btnSave.Symbol = 0;
            btnSave.SymbolSize = 22;
            btnSave.TabIndex = 12;
            btnSave.Text = "Khóa";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // UC_ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBody);
            Controls.Add(pnlUser);
            Controls.Add(pnlHeader);
            Name = "UC_ManageUsers";
            Size = new Size(1224, 541);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            uiPanel2.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbSubject;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UIPanel pnlDgv;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UIPanel pnlUser;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UISymbolButton btnSave;
        private DataGridViewTextBoxColumn colMaGV;
        private DataGridViewTextBoxColumn colTenGV;
        private DataGridViewTextBoxColumn colTT;
        private DataGridViewImageColumn colXem;
    }
}
