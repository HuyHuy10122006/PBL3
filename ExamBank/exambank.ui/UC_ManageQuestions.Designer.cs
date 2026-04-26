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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Sunny.UI.UIPanel();
            btnAddManual = new Sunny.UI.UISymbolButton();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            cbLevel = new Sunny.UI.UIComboBox();
            cbGrade = new Sunny.UI.UIComboBox();
            cbSubject = new Sunny.UI.UIComboBox();
            txtSearch = new Sunny.UI.UITextBox();
            pnlMain = new Sunny.UI.UIPanel();
            pnldgv = new Sunny.UI.UIPanel();
            dgvQuestions = new Sunny.UI.UIDataGridView();
            pnlQuestion = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            colID = new DataGridViewTextBoxColumn();
            colContent = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colDoKho = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            pnlQuestion.SuspendLayout();
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
            pnlHeader.Controls.Add(cbLevel);
            pnlHeader.Controls.Add(cbGrade);
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
            pnlHeader.Size = new Size(1224, 120);
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAddManual
            // 
            btnAddManual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddManual.FillColor = Color.Gainsboro;
            btnAddManual.FillColor2 = Color.Gainsboro;
            btnAddManual.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddManual.ForeColor = Color.Black;
            btnAddManual.Location = new Point(1040, 40);
            btnAddManual.MinimumSize = new Size(1, 1);
            btnAddManual.Name = "btnAddManual";
            btnAddManual.Radius = 10;
            btnAddManual.Size = new Size(167, 47);
            btnAddManual.Symbol = 61543;
            btnAddManual.SymbolColor = Color.Black;
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
            // cbLevel
            // 
            cbLevel.DataSource = null;
            cbLevel.FillColor = Color.White;
            cbLevel.FillColor2 = Color.FromArgb(24, 24, 24);
            cbLevel.Font = new Font("Microsoft Sans Serif", 12F);
            cbLevel.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbLevel.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbLevel.Location = new Point(701, 60);
            cbLevel.Margin = new Padding(4, 5, 4, 5);
            cbLevel.MinimumSize = new Size(63, 0);
            cbLevel.Name = "cbLevel";
            cbLevel.Padding = new Padding(0, 0, 30, 2);
            cbLevel.Radius = 10;
            cbLevel.RectColor = Color.FromArgb(18, 58, 92);
            cbLevel.Size = new Size(164, 35);
            cbLevel.Style = Sunny.UI.UIStyle.Custom;
            cbLevel.SymbolSize = 24;
            cbLevel.TabIndex = 4;
            cbLevel.TextAlignment = ContentAlignment.MiddleLeft;
            cbLevel.Watermark = "Chọn mức độ";
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
            cbGrade.RectColor = Color.FromArgb(18, 58, 92);
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
            cbSubject.RectColor = Color.FromArgb(18, 58, 92);
            cbSubject.Size = new Size(164, 35);
            cbSubject.Style = Sunny.UI.UIStyle.Custom;
            cbSubject.SymbolSize = 24;
            cbSubject.TabIndex = 1;
            cbSubject.TextAlignment = ContentAlignment.MiddleLeft;
            cbSubject.Watermark = "Chọn môn";
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
            txtSearch.RectColor = Color.FromArgb(18, 58, 92);
            txtSearch.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtSearch.ScrollBarStyleInherited = false;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(282, 35);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolSize = 23;
            txtSearch.TabIndex = 1;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Nhập nội dung...";
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
            pnlMain.Size = new Size(1224, 416);
            pnlMain.TabIndex = 0;
            pnlMain.Text = null;
            pnlMain.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnldgv
            // 
            pnldgv.Controls.Add(dgvQuestions);
            pnldgv.Dock = DockStyle.Fill;
            pnldgv.Font = new Font("Microsoft Sans Serif", 12F);
            pnldgv.Location = new Point(0, 0);
            pnldgv.Margin = new Padding(4, 5, 4, 5);
            pnldgv.MinimumSize = new Size(1, 1);
            pnldgv.Name = "pnldgv";
            pnldgv.Size = new Size(772, 416);
            pnldgv.TabIndex = 2;
            pnldgv.Text = null;
            pnldgv.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvQuestions
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dgvQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuestions.BackgroundColor = Color.White;
            dgvQuestions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQuestions.ColumnHeadersHeight = 32;
            dgvQuestions.Columns.AddRange(new DataGridViewColumn[] { colID, colContent, colMon, colDoKho, colEdit, colDelete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvQuestions.DefaultCellStyle = dataGridViewCellStyle4;
            dgvQuestions.Dock = DockStyle.Fill;
            dgvQuestions.EnableHeadersVisualStyles = false;
            dgvQuestions.Font = new Font("Microsoft Sans Serif", 12F);
            dgvQuestions.GridColor = Color.Black;
            dgvQuestions.Location = new Point(0, 0);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RectColor = Color.Black;
            dgvQuestions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvQuestions.RowHeadersVisible = false;
            dgvQuestions.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dgvQuestions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvQuestions.ScrollBarColor = Color.FromArgb(64, 64, 64);
            dgvQuestions.ScrollBarStyleInherited = false;
            dgvQuestions.SelectedIndex = -1;
            dgvQuestions.Size = new Size(772, 416);
            dgvQuestions.Style = Sunny.UI.UIStyle.Custom;
            dgvQuestions.TabIndex = 0;
            // 
            // pnlQuestion
            // 
            pnlQuestion.Controls.Add(uiPanel1);
            pnlQuestion.Dock = DockStyle.Right;
            pnlQuestion.Font = new Font("Microsoft Sans Serif", 12F);
            pnlQuestion.Location = new Point(772, 0);
            pnlQuestion.Margin = new Padding(4, 5, 4, 5);
            pnlQuestion.MinimumSize = new Size(1, 1);
            pnlQuestion.Name = "pnlQuestion";
            pnlQuestion.Radius = 10;
            pnlQuestion.Size = new Size(452, 416);
            pnlQuestion.TabIndex = 1;
            pnlQuestion.Text = null;
            pnlQuestion.TextAlignment = ContentAlignment.MiddleCenter;
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
            uiPanel1.Radius = 10;
            uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            uiPanel1.RectColor = Color.Transparent;
            uiPanel1.Size = new Size(452, 50);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = "Chi tiết câu hỏi";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 50;
            // 
            // colContent
            // 
            colContent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colContent.HeaderText = "Nội dung câu hỏi";
            colContent.MinimumWidth = 200;
            colContent.Name = "colContent";
            // 
            // colMon
            // 
            colMon.HeaderText = "Môn học";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.Width = 120;
            // 
            // colDoKho
            // 
            colDoKho.HeaderText = "Độ khó";
            colDoKho.MinimumWidth = 6;
            colDoKho.Name = "colDoKho";
            colDoKho.Width = 120;
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.NullValue = "System.Drawing.Bitmap";
            colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            colEdit.HeaderText = "Sửa";
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.Width = 50;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Xóa";
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.Width = 50;
            // 
            // UC_ManageQuestions
            // 
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Name = "UC_ManageQuestions";
            Size = new Size(1224, 536);
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            pnlQuestion.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UIPanel pnlMain;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIDataGridView dgvQuestions;
        private Sunny.UI.UIComboBox cbSubject;
        private Sunny.UI.UIComboBox cbGrade;
        // ComboBox mức độ ở Sidebar
        private Sunny.UI.UIComboBox cbLevel;

        #endregion
        private Sunny.UI.UIPanel pnldgv;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton btnAddManual;
        private Sunny.UI.UIPanel pnlQuestion;
        private Sunny.UI.UIPanel uiPanel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colContent;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colDoKho;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}
