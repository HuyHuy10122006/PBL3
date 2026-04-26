namespace exambank.ui
{
    partial class UC_AICreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AICreate));
            pnlLeft = new Sunny.UI.UIPanel();
            pnlCauHinh = new Sunny.UI.UIPanel();
            cbMonHoc = new Sunny.UI.UIComboBox();
            txtSelectedChuong = new Sunny.UI.UITextBox();
            cbKhoi = new Sunny.UI.UIComboBox();
            uiLabel3 = new Sunny.UI.UILabel();
            grpMucDo = new Sunny.UI.UIGroupBox();
            uiLabel6 = new Sunny.UI.UILabel();
            uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            unit1 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiIntegerUpDown2 = new Sunny.UI.UIIntegerUpDown();
            unit2 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiIntegerUpDown3 = new Sunny.UI.UIIntegerUpDown();
            unit3 = new Sunny.UI.UILabel();
            lblVDC = new Sunny.UI.UILabel();
            numVDC = new Sunny.UI.UIIntegerUpDown();
            unit4 = new Sunny.UI.UILabel();
            pnlFooter = new Sunny.UI.UIPanel();
            lblTongSoCau = new Sunny.UI.UILabel();
            pnlPopup = new Sunny.UI.UIPanel();
            clbChuong = new CheckedListBox();
            btnDone = new Sunny.UI.UIButton();
            pnlNguonDuLieu = new Sunny.UI.UIPanel();
            tabSource = new Sunny.UI.UITabControl();
            tpFile = new TabPage();
            btnSelectFile = new Sunny.UI.UISymbolButton();
            lblFileStatus = new Sunny.UI.UILabel();
            tpText = new TabPage();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            pnlThaoTac = new Sunny.UI.UIPanel();
            btnCreateExam = new Sunny.UI.UISymbolButton();
            uiLabel1 = new Sunny.UI.UILabel();
            vSplitter = new Splitter();
            dgvQuestions = new System.Windows.Forms.DataGridView();
            pnlLeft.SuspendLayout();
            pnlCauHinh.SuspendLayout();
            grpMucDo.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlPopup.SuspendLayout();
            pnlNguonDuLieu.SuspendLayout();
            tabSource.SuspendLayout();
            tpFile.SuspendLayout();
            tpText.SuspendLayout();
            pnlThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Visible = false;
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pnlCauHinh);
            pnlLeft.Controls.Add(pnlNguonDuLieu);
            pnlLeft.Controls.Add(pnlThaoTac);
            resources.ApplyResources(pnlLeft, "pnlLeft");
            pnlLeft.FillColor = Color.FromArgb(245, 245, 250);
            pnlLeft.FillColor2 = Color.FromArgb(245, 245, 250);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Radius = 15;
            pnlLeft.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlCauHinh
            // 
            pnlCauHinh.BackColor = Color.White;
            pnlCauHinh.Controls.Add(cbMonHoc);
            pnlCauHinh.Controls.Add(txtSelectedChuong);
            pnlCauHinh.Controls.Add(cbKhoi);
            pnlCauHinh.Controls.Add(uiLabel3);
            pnlCauHinh.Controls.Add(grpMucDo);
            pnlCauHinh.Controls.Add(pnlFooter);
            pnlCauHinh.Controls.Add(pnlPopup);
            pnlCauHinh.FillColor = Color.White;
            pnlCauHinh.FillColor2 = Color.White;
            resources.ApplyResources(pnlCauHinh, "pnlCauHinh");
            pnlCauHinh.Name = "pnlCauHinh";
            pnlCauHinh.Radius = 15;
            pnlCauHinh.RectColor = Color.Black;
            pnlCauHinh.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cbMonHoc
            // 
            cbMonHoc.DataSource = null;
            cbMonHoc.FillColor = Color.White;
            resources.ApplyResources(cbMonHoc, "cbMonHoc");
            cbMonHoc.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMonHoc.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.SymbolSize = 24;
            cbMonHoc.TextAlignment = ContentAlignment.MiddleLeft;
            cbMonHoc.Watermark = "Chọn môn học...";
            // 
            // txtSelectedChuong
            // 
            txtSelectedChuong.BackColor = Color.White;
            txtSelectedChuong.ButtonSymbol = 61560;
            txtSelectedChuong.FillColor2 = Color.White;
            txtSelectedChuong.FillReadOnlyColor = Color.White;
            resources.ApplyResources(txtSelectedChuong, "txtSelectedChuong");
            txtSelectedChuong.ForeDisableColor = Color.FromArgb(244, 244, 244);
            txtSelectedChuong.ForeReadOnlyColor = Color.FromArgb(244, 244, 244);
            txtSelectedChuong.Name = "txtSelectedChuong";
            txtSelectedChuong.ReadOnly = true;
            txtSelectedChuong.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtSelectedChuong.ShowText = false;
            txtSelectedChuong.SymbolColor = Color.FromArgb(80, 160, 255);
            txtSelectedChuong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSelectedChuong.Watermark = "Nhấp để chọn chương...";
            txtSelectedChuong.Click += txtSelectedChuong_Click;
            // 
            // cbKhoi
            // 
            cbKhoi.DataSource = null;
            cbKhoi.FillColor = Color.White;
            resources.ApplyResources(cbKhoi, "cbKhoi");
            cbKhoi.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbKhoi.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbKhoi.Name = "cbKhoi";
            cbKhoi.SymbolSize = 24;
            cbKhoi.TextAlignment = ContentAlignment.MiddleLeft;
            cbKhoi.Watermark = "Chọn khối...";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.White;
            resources.ApplyResources(uiLabel3, "uiLabel3");
            uiLabel3.ForeColor = Color.Navy;
            uiLabel3.Name = "uiLabel3";
            // 
            // grpMucDo
            // 
            grpMucDo.BackColor = Color.White;
            grpMucDo.Controls.Add(uiLabel6);
            grpMucDo.Controls.Add(uiIntegerUpDown1);
            grpMucDo.Controls.Add(unit1);
            grpMucDo.Controls.Add(uiLabel7);
            grpMucDo.Controls.Add(uiIntegerUpDown2);
            grpMucDo.Controls.Add(unit2);
            grpMucDo.Controls.Add(uiLabel8);
            grpMucDo.Controls.Add(uiIntegerUpDown3);
            grpMucDo.Controls.Add(unit3);
            grpMucDo.Controls.Add(lblVDC);
            grpMucDo.Controls.Add(numVDC);
            grpMucDo.Controls.Add(unit4);
            grpMucDo.FillColor = Color.White;
            resources.ApplyResources(grpMucDo, "grpMucDo");
            grpMucDo.Name = "grpMucDo";
            grpMucDo.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            resources.ApplyResources(uiLabel6, "uiLabel6");
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Name = "uiLabel6";
            // 
            // uiIntegerUpDown1
            // 
            resources.ApplyResources(uiIntegerUpDown1, "uiIntegerUpDown1");
            uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            uiIntegerUpDown1.ShowText = false;
            uiIntegerUpDown1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // unit1
            // 
            resources.ApplyResources(unit1, "unit1");
            unit1.ForeColor = Color.FromArgb(48, 48, 48);
            unit1.Name = "unit1";
            // 
            // uiLabel7
            // 
            resources.ApplyResources(uiLabel7, "uiLabel7");
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Name = "uiLabel7";
            // 
            // uiIntegerUpDown2
            // 
            resources.ApplyResources(uiIntegerUpDown2, "uiIntegerUpDown2");
            uiIntegerUpDown2.Name = "uiIntegerUpDown2";
            uiIntegerUpDown2.ShowText = false;
            uiIntegerUpDown2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // unit2
            // 
            resources.ApplyResources(unit2, "unit2");
            unit2.ForeColor = Color.FromArgb(48, 48, 48);
            unit2.Name = "unit2";
            // 
            // uiLabel8
            // 
            resources.ApplyResources(uiLabel8, "uiLabel8");
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Name = "uiLabel8";
            // 
            // uiIntegerUpDown3
            // 
            resources.ApplyResources(uiIntegerUpDown3, "uiIntegerUpDown3");
            uiIntegerUpDown3.Name = "uiIntegerUpDown3";
            uiIntegerUpDown3.ShowText = false;
            uiIntegerUpDown3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // unit3
            // 
            resources.ApplyResources(unit3, "unit3");
            unit3.ForeColor = Color.FromArgb(48, 48, 48);
            unit3.Name = "unit3";
            // 
            // lblVDC
            // 
            resources.ApplyResources(lblVDC, "lblVDC");
            lblVDC.ForeColor = Color.FromArgb(48, 48, 48);
            lblVDC.Name = "lblVDC";
            // 
            // numVDC
            // 
            resources.ApplyResources(numVDC, "numVDC");
            numVDC.Name = "numVDC";
            numVDC.ShowText = false;
            numVDC.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // unit4
            // 
            resources.ApplyResources(unit4, "unit4");
            unit4.ForeColor = Color.FromArgb(48, 48, 48);
            unit4.Name = "unit4";
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(lblTongSoCau);
            pnlFooter.FillColor = Color.FromArgb(80, 160, 255);
            resources.ApplyResources(pnlFooter, "pnlFooter");
            pnlFooter.Name = "pnlFooter";
            pnlFooter.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlFooter.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTongSoCau
            // 
            lblTongSoCau.BackColor = Color.FromArgb(80, 160, 255);
            resources.ApplyResources(lblTongSoCau, "lblTongSoCau");
            lblTongSoCau.ForeColor = Color.White;
            lblTongSoCau.Name = "lblTongSoCau";
            // 
            // pnlPopup
            // 
            pnlPopup.BackColor = Color.FromArgb(244, 244, 244);
            pnlPopup.Controls.Add(clbChuong);
            pnlPopup.Controls.Add(btnDone);
            pnlPopup.FillColor = Color.FromArgb(244, 244, 244);
            resources.ApplyResources(pnlPopup, "pnlPopup");
            pnlPopup.Name = "pnlPopup";
            pnlPopup.RectColor = Color.Black;
            pnlPopup.RectDisableColor = Color.White;
            pnlPopup.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // clbChuong
            // 
            clbChuong.BackColor = Color.FromArgb(244, 244, 244);
            clbChuong.BorderStyle = BorderStyle.None;
            clbChuong.CheckOnClick = true;
            clbChuong.FormattingEnabled = true;
            resources.ApplyResources(clbChuong, "clbChuong");
            clbChuong.Name = "clbChuong";
            // 
            // btnDone
            // 
            resources.ApplyResources(btnDone, "btnDone");
            btnDone.Name = "btnDone";
            btnDone.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDone.Click += btnDone_Click;
            // 
            // pnlNguonDuLieu
            // 
            pnlNguonDuLieu.BackColor = Color.FromArgb(245, 245, 250);
            pnlNguonDuLieu.Controls.Add(tabSource);
            pnlNguonDuLieu.Controls.Add(uiLabel2);
            pnlNguonDuLieu.FillColor = Color.White;
            pnlNguonDuLieu.FillColor2 = Color.White;
            resources.ApplyResources(pnlNguonDuLieu, "pnlNguonDuLieu");
            pnlNguonDuLieu.Name = "pnlNguonDuLieu";
            pnlNguonDuLieu.Radius = 15;
            pnlNguonDuLieu.RectColor = Color.Black;
            pnlNguonDuLieu.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tabSource
            // 
            tabSource.Controls.Add(tpFile);
            tabSource.Controls.Add(tpText);
            tabSource.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabSource.FillColor = Color.White;
            resources.ApplyResources(tabSource, "tabSource");
            tabSource.MainPage = "";
            tabSource.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tabSource.Name = "tabSource";
            tabSource.SelectedIndex = 0;
            tabSource.SizeMode = TabSizeMode.Fixed;
            tabSource.TabBackColor = Color.White;
            tabSource.TabSelectedColor = Color.LightGray;
            tabSource.TabSelectedForeColor = Color.Navy;
            tabSource.TabSelectedHighColor = Color.Blue;
            tabSource.TabUnSelectedColor = Color.WhiteSmoke;
            tabSource.TabUnSelectedForeColor = Color.DimGray;
            tabSource.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // tpFile
            // 
            tpFile.BackColor = Color.White;
            tpFile.Controls.Add(btnSelectFile);
            tpFile.Controls.Add(lblFileStatus);
            resources.ApplyResources(tpFile, "tpFile");
            tpFile.Name = "tpFile";
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(btnSelectFile, "btnSelectFile");
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Symbol = 61717;
            btnSelectFile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblFileStatus
            // 
            resources.ApplyResources(lblFileStatus, "lblFileStatus");
            lblFileStatus.ForeColor = Color.FromArgb(48, 48, 48);
            lblFileStatus.Name = "lblFileStatus";
            // 
            // tpText
            // 
            tpText.BackColor = Color.White;
            tpText.Controls.Add(uiTextBox1);
            resources.ApplyResources(tpText, "tpText");
            tpText.Name = "tpText";
            // 
            // uiTextBox1
            // 
            uiTextBox1.ButtonRectColor = Color.FromArgb(18, 58, 92);
            uiTextBox1.ButtonStyleInherited = false;
            resources.ApplyResources(uiTextBox1, "uiTextBox1");
            uiTextBox1.FillColor2 = Color.FromArgb(24, 24, 24);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.RectColor = Color.DarkGray;
            uiTextBox1.ScrollBarColor = Color.FromArgb(24, 24, 24);
            uiTextBox1.ScrollBarStyleInherited = false;
            uiTextBox1.ShowScrollBar = true;
            uiTextBox1.ShowText = false;
            uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "Nhập văn bản vào đây...";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.White;
            resources.ApplyResources(uiLabel2, "uiLabel2");
            uiLabel2.ForeColor = Color.Navy;
            uiLabel2.Name = "uiLabel2";
            // 
            // pnlThaoTac
            // 
            pnlThaoTac.BackColor = Color.FromArgb(245, 245, 250);
            pnlThaoTac.Controls.Add(btnCreateExam);
            pnlThaoTac.Controls.Add(uiLabel1);
            pnlThaoTac.FillColor = Color.White;
            pnlThaoTac.FillColor2 = Color.White;
            resources.ApplyResources(pnlThaoTac, "pnlThaoTac");
            pnlThaoTac.Name = "pnlThaoTac";
            pnlThaoTac.Radius = 15;
            pnlThaoTac.RectColor = Color.Black;
            pnlThaoTac.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCreateExam
            // 
            resources.ApplyResources(btnCreateExam, "btnCreateExam");
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Symbol = 61453;
            btnCreateExam.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.White;
            resources.ApplyResources(uiLabel1, "uiLabel1");
            uiLabel1.ForeColor = Color.Navy;
            uiLabel1.Name = "uiLabel1";
            // 
            // vSplitter
            // 
            vSplitter.Visible = false;
            resources.ApplyResources(vSplitter, "vSplitter");
            vSplitter.Name = "vSplitter";
            vSplitter.TabStop = false;
            // 
            // dgvQuestions
            // 
            dgvQuestions.Dock = DockStyle.Fill;
            dgvQuestions.BackgroundColor = Color.FromArgb(245, 245, 250);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowTemplate.Height = 25;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuestions.AllowUserToDeleteRows = true;
            dgvQuestions.AllowUserToAddRows = true;
            // 
            // pnlTopBar
            // 
            pnlTopBar = new Sunny.UI.UIPanel();
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.FillColor = Color.White;
            pnlTopBar.Height = 60;
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.RectSides = ToolStripStatusLabelBorderSides.None;
            // 
            // btnUploadFile
            // 
            btnUploadFile = new Sunny.UI.UIButton();
            btnUploadFile.Text = "Tải file lên";
            btnUploadFile.Location = new System.Drawing.Point(20, 10);
            btnUploadFile.Size = new System.Drawing.Size(120, 40);
            btnUploadFile.FillColor = Color.FromArgb(80, 160, 255);
            btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // lblUploadInfo
            // 
            lblUploadInfo = new Sunny.UI.UILabel();
            lblUploadInfo.Text = "Chưa có file nào";
            lblUploadInfo.Location = new System.Drawing.Point(150, 20);
            lblUploadInfo.Size = new System.Drawing.Size(200, 20);
            lblUploadInfo.AutoEllipsis = true;
            // 
            // btnGenerate
            // 
            btnGenerate = new Sunny.UI.UIButton();
            btnGenerate.Text = "Tạo câu hỏi với AI";
            btnGenerate.Location = new System.Drawing.Point(360, 10);
            btnGenerate.Size = new System.Drawing.Size(150, 40);
            btnGenerate.FillColor = Color.FromArgb(80, 160, 255);
            btnGenerate.Click += new System.EventHandler(this.btnGenerateAI_Click);
            // 
            // btnSaveDb
            // 
            btnSaveDb = new Sunny.UI.UIButton();
            btnSaveDb.Text = "Lưu Database";
            btnSaveDb.Location = new System.Drawing.Point(520, 10);
            btnSaveDb.Size = new System.Drawing.Size(120, 40);
            btnSaveDb.FillColor = Color.FromArgb(80, 160, 255);
            btnSaveDb.Click += new System.EventHandler(this.btnSaveDb_Click);
            // 
            // 
            pnlTopBar.Controls.Add(btnUploadFile);
            pnlTopBar.Controls.Add(lblUploadInfo);
            pnlTopBar.Controls.Add(btnGenerate);
            pnlTopBar.Controls.Add(btnSaveDb);
            // 
            // UC_AICreate
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dgvQuestions);
            Controls.Add(pnlTopBar);
            Name = "UC_AICreate";
            resources.ApplyResources(this, "$this");
            Load += UC_AICreate_Load;
            pnlLeft.ResumeLayout(false);
            pnlCauHinh.ResumeLayout(false);
            grpMucDo.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlPopup.ResumeLayout(false);
            pnlNguonDuLieu.ResumeLayout(false);
            tabSource.ResumeLayout(false);
            tpFile.ResumeLayout(false);
            tpText.ResumeLayout(false);
            pnlThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlLeft;
        private System.Windows.Forms.Splitter vSplitter;
        private Sunny.UI.UITabControl tabSource;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpText;
        private Sunny.UI.UISymbolButton btnSelectFile;
        private Sunny.UI.UILabel lblFileStatus;
        private Sunny.UI.UISymbolButton btnCreateExam;
        private Sunny.UI.UIPanel pnlNguonDuLieu;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIPanel pnlThaoTac;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel pnlCauHinh;
        private Sunny.UI.UILabel uiLabel3;

        #endregion

        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UIComboBox cbKhoi;
        private Sunny.UI.UIGroupBox grpMucDo;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
        private Sunny.UI.UILabel unit1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown2;
        private Sunny.UI.UILabel unit2;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown3;
        private Sunny.UI.UILabel unit3;
        private Sunny.UI.UILabel lblVDC;
        private Sunny.UI.UIIntegerUpDown numVDC;
        private Sunny.UI.UILabel unit4;
        private Sunny.UI.UIPanel pnlFooter;
        private Sunny.UI.UILabel lblTongSoCau;
        private Sunny.UI.UIPanel pnlPopup;
        private CheckedListBox clbChuong;
        private Sunny.UI.UIButton btnDone;
        private Sunny.UI.UITextBox txtSelectedChuong;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private Sunny.UI.UIPanel pnlTopBar;
        private Sunny.UI.UIButton btnGenerate;
        private Sunny.UI.UIButton btnSaveDb;
        private Sunny.UI.UIButton btnUploadFile;
        private Sunny.UI.UILabel lblUploadInfo;
    }
}
