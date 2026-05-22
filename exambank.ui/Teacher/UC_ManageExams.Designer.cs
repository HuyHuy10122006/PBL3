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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvExams = new Sunny.UI.UIDataGridView();
            cmsActions = new Sunny.UI.UIContextMenuStrip(components);
            miView = new ToolStripMenuItem();
            sView = new ToolStripSeparator();
            miShare = new ToolStripMenuItem();
            sShare = new ToolStripSeparator();
            miExport = new ToolStripMenuItem();
            sDelete = new ToolStripSeparator();
            miDelete = new ToolStripMenuItem();
            pnlDgv = new Sunny.UI.UIPanel();
            pnlHeader = new Sunny.UI.UIPanel();
            btnCreateExamByMatrix = new Sunny.UI.UISymbolButton();
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
            colID = new DataGridViewTextBoxColumn();
            colSTT = new DataGridViewTextBoxColumn();
            colExamCode = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colTotalQuestions = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            cmsActions.SuspendLayout();
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
            dgvExams.AllowUserToResizeColumns = false;
            dgvExams.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.BackgroundColor = Color.White;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.ColumnHeadersHeight = 32;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { colID, colSTT, colExamCode, colTitle, colSubject, colTotalQuestions, colDuration, colActions });
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
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvExams.RowTemplate.Height = 33;
            dgvExams.ScrollBarColor = Color.Black;
            dgvExams.ScrollBarRectColor = Color.Black;
            dgvExams.ScrollBarStyleInherited = false;
            dgvExams.SelectedIndex = -1;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1213, 292);
            dgvExams.StripeOddColor = Color.WhiteSmoke;
            dgvExams.TabIndex = 0;
            dgvExams.CellMouseDown += dgvExams_CellMouseDown;
            dgvExams.DataBindingComplete += dgvExams_DataBindingComplete;
            dgvExams.SelectionChanged += dgvExams_SelectionChanged;
            // 
            // cmsActions
            // 
            cmsActions.BackColor = Color.FromArgb(243, 249, 255);
            cmsActions.Font = new Font("Microsoft Sans Serif", 12F);
            cmsActions.ImageScalingSize = new Size(20, 20);
            cmsActions.Items.AddRange(new ToolStripItem[] { miView, sView, miShare, sShare, miExport, sDelete, miDelete });
            cmsActions.Name = "cmsActions";
            cmsActions.RenderMode = ToolStripRenderMode.System;
            cmsActions.Size = new Size(224, 142);
            // 
            // miView
            // 
            miView.Font = new Font("Times New Roman", 13.2000008F);
            miView.Image = Properties.Resources.visibility;
            miView.Name = "miView";
            miView.Size = new Size(223, 30);
            miView.Text = "Xem chi tiết";
            miView.Click += miView_Click;
            // 
            // sView
            // 
            sView.Name = "sView";
            sView.Size = new Size(220, 6);
            // 
            // miShare
            // 
            miShare.Font = new Font("Times New Roman", 13.2000008F);
            miShare.Image = Properties.Resources.share;
            miShare.Name = "miShare";
            miShare.Size = new Size(223, 30);
            miShare.Text = "Chia sẻ";
            miShare.Click += miShare_Click;
            // 
            // sShare
            // 
            sShare.Name = "sShare";
            sShare.Size = new Size(220, 6);
            // 
            // miExport
            // 
            miExport.Font = new Font("Times New Roman", 13.2000008F);
            miExport.Image = Properties.Resources.file_export;
            miExport.Name = "miExport";
            miExport.Size = new Size(223, 30);
            miExport.Text = "Xuất file word";
            miExport.Click += miExport_Click;
            // 
            // sDelete
            // 
            sDelete.Name = "sDelete";
            sDelete.Size = new Size(220, 6);
            // 
            // miDelete
            // 
            miDelete.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miDelete.ForeColor = Color.Red;
            miDelete.Image = Properties.Resources.scan_delete_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            miDelete.Name = "miDelete";
            miDelete.Size = new Size(223, 30);
            miDelete.Text = "Xóa";
            miDelete.Click += miDelete_Click;
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
            pnlHeader.Controls.Add(btnCreateExamByMatrix);
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
            // btnCreateExamByMatrix
            // 
            btnCreateExamByMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateExamByMatrix.FillColor = Color.RoyalBlue;
            btnCreateExamByMatrix.FillColor2 = Color.RoyalBlue;
            btnCreateExamByMatrix.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateExamByMatrix.LightColor = Color.FromArgb(14, 30, 63);
            btnCreateExamByMatrix.Location = new Point(991, 60);
            btnCreateExamByMatrix.MinimumSize = new Size(1, 1);
            btnCreateExamByMatrix.Name = "btnCreateExamByMatrix";
            btnCreateExamByMatrix.Radius = 10;
            btnCreateExamByMatrix.Size = new Size(205, 47);
            btnCreateExamByMatrix.Style = Sunny.UI.UIStyle.Custom;
            btnCreateExamByMatrix.Symbol = 61694;
            btnCreateExamByMatrix.SymbolSize = 22;
            btnCreateExamByMatrix.TabIndex = 13;
            btnCreateExamByMatrix.Text = "Tạo đề từ ma trận";
            btnCreateExamByMatrix.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCreateExamByMatrix.Click += btnCreateExamByMatrix_Click;
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
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            txtSearch.Size = new Size(297, 35);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolSize = 23;
            txtSearch.TabIndex = 12;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập tên đề thi...";
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            uiLabel3.Visible = false;
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
            cbGrade.Font = new Font("Times New Roman", 12F);
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
            cbGrade.Visible = false;
            cbGrade.Watermark = "Chọn khối";
            cbGrade.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // cbSubject
            // 
            cbSubject.DataSource = null;
            cbSubject.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbSubject.FillColor = Color.White;
            cbSubject.FillColor2 = Color.FromArgb(24, 24, 24);
            cbSubject.Font = new Font("Times New Roman", 12F);
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
            cbSubject.SelectedIndexChanged += cb_SelectedIndexChanged;
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
            btnRefresh.FillColor2 = Color.DarkSeaGreen;
            btnRefresh.FillHoverColor = Color.FromArgb(139, 203, 83);
            btnRefresh.FillPressColor = Color.FromArgb(88, 152, 32);
            btnRefresh.FillSelectedColor = Color.FromArgb(88, 152, 32);
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.LightColor = Color.FromArgb(245, 251, 241);
            btnRefresh.Location = new Point(1085, 4);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Radius = 10;
            btnRefresh.RectColor = Color.FromArgb(64, 64, 64);
            btnRefresh.RectHoverColor = Color.FromArgb(139, 203, 83);
            btnRefresh.RectPressColor = Color.FromArgb(88, 152, 32);
            btnRefresh.RectSelectedColor = Color.FromArgb(88, 152, 32);
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
            btnSelectDelete.FillColor2 = Color.FromArgb(192, 0, 0);
            btnSelectDelete.FillHoverColor = Color.FromArgb(235, 115, 115);
            btnSelectDelete.FillPressColor = Color.FromArgb(184, 64, 64);
            btnSelectDelete.FillSelectedColor = Color.FromArgb(184, 64, 64);
            btnSelectDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectDelete.LightColor = Color.FromArgb(253, 243, 243);
            btnSelectDelete.Location = new Point(1003, 19);
            btnSelectDelete.MinimumSize = new Size(1, 1);
            btnSelectDelete.Name = "btnSelectDelete";
            btnSelectDelete.Radius = 10;
            btnSelectDelete.RectColor = Color.FromArgb(230, 80, 80);
            btnSelectDelete.RectHoverColor = Color.FromArgb(235, 115, 115);
            btnSelectDelete.RectPressColor = Color.FromArgb(184, 64, 64);
            btnSelectDelete.RectSelectedColor = Color.FromArgb(184, 64, 64);
            btnSelectDelete.Size = new Size(193, 33);
            btnSelectDelete.Style = Sunny.UI.UIStyle.Custom;
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
            // colID
            // 
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
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 75;
            // 
            // colExamCode
            // 
            colExamCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colExamCode.DataPropertyName = "ExamCode";
            colExamCode.HeaderText = "Mã đề";
            colExamCode.MinimumWidth = 6;
            colExamCode.Name = "colExamCode";
            colExamCode.ReadOnly = true;
            colExamCode.Width = 91;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Tên đề thi";
            colTitle.MinimumWidth = 200;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colSubject.DataPropertyName = "Subject";
            colSubject.HeaderText = "Môn học";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            colSubject.Width = 110;
            // 
            // colTotalQuestions
            // 
            colTotalQuestions.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colTotalQuestions.DataPropertyName = "TotalQuestions";
            colTotalQuestions.HeaderText = "Số câu";
            colTotalQuestions.MinimumWidth = 6;
            colTotalQuestions.Name = "colTotalQuestions";
            colTotalQuestions.ReadOnly = true;
            colTotalQuestions.Width = 93;
            // 
            // colDuration
            // 
            colDuration.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDuration.DataPropertyName = "Duration";
            colDuration.HeaderText = "Thời gian";
            colDuration.MinimumWidth = 6;
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.Width = 117;
            // 
            // colActions
            // 
            colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colActions.DataPropertyName = "Actions";
            colActions.HeaderText = "Thao tác";
            colActions.Image = Properties.Resources.more_vert_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Width = 89;
            // 
            // UC_ManageExams
            // 
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UC_ManageExams";
            Size = new Size(1213, 522);
            Load += UC_ManageExams_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            cmsActions.ResumeLayout(false);
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
        private Sunny.UI.UISymbolButton btnCreateExamByMatrix;
        private Sunny.UI.UIContextMenuStrip cmsActions;
        private ToolStripMenuItem miView;
        private ToolStripMenuItem miShare;
        private ToolStripMenuItem miExport;
        private ToolStripSeparator sView;
        private ToolStripSeparator sShare;
        private ToolStripSeparator sDelete;
        private ToolStripMenuItem miDelete;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colExamCode;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colTotalQuestions;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewImageColumn colActions;
    }
}
