namespace exambank.ui
{
    partial class UC_ManageExams
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
            dgvExams = new Sunny.UI.UIDataGridView();
            colMaDe = new DataGridViewTextBoxColumn();
            colTenDe = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colSoCau = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            colShare = new DataGridViewImageColumn();
            colExport = new DataGridViewImageColumn();
            xem = new DataGridViewButtonColumn();
            pnlDgv = new Sunny.UI.UIPanel();
            pnlHeader = new Sunny.UI.UIPanel();
            txtSearch = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            cbGrade = new Sunny.UI.UIComboBox();
            cbSubject = new Sunny.UI.UIComboBox();
            pnlBody = new Sunny.UI.UIPanel();
            pnlHeaderTable = new Sunny.UI.UIPanel();
            btnRefresh = new Sunny.UI.UISymbolButton();
            pnlThaoTac = new Sunny.UI.UIPanel();
            btnSelectShare = new Sunny.UI.UISymbolButton();
            btnSelectDelete = new Sunny.UI.UISymbolButton();
            lblSelect = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            pnlDgv.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlHeaderTable.SuspendLayout();
            pnlThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.BackgroundColor = Color.White;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.ColumnHeadersHeight = 32;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { colMaDe, colTenDe, colMon, colSoCau, colThoiGian, colShare, colExport, xem });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle3;
            dgvExams.Dock = DockStyle.Fill;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.Font = new Font("Microsoft Sans Serif", 12F);
            dgvExams.GridColor = Color.Black;
            dgvExams.Location = new Point(0, 0);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RectColor = Color.Black;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvExams.RowHeadersVisible = false;
            dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvExams.ScrollBarColor = Color.Black;
            dgvExams.ScrollBarRectColor = Color.Black;
            dgvExams.ScrollBarStyleInherited = false;
            dgvExams.SelectedIndex = -1;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1213, 292);
            dgvExams.StripeOddColor = Color.White;
            dgvExams.TabIndex = 0;
            dgvExams.CellContentClick += dgvExams_CellClick;
            // 
            // colMaDe
            // 
            colMaDe.DataPropertyName = "MaDe";
            colMaDe.HeaderText = "Mã đề";
            colMaDe.MinimumWidth = 6;
            colMaDe.Name = "colMaDe";
            colMaDe.ReadOnly = true;
            colMaDe.Width = 80;
            // 
            // colTenDe
            // 
            colTenDe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenDe.DataPropertyName = "TenDe";
            colTenDe.HeaderText = "Tên đề thi";
            colTenDe.MinimumWidth = 200;
            colTenDe.Name = "colTenDe";
            colTenDe.ReadOnly = true;
            // 
            // colMon
            // 
            colMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMon.DataPropertyName = "Mon";
            colMon.HeaderText = "Môn học";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            colMon.Width = 110;
            // 
            // colSoCau
            // 
            colSoCau.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSoCau.DataPropertyName = "SoCau";
            colSoCau.HeaderText = "Số câu";
            colSoCau.MinimumWidth = 6;
            colSoCau.Name = "colSoCau";
            colSoCau.ReadOnly = true;
            colSoCau.Width = 93;
            // 
            // colThoiGian
            // 
            colThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colThoiGian.DataPropertyName = "ThoiGian";
            colThoiGian.HeaderText = "Thời gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            colThoiGian.Width = 117;
            // 
            // colShare
            // 
            colShare.DataPropertyName = "Share";
            colShare.HeaderText = "Chia sẻ";
            colShare.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colShare.MinimumWidth = 6;
            colShare.Name = "colShare";
            colShare.ReadOnly = true;
            colShare.Width = 85;
            // 
            // colExport
            // 
            colExport.DataPropertyName = "Export";
            colExport.HeaderText = "Xuất";
            colExport.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colExport.MinimumWidth = 6;
            colExport.Name = "colExport";
            colExport.ReadOnly = true;
            colExport.Width = 55;
            // 
            // xem
            // 
            xem.DataPropertyName = "xem";
            xem.HeaderText = "Xem";
            xem.MinimumWidth = 6;
            xem.Name = "xem";
            xem.ReadOnly = true;
            xem.Width = 60;
            // 
            // pnlDgv
            // 
            pnlDgv.BackColor = Color.Transparent;
            pnlDgv.Controls.Add(dgvExams);
            pnlDgv.Dock = DockStyle.Fill;
            pnlDgv.FillColor = Color.Transparent;
            pnlDgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDgv.Location = new Point(0, 41);
            pnlDgv.Margin = new Padding(4, 5, 4, 5);
            pnlDgv.MinimumSize = new Size(1, 1);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Radius = 1;
            pnlDgv.Size = new Size(1213, 292);
            pnlDgv.TabIndex = 4;
            pnlDgv.Text = null;
            pnlDgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(uiLabel3);
            pnlHeader.Controls.Add(uiLabel2);
            pnlHeader.Controls.Add(uiLabel1);
            pnlHeader.Controls.Add(cbGrade);
            pnlHeader.Controls.Add(cbSubject);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.MidnightBlue;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 15;
            pnlHeader.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            pnlHeader.Size = new Size(1213, 120);
            pnlHeader.TabIndex = 5;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.ButtonFillColor = Color.Gainsboro;
            txtSearch.ButtonForeColor = Color.Black;
            txtSearch.ButtonRectColor = Color.Gray;
            txtSearch.ButtonStyleInherited = false;
            txtSearch.ButtonSymbol = 61442;
            txtSearch.ButtonWidth = 45;
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
            txtSearch.ShowButton = true;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(297, 35);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.SymbolSize = 23;
            txtSearch.TabIndex = 12;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập tên đề, giáo viên...";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("Times New Roman", 12F);
            uiLabel3.ForeColor = Color.WhiteSmoke;
            uiLabel3.Location = new Point(529, 26);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(164, 29);
            uiLabel3.TabIndex = 7;
            uiLabel3.Text = "Khối:";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("Times New Roman", 12F);
            uiLabel2.ForeColor = Color.WhiteSmoke;
            uiLabel2.Location = new Point(342, 26);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(164, 29);
            uiLabel2.TabIndex = 6;
            uiLabel2.Text = "Môn học:";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.WhiteSmoke;
            uiLabel1.Location = new Point(18, 26);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(196, 29);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "TÌM KIẾM ĐỀ THI";
            // 
            // cbGrade
            // 
            cbGrade.DataSource = null;
            cbGrade.FillColor = Color.White;
            cbGrade.FillColor2 = Color.FromArgb(24, 24, 24);
            cbGrade.Font = new Font("Microsoft Sans Serif", 12F);
            cbGrade.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbGrade.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbGrade.Location = new Point(529, 60);
            cbGrade.Margin = new Padding(4, 5, 4, 5);
            cbGrade.MinimumSize = new Size(63, 0);
            cbGrade.Name = "cbGrade";
            cbGrade.Padding = new Padding(0, 0, 30, 2);
            cbGrade.Radius = 10;
            cbGrade.RectColor = Color.Black;
            cbGrade.Size = new Size(164, 35);
            cbGrade.Style = Sunny.UI.UIStyle.Custom;
            cbGrade.SymbolSize = 24;
            cbGrade.TabIndex = 2;
            cbGrade.TextAlignment = ContentAlignment.MiddleLeft;
            cbGrade.Watermark = "Chọn khối";
            // 
            // cbSubject
            // 
            cbSubject.DataSource = null;
            cbSubject.FillColor = Color.White;
            cbSubject.FillColor2 = Color.FromArgb(24, 24, 24);
            cbSubject.Font = new Font("Microsoft Sans Serif", 12F);
            cbSubject.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbSubject.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbSubject.Location = new Point(342, 60);
            cbSubject.Margin = new Padding(4, 5, 4, 5);
            cbSubject.MinimumSize = new Size(63, 0);
            cbSubject.Name = "cbSubject";
            cbSubject.Padding = new Padding(0, 0, 30, 2);
            cbSubject.Radius = 10;
            cbSubject.RectColor = Color.Black;
            cbSubject.Size = new Size(164, 35);
            cbSubject.Style = Sunny.UI.UIStyle.Custom;
            cbSubject.SymbolSize = 24;
            cbSubject.TabIndex = 1;
            cbSubject.TextAlignment = ContentAlignment.MiddleLeft;
            cbSubject.Watermark = "Chọn môn";
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlDgv);
            pnlBody.Controls.Add(pnlHeaderTable);
            pnlBody.Controls.Add(pnlThaoTac);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBody.Location = new Point(0, 120);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.RectColor = Color.Black;
            pnlBody.Size = new Size(1213, 402);
            pnlBody.TabIndex = 7;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderTable
            // 
            pnlHeaderTable.Controls.Add(btnRefresh);
            pnlHeaderTable.Dock = DockStyle.Top;
            pnlHeaderTable.FillColor = Color.FromArgb(0, 192, 0);
            pnlHeaderTable.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderTable.Location = new Point(0, 0);
            pnlHeaderTable.Margin = new Padding(4, 5, 4, 5);
            pnlHeaderTable.MinimumSize = new Size(1, 1);
            pnlHeaderTable.Name = "pnlHeaderTable";
            pnlHeaderTable.Radius = 15;
            pnlHeaderTable.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            pnlHeaderTable.RectColor = Color.Transparent;
            pnlHeaderTable.Size = new Size(1213, 41);
            pnlHeaderTable.TabIndex = 1;
            pnlHeaderTable.Text = "Danh sách đề thi";
            pnlHeaderTable.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FillColor = Color.DarkSeaGreen;
            btnRefresh.FillColor2 = Color.Transparent;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1085, 4);
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
            // pnlThaoTac
            // 
            pnlThaoTac.BackColor = Color.Transparent;
            pnlThaoTac.Controls.Add(btnSelectShare);
            pnlThaoTac.Controls.Add(btnSelectDelete);
            pnlThaoTac.Controls.Add(lblSelect);
            pnlThaoTac.Dock = DockStyle.Bottom;
            pnlThaoTac.FillColor = Color.WhiteSmoke;
            pnlThaoTac.Font = new Font("Microsoft Sans Serif", 12F);
            pnlThaoTac.Location = new Point(0, 333);
            pnlThaoTac.Margin = new Padding(4, 5, 4, 5);
            pnlThaoTac.MinimumSize = new Size(1, 1);
            pnlThaoTac.Name = "pnlThaoTac";
            pnlThaoTac.RectColor = Color.Gainsboro;
            pnlThaoTac.Size = new Size(1213, 69);
            pnlThaoTac.TabIndex = 2;
            pnlThaoTac.Text = null;
            pnlThaoTac.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSelectShare
            // 
            btnSelectShare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectShare.FillColor = Color.FromArgb(0, 0, 192);
            btnSelectShare.FillColor2 = Color.Gainsboro;
            btnSelectShare.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectShare.Location = new Point(752, 19);
            btnSelectShare.MinimumSize = new Size(1, 1);
            btnSelectShare.Name = "btnSelectShare";
            btnSelectShare.Radius = 10;
            btnSelectShare.Size = new Size(226, 33);
            btnSelectShare.Symbol = 0;
            btnSelectShare.SymbolSize = 22;
            btnSelectShare.TabIndex = 13;
            btnSelectShare.Text = "Chia sẻ các đề đã chọn";
            btnSelectShare.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSelectShare.Click += btnSelectShare_Click;
            // 
            // btnSelectDelete
            // 
            btnSelectDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectDelete.FillColor = Color.FromArgb(192, 0, 0);
            btnSelectDelete.FillColor2 = Color.Gainsboro;
            btnSelectDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectDelete.Location = new Point(1003, 19);
            btnSelectDelete.MinimumSize = new Size(1, 1);
            btnSelectDelete.Name = "btnSelectDelete";
            btnSelectDelete.Radius = 10;
            btnSelectDelete.Size = new Size(193, 33);
            btnSelectDelete.Symbol = 61453;
            btnSelectDelete.SymbolSize = 22;
            btnSelectDelete.TabIndex = 12;
            btnSelectDelete.Text = "Xóa mục đã chọn";
            btnSelectDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSelectDelete.Click += btnSelectDelete_Click;
            // 
            // lblSelect
            // 
            lblSelect.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = Color.FromArgb(48, 48, 48);
            lblSelect.Location = new Point(27, 19);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(224, 33);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "0 đề thi đang được chọn";
            lblSelect.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_ManageExams
            // 
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UC_ManageExams";
            Size = new Size(1213, 522);
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            pnlDgv.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlHeaderTable.ResumeLayout(false);
            pnlThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Hàm hỗ trợ thêm cột icon nhanh
        private void AddIconColumn(out DataGridViewImageColumn col, string header, Image img)
        {
            col = new DataGridViewImageColumn();
            col.HeaderText = header;
            col.Image = img;
            col.Width = 60;
            dgvExams.Columns.Add(col);
        }

        #endregion

        private Sunny.UI.UIDataGridView dgvExams;
        private Sunny.UI.UIPanel pnlDgv;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbGrade;
        private Sunny.UI.UIComboBox cbSubject;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UIPanel pnlThaoTac;
        private Sunny.UI.UILabel lblSelect;
        private Sunny.UI.UIPanel pnlHeaderTable;
        private Sunny.UI.UISymbolButton btnSelectDelete;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UISymbolButton btnSelectShare;
        private DataGridViewTextBoxColumn colMaDe;
        private DataGridViewTextBoxColumn colTenDe;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colSoCau;
        private DataGridViewTextBoxColumn colThoiGian;
        private DataGridViewImageColumn colShare;
        private DataGridViewImageColumn colExport;
        private DataGridViewButtonColumn xem;
    }
}
