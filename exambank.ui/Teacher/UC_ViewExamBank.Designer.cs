namespace exambank.ui
{
    partial class UC_ViewExamBank
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvPublicExams = new Sunny.UI.UIDataGridView();
            colMaDe = new DataGridViewTextBoxColumn();
            colTenDe = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colXuat = new DataGridViewImageColumn();
            pnlHeader = new Sunny.UI.UIPanel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            txtSearch = new Sunny.UI.UITextBox();
            cbGrade = new Sunny.UI.UIComboBox();
            cbSubject = new Sunny.UI.UIComboBox();
            btnRefresh = new Sunny.UI.UISymbolButton();
            pnlDgv = new Sunny.UI.UIPanel();
            pnlBody = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            pnlThaoTac = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)dgvPublicExams).BeginInit();
            pnlHeader.SuspendLayout();
            pnlDgv.SuspendLayout();
            pnlBody.SuspendLayout();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPublicExams
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPublicExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPublicExams.BackgroundColor = Color.White;
            dgvPublicExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPublicExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPublicExams.ColumnHeadersHeight = 32;
            dgvPublicExams.Columns.AddRange(new DataGridViewColumn[] { colMaDe, colTenDe, colAuthor, colMon, colXuat });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPublicExams.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPublicExams.Dock = DockStyle.Fill;
            dgvPublicExams.EnableHeadersVisualStyles = false;
            dgvPublicExams.Font = new Font("Microsoft Sans Serif", 12F);
            dgvPublicExams.GridColor = Color.Black;
            dgvPublicExams.Location = new Point(0, 0);
            dgvPublicExams.Name = "dgvPublicExams";
            dgvPublicExams.RectColor = Color.Black;
            dgvPublicExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPublicExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPublicExams.RowHeadersVisible = false;
            dgvPublicExams.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F);
            dgvPublicExams.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPublicExams.ScrollBarColor = Color.Black;
            dgvPublicExams.ScrollBarRectColor = Color.Black;
            dgvPublicExams.ScrollBarStyleInherited = false;
            dgvPublicExams.SelectedIndex = -1;
            dgvPublicExams.Size = new Size(1251, 310);
            dgvPublicExams.StripeOddColor = Color.White;
            dgvPublicExams.TabIndex = 0;
            // 
            // colMaDe
            // 
            colMaDe.DataPropertyName = "MaDe";
            colMaDe.HeaderText = "Mã đề";
            colMaDe.MinimumWidth = 6;
            colMaDe.Name = "colMaDe";
            colMaDe.Width = 70;
            // 
            // colTenDe
            // 
            colTenDe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenDe.DataPropertyName = "TenDe";
            colTenDe.HeaderText = "Tên đề thi";
            colTenDe.MinimumWidth = 6;
            colTenDe.Name = "colTenDe";
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "Author";
            colAuthor.HeaderText = "Người chia sẻ";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.Width = 150;
            // 
            // colMon
            // 
            colMon.DataPropertyName = "Mon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMon.DefaultCellStyle = dataGridViewCellStyle3;
            colMon.HeaderText = "Môn học";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.Width = 90;
            // 
            // colXuat
            // 
            colXuat.DataPropertyName = "Xuat";
            colXuat.HeaderText = "Xuất";
            colXuat.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colXuat.MinimumWidth = 6;
            colXuat.Name = "colXuat";
            colXuat.Width = 50;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(uiLabel3);
            pnlHeader.Controls.Add(uiLabel2);
            pnlHeader.Controls.Add(uiLabel1);
            pnlHeader.Controls.Add(txtSearch);
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
            pnlHeader.Size = new Size(1251, 120);
            pnlHeader.TabIndex = 6;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
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
            uiLabel1.Text = "TÌM KIẾM ĐỀ THI";
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
            txtSearch.TabIndex = 13;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập tên đề, giáo viên...";
            // 
            // cbGrade
            // 
            cbGrade.DataSource = null;
            cbGrade.FillColor = Color.White;
            cbGrade.FillColor2 = Color.FromArgb(24, 24, 24);
            cbGrade.Font = new Font("Microsoft Sans Serif", 12F);
            cbGrade.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbGrade.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbGrade.Location = new Point(510, 60);
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
            cbSubject.Location = new Point(323, 60);
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
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FillColor = Color.DarkSeaGreen;
            btnRefresh.FillColor2 = Color.Transparent;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1123, 4);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Radius = 10;
            btnRefresh.RectColor = Color.Black;
            btnRefresh.Size = new Size(121, 34);
            btnRefresh.Symbol = 61473;
            btnRefresh.SymbolColor = Color.Black;
            btnRefresh.SymbolSize = 22;
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // pnlDgv
            // 
            pnlDgv.Controls.Add(dgvPublicExams);
            pnlDgv.Dock = DockStyle.Fill;
            pnlDgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDgv.Location = new Point(0, 41);
            pnlDgv.Margin = new Padding(4, 5, 4, 5);
            pnlDgv.MinimumSize = new Size(1, 1);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Size = new Size(1251, 310);
            pnlDgv.TabIndex = 7;
            pnlDgv.Text = null;
            pnlDgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlDgv);
            pnlBody.Controls.Add(uiPanel2);
            pnlBody.Controls.Add(pnlThaoTac);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBody.Location = new Point(0, 120);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.RectColor = Color.Black;
            pnlBody.Size = new Size(1251, 420);
            pnlBody.TabIndex = 9;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
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
            uiPanel2.Size = new Size(1251, 41);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = "Danh sách đề thi";
            uiPanel2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // pnlThaoTac
            // 
            pnlThaoTac.BackColor = Color.Transparent;
            pnlThaoTac.Dock = DockStyle.Bottom;
            pnlThaoTac.FillColor = Color.WhiteSmoke;
            pnlThaoTac.Font = new Font("Microsoft Sans Serif", 12F);
            pnlThaoTac.Location = new Point(0, 351);
            pnlThaoTac.Margin = new Padding(4, 5, 4, 5);
            pnlThaoTac.MinimumSize = new Size(1, 1);
            pnlThaoTac.Name = "pnlThaoTac";
            pnlThaoTac.RectColor = Color.Gainsboro;
            pnlThaoTac.Size = new Size(1251, 69);
            pnlThaoTac.TabIndex = 2;
            pnlThaoTac.Text = null;
            pnlThaoTac.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // UC_ViewExamBank
            // 
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UC_ViewExamBank";
            Size = new Size(1251, 540);
            ((System.ComponentModel.ISupportInitialize)dgvPublicExams).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlDgv.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIDataGridView dgvPublicExams;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbGrade;
        private Sunny.UI.UIComboBox cbSubject;
        private Sunny.UI.UIPanel pnlDgv;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel pnlThaoTac;
        private Sunny.UI.UITextBox txtSearch;
        private DataGridViewTextBoxColumn colMaDe;
        private DataGridViewTextBoxColumn colTenDe;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewImageColumn colXuat;
    }
}
