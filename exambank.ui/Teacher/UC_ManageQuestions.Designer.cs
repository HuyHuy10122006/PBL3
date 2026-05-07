namespace exambank.ui
{
    partial class UC_ManageQuestions
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Sunny.UI.UIPanel();
            btnAddManual = new Sunny.UI.UISymbolButton();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            cbDoKho = new Sunny.UI.UIComboBox();
            cbKhoi = new Sunny.UI.UIComboBox();
            cbMonHoc = new Sunny.UI.UIComboBox();
            txtSearch = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UISymbolButton();
            pnlMain = new Sunny.UI.UIPanel();
            pnldgv = new Sunny.UI.UIPanel();
            pnlThaoTacTable = new Sunny.UI.UIPanel();
            btnTaoDe = new Sunny.UI.UISymbolButton();
            lblSelect = new Sunny.UI.UILabel();
            pnlHeaderTable = new Sunny.UI.UIPanel();
            btnRefresh = new Sunny.UI.UISymbolButton();
            dgvQuestions = new Sunny.UI.UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            colContent = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colDoKho = new DataGridViewTextBoxColumn();
            colSua = new DataGridViewImageColumn();
            colXoa = new DataGridViewImageColumn();
            pnlQuestion = new Sunny.UI.UIPanel();
            pnlThaoTacExam = new Sunny.UI.UIPanel();
            btnSave = new Sunny.UI.UISymbolButton();
            flpQuestion = new FlowLayoutPanel();
            pnlHeaderQuestion = new Sunny.UI.UIPanel();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnldgv.SuspendLayout();
            pnlThaoTacTable.SuspendLayout();
            pnlHeaderTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            pnlQuestion.SuspendLayout();
            pnlThaoTacExam.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(btnAddManual);
            pnlHeader.Controls.Add(uiLabel4);
            pnlHeader.Controls.Add(uiLabel3);
            pnlHeader.Controls.Add(uiLabel2);
            pnlHeader.Controls.Add(uiLabel1);
            pnlHeader.Controls.Add(cbDoKho);
            pnlHeader.Controls.Add(cbKhoi);
            pnlHeader.Controls.Add(cbMonHoc);
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
            pnlHeader.Size = new Size(1270, 120);
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAddManual
            // 
            btnAddManual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddManual.FillColor = Color.FromArgb(0, 150, 136);
            btnAddManual.FillColor2 = Color.FromArgb(0, 150, 136);
            btnAddManual.FillHoverColor = Color.FromArgb(51, 171, 160);
            btnAddManual.FillPressColor = Color.FromArgb(0, 120, 109);
            btnAddManual.FillSelectedColor = Color.FromArgb(0, 120, 109);
            btnAddManual.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddManual.LightColor = Color.FromArgb(238, 248, 248);
            btnAddManual.Location = new Point(1091, 61);
            btnAddManual.MinimumSize = new Size(1, 1);
            btnAddManual.Name = "btnAddManual";
            btnAddManual.Radius = 10;
            btnAddManual.RectColor = Color.FromArgb(0, 150, 136);
            btnAddManual.RectHoverColor = Color.FromArgb(51, 171, 160);
            btnAddManual.RectPressColor = Color.FromArgb(0, 120, 109);
            btnAddManual.RectSelectedColor = Color.FromArgb(0, 120, 109);
            btnAddManual.Size = new Size(167, 47);
            btnAddManual.Style = Sunny.UI.UIStyle.Custom;
            btnAddManual.Symbol = 61694;
            btnAddManual.SymbolSize = 22;
            btnAddManual.TabIndex = 9;
            btnAddManual.Text = "Thêm thủ công";
            btnAddManual.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("Times New Roman", 12F);
            uiLabel4.ForeColor = Color.WhiteSmoke;
            uiLabel4.Location = new Point(701, 26);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(121, 29);
            uiLabel4.TabIndex = 8;
            uiLabel4.Text = "Độ khó:";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("Times New Roman", 12F);
            uiLabel3.ForeColor = Color.WhiteSmoke;
            uiLabel3.Location = new Point(510, 26);
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
            uiLabel2.Location = new Point(323, 26);
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
            uiLabel1.Text = "TÌM KIẾM CÂU HỎI";
            // 
            // cbDoKho
            // 
            cbDoKho.DataSource = null;
            cbDoKho.FillColor = Color.White;
            cbDoKho.FillColor2 = Color.FromArgb(24, 24, 24);
            cbDoKho.Font = new Font("Microsoft Sans Serif", 12F);
            cbDoKho.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbDoKho.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbDoKho.Location = new Point(701, 60);
            cbDoKho.Margin = new Padding(4, 5, 4, 5);
            cbDoKho.MinimumSize = new Size(63, 0);
            cbDoKho.Name = "cbDoKho";
            cbDoKho.Padding = new Padding(0, 0, 30, 2);
            cbDoKho.Radius = 10;
            cbDoKho.RectColor = Color.Black;
            cbDoKho.Size = new Size(164, 35);
            cbDoKho.Style = Sunny.UI.UIStyle.Custom;
            cbDoKho.SymbolSize = 24;
            cbDoKho.TabIndex = 4;
            cbDoKho.TextAlignment = ContentAlignment.MiddleLeft;
            cbDoKho.Watermark = "Chọn mức độ";
            // 
            // cbKhoi
            // 
            cbKhoi.DataSource = null;
            cbKhoi.FillColor = Color.White;
            cbKhoi.FillColor2 = Color.FromArgb(24, 24, 24);
            cbKhoi.Font = new Font("Microsoft Sans Serif", 12F);
            cbKhoi.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbKhoi.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbKhoi.Location = new Point(510, 60);
            cbKhoi.Margin = new Padding(4, 5, 4, 5);
            cbKhoi.MinimumSize = new Size(63, 0);
            cbKhoi.Name = "cbKhoi";
            cbKhoi.Padding = new Padding(0, 0, 30, 2);
            cbKhoi.Radius = 10;
            cbKhoi.RectColor = Color.Black;
            cbKhoi.Size = new Size(164, 35);
            cbKhoi.Style = Sunny.UI.UIStyle.Custom;
            cbKhoi.SymbolSize = 24;
            cbKhoi.TabIndex = 2;
            cbKhoi.TextAlignment = ContentAlignment.MiddleLeft;
            cbKhoi.Watermark = "Chọn khối";
            // 
            // cbMonHoc
            // 
            cbMonHoc.DataSource = null;
            cbMonHoc.FillColor = Color.White;
            cbMonHoc.FillColor2 = Color.FromArgb(24, 24, 24);
            cbMonHoc.Font = new Font("Microsoft Sans Serif", 12F);
            cbMonHoc.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMonHoc.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMonHoc.Location = new Point(323, 60);
            cbMonHoc.Margin = new Padding(4, 5, 4, 5);
            cbMonHoc.MinimumSize = new Size(63, 0);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Padding = new Padding(0, 0, 30, 2);
            cbMonHoc.Radius = 10;
            cbMonHoc.RectColor = Color.Black;
            cbMonHoc.Size = new Size(164, 35);
            cbMonHoc.Style = Sunny.UI.UIStyle.Custom;
            cbMonHoc.SymbolSize = 24;
            cbMonHoc.TabIndex = 1;
            cbMonHoc.TextAlignment = ContentAlignment.MiddleLeft;
            cbMonHoc.Watermark = "Chọn môn";
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
            txtSearch.Size = new Size(282, 35);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.SymbolSize = 23;
            txtSearch.TabIndex = 1;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập nội dung...";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FillColor = Color.FromArgb(192, 0, 0);
            btnDelete.FillColor2 = Color.Gainsboro;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(603, 19);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 10;
            btnDelete.Size = new Size(193, 33);
            btnDelete.Symbol = 61453;
            btnDelete.SymbolSize = 22;
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa mục đã chọn";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnldgv);
            pnlMain.Controls.Add(pnlQuestion);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Microsoft Sans Serif", 12F);
            pnlMain.Location = new Point(0, 120);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.MinimumSize = new Size(1, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1270, 416);
            pnlMain.TabIndex = 0;
            pnlMain.Text = null;
            pnlMain.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnldgv
            // 
            pnldgv.Controls.Add(pnlThaoTacTable);
            pnldgv.Controls.Add(pnlHeaderTable);
            pnldgv.Controls.Add(dgvQuestions);
            pnldgv.Dock = DockStyle.Fill;
            pnldgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnldgv.Location = new Point(0, 0);
            pnldgv.Margin = new Padding(4, 5, 4, 5);
            pnldgv.MinimumSize = new Size(1, 1);
            pnldgv.Name = "pnldgv";
            pnldgv.RectColor = Color.Black;
            pnldgv.Size = new Size(816, 416);
            pnldgv.TabIndex = 2;
            pnldgv.Text = null;
            pnldgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlThaoTacTable
            // 
            pnlThaoTacTable.BackColor = Color.Transparent;
            pnlThaoTacTable.Controls.Add(btnTaoDe);
            pnlThaoTacTable.Controls.Add(btnDelete);
            pnlThaoTacTable.Controls.Add(lblSelect);
            pnlThaoTacTable.Dock = DockStyle.Bottom;
            pnlThaoTacTable.FillColor = Color.WhiteSmoke;
            pnlThaoTacTable.Font = new Font("Microsoft Sans Serif", 12F);
            pnlThaoTacTable.Location = new Point(0, 346);
            pnlThaoTacTable.Margin = new Padding(4, 5, 4, 5);
            pnlThaoTacTable.MinimumSize = new Size(1, 1);
            pnlThaoTacTable.Name = "pnlThaoTacTable";
            pnlThaoTacTable.RectColor = Color.Gainsboro;
            pnlThaoTacTable.Size = new Size(816, 70);
            pnlThaoTacTable.TabIndex = 2;
            pnlThaoTacTable.Text = null;
            pnlThaoTacTable.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnTaoDe
            // 
            btnTaoDe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTaoDe.FillColor = Color.FromArgb(0, 0, 192);
            btnTaoDe.FillColor2 = Color.Gainsboro;
            btnTaoDe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaoDe.Location = new Point(353, 19);
            btnTaoDe.MinimumSize = new Size(1, 1);
            btnTaoDe.Name = "btnTaoDe";
            btnTaoDe.Radius = 10;
            btnTaoDe.Size = new Size(226, 33);
            btnTaoDe.Symbol = 0;
            btnTaoDe.SymbolSize = 22;
            btnTaoDe.TabIndex = 11;
            btnTaoDe.Text = "Tạo đề từ câu đã chọn";
            btnTaoDe.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTaoDe.Click += btnTaoDe_Click;
            // 
            // lblSelect
            // 
            lblSelect.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = Color.FromArgb(48, 48, 48);
            lblSelect.Location = new Point(27, 19);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(224, 33);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "0 câu hỏi đang được chọn";
            lblSelect.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlHeaderTable.Size = new Size(816, 41);
            pnlHeaderTable.TabIndex = 1;
            pnlHeaderTable.Text = "Danh sách câu hỏi";
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
            btnRefresh.Location = new Point(688, 4);
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
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvQuestions
            // 
            dgvQuestions.AllowUserToAddRows = false;
            dgvQuestions.AllowUserToDeleteRows = false;
            dgvQuestions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQuestions.BackgroundColor = Color.White;
            dgvQuestions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQuestions.ColumnHeadersHeight = 32;
            dgvQuestions.Columns.AddRange(new DataGridViewColumn[] { colID, colContent, colMon, colDoKho, colSua, colXoa });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvQuestions.DefaultCellStyle = dataGridViewCellStyle7;
            dgvQuestions.EnableHeadersVisualStyles = false;
            dgvQuestions.Font = new Font("Microsoft Sans Serif", 12F);
            dgvQuestions.GridColor = Color.Black;
            dgvQuestions.Location = new Point(0, 40);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dgvQuestions.RectColor = Color.Black;
            dgvQuestions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvQuestions.RowHeadersVisible = false;
            dgvQuestions.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dgvQuestions.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvQuestions.ScrollBarColor = Color.Black;
            dgvQuestions.ScrollBarRectColor = Color.Black;
            dgvQuestions.ScrollBarStyleInherited = false;
            dgvQuestions.SelectedIndex = -1;
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(816, 307);
            dgvQuestions.StripeOddColor = Color.White;
            dgvQuestions.Style = Sunny.UI.UIStyle.Custom;
            dgvQuestions.TabIndex = 0;
            dgvQuestions.CellClick += dgvQuestions_CellClick;
            dgvQuestions.SelectionChanged += dgvQuestions_SelectionChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colID.DefaultCellStyle = dataGridViewCellStyle3;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 50;
            // 
            // colContent
            // 
            colContent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colContent.DataPropertyName = "Content";
            colContent.HeaderText = "Nội dung câu hỏi";
            colContent.MinimumWidth = 200;
            colContent.Name = "colContent";
            colContent.ReadOnly = true;
            // 
            // colMon
            // 
            colMon.DataPropertyName = "MonHoc";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMon.DefaultCellStyle = dataGridViewCellStyle4;
            colMon.HeaderText = "Môn học";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            colMon.Width = 120;
            // 
            // colDoKho
            // 
            colDoKho.DataPropertyName = "DoKho";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDoKho.DefaultCellStyle = dataGridViewCellStyle5;
            colDoKho.HeaderText = "Độ khó";
            colDoKho.MinimumWidth = 6;
            colDoKho.Name = "colDoKho";
            colDoKho.ReadOnly = true;
            colDoKho.Width = 120;
            // 
            // colSua
            // 
            colSua.DataPropertyName = "Sua";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Red;
            dataGridViewCellStyle6.NullValue = "System.Drawing.Bitmap";
            colSua.DefaultCellStyle = dataGridViewCellStyle6;
            colSua.HeaderText = "Sửa";
            colSua.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colSua.MinimumWidth = 6;
            colSua.Name = "colSua";
            colSua.ReadOnly = true;
            colSua.Width = 50;
            // 
            // colXoa
            // 
            colXoa.DataPropertyName = "Xoa";
            colXoa.HeaderText = "Xóa";
            colXoa.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colXoa.MinimumWidth = 6;
            colXoa.Name = "colXoa";
            colXoa.ReadOnly = true;
            colXoa.Resizable = DataGridViewTriState.True;
            colXoa.Width = 50;
            // 
            // pnlQuestion
            // 
            pnlQuestion.Controls.Add(pnlThaoTacExam);
            pnlQuestion.Controls.Add(flpQuestion);
            pnlQuestion.Controls.Add(pnlHeaderQuestion);
            pnlQuestion.Dock = DockStyle.Right;
            pnlQuestion.Font = new Font("Microsoft Sans Serif", 12F);
            pnlQuestion.Location = new Point(816, 0);
            pnlQuestion.Margin = new Padding(4, 5, 4, 5);
            pnlQuestion.MinimumSize = new Size(1, 1);
            pnlQuestion.Name = "pnlQuestion";
            pnlQuestion.Radius = 10;
            pnlQuestion.Size = new Size(454, 416);
            pnlQuestion.TabIndex = 1;
            pnlQuestion.Text = null;
            pnlQuestion.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlThaoTacExam
            // 
            pnlThaoTacExam.BackColor = Color.Transparent;
            pnlThaoTacExam.Controls.Add(btnSave);
            pnlThaoTacExam.Dock = DockStyle.Bottom;
            pnlThaoTacExam.FillColor = Color.WhiteSmoke;
            pnlThaoTacExam.Font = new Font("Microsoft Sans Serif", 12F);
            pnlThaoTacExam.Location = new Point(0, 346);
            pnlThaoTacExam.Margin = new Padding(4, 5, 4, 5);
            pnlThaoTacExam.MinimumSize = new Size(1, 1);
            pnlThaoTacExam.Name = "pnlThaoTacExam";
            pnlThaoTacExam.RectColor = Color.Gainsboro;
            pnlThaoTacExam.Size = new Size(454, 70);
            pnlThaoTacExam.TabIndex = 3;
            pnlThaoTacExam.Text = null;
            pnlThaoTacExam.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FillColor = Color.FromArgb(0, 0, 192);
            btnSave.FillColor2 = Color.Gainsboro;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(323, 12);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(119, 40);
            btnSave.Symbol = 61639;
            btnSave.SymbolSize = 22;
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // flpQuestion
            // 
            flpQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpQuestion.BackColor = Color.White;
            flpQuestion.Location = new Point(0, 41);
            flpQuestion.Name = "flpQuestion";
            flpQuestion.Size = new Size(454, 306);
            flpQuestion.TabIndex = 1;
            // 
            // pnlHeaderQuestion
            // 
            pnlHeaderQuestion.Dock = DockStyle.Top;
            pnlHeaderQuestion.FillColor = Color.FromArgb(0, 192, 0);
            pnlHeaderQuestion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderQuestion.Location = new Point(0, 0);
            pnlHeaderQuestion.Margin = new Padding(4, 5, 4, 5);
            pnlHeaderQuestion.MinimumSize = new Size(1, 1);
            pnlHeaderQuestion.Name = "pnlHeaderQuestion";
            pnlHeaderQuestion.Radius = 15;
            pnlHeaderQuestion.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            pnlHeaderQuestion.RectColor = Color.Transparent;
            pnlHeaderQuestion.Size = new Size(454, 41);
            pnlHeaderQuestion.TabIndex = 0;
            pnlHeaderQuestion.Text = "Chi tiết câu hỏi";
            pnlHeaderQuestion.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // UC_ManageQuestions
            // 
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Name = "UC_ManageQuestions";
            Size = new Size(1270, 536);
            Load += UC_ManageQuestions_Load;
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnldgv.ResumeLayout(false);
            pnlThaoTacTable.ResumeLayout(false);
            pnlHeaderTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            pnlQuestion.ResumeLayout(false);
            pnlThaoTacExam.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UIPanel pnlMain;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIDataGridView dgvQuestions;
        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UIComboBox cbKhoi;
        // ComboBox mức độ ở Sidebar
        private Sunny.UI.UIComboBox cbDoKho;

        #endregion
        private Sunny.UI.UIPanel pnldgv;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton btnAddManual;
        private Sunny.UI.UIPanel pnlQuestion;
        private Sunny.UI.UIPanel pnlHeaderQuestion;
        private Sunny.UI.UIPanel pnlHeaderTable;
        private FlowLayoutPanel flpQuestion;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colContent;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colDoKho;
        private DataGridViewImageColumn colSua;
        private DataGridViewImageColumn colXoa;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UIPanel pnlThaoTacTable;
        private Sunny.UI.UILabel lblSelect;
        private Sunny.UI.UISymbolButton btnTaoDe;
        private Sunny.UI.UIPanel pnlThaoTacExam;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnRefresh;
    }
}
