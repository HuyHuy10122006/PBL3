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
            btnCreateExam = new Sunny.UI.UISymbolButton();
            pnlCauHinh = new Sunny.UI.UIPanel();
            udtTG = new Sunny.UI.UIUpDownTextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            udtSL = new Sunny.UI.UIUpDownTextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            cbDoKho = new Sunny.UI.UIComboBox();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            cbMonHoc = new Sunny.UI.UIComboBox();
            cbKhoi = new Sunny.UI.UIComboBox();
            uiLabel3 = new Sunny.UI.UILabel();
            pnlNguonDuLieu = new Sunny.UI.UIPanel();
            tabSource = new Sunny.UI.UITabControl();
            tpFile = new TabPage();
            btnSelectFile = new Sunny.UI.UISymbolButton();
            txtFilePath = new Sunny.UI.UITextBox();
            tpText = new TabPage();
            txtText = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            flpPreview = new FlowLayoutPanel();
            pnlHeader = new Sunny.UI.UIPanel();
            lblExamInfo = new Sunny.UI.UILabel();
            lblResultTitle = new Sunny.UI.UILabel();
            btnSaveToBank = new Sunny.UI.UISymbolButton();
            pnlBody = new Sunny.UI.UIPanel();
            vSplitter = new Splitter();
            pnlLeft.SuspendLayout();
            pnlCauHinh.SuspendLayout();
            pnlNguonDuLieu.SuspendLayout();
            tabSource.SuspendLayout();
            tpFile.SuspendLayout();
            tpText.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(btnCreateExam);
            pnlLeft.Controls.Add(pnlCauHinh);
            pnlLeft.Controls.Add(pnlNguonDuLieu);
            resources.ApplyResources(pnlLeft, "pnlLeft");
            pnlLeft.FillColor = Color.FromArgb(245, 245, 250);
            pnlLeft.FillColor2 = Color.FromArgb(245, 245, 250);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Radius = 15;
            pnlLeft.RectSides = ToolStripStatusLabelBorderSides.None;
            pnlLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCreateExam
            // 
            btnCreateExam.FillColor = Color.FromArgb(110, 190, 40);
            btnCreateExam.FillColor2 = Color.FromArgb(110, 190, 40);
            btnCreateExam.FillHoverColor = Color.FromArgb(139, 203, 83);
            btnCreateExam.FillPressColor = Color.FromArgb(88, 152, 32);
            btnCreateExam.FillSelectedColor = Color.FromArgb(88, 152, 32);
            resources.ApplyResources(btnCreateExam, "btnCreateExam");
            btnCreateExam.LightColor = Color.FromArgb(245, 251, 241);
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Radius = 10;
            btnCreateExam.RectColor = Color.FromArgb(110, 190, 40);
            btnCreateExam.RectHoverColor = Color.FromArgb(139, 203, 83);
            btnCreateExam.RectPressColor = Color.FromArgb(88, 152, 32);
            btnCreateExam.RectSelectedColor = Color.FromArgb(88, 152, 32);
            btnCreateExam.Style = Sunny.UI.UIStyle.Custom;
            btnCreateExam.SymbolSize = 26;
            btnCreateExam.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCreateExam.Click += btnCreateExam_Click;
            // 
            // pnlCauHinh
            // 
            pnlCauHinh.BackColor = Color.White;
            pnlCauHinh.Controls.Add(udtTG);
            pnlCauHinh.Controls.Add(uiLabel8);
            pnlCauHinh.Controls.Add(udtSL);
            pnlCauHinh.Controls.Add(uiLabel7);
            pnlCauHinh.Controls.Add(uiLabel6);
            pnlCauHinh.Controls.Add(cbDoKho);
            pnlCauHinh.Controls.Add(uiLabel5);
            pnlCauHinh.Controls.Add(uiLabel4);
            pnlCauHinh.Controls.Add(cbMonHoc);
            pnlCauHinh.Controls.Add(cbKhoi);
            pnlCauHinh.Controls.Add(uiLabel3);
            pnlCauHinh.FillColor = Color.White;
            pnlCauHinh.FillColor2 = Color.White;
            resources.ApplyResources(pnlCauHinh, "pnlCauHinh");
            pnlCauHinh.Name = "pnlCauHinh";
            pnlCauHinh.Radius = 15;
            pnlCauHinh.RectColor = Color.Black;
            pnlCauHinh.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // udtTG
            // 
            udtTG.DoubleStep = 1D;
            resources.ApplyResources(udtTG, "udtTG");
            udtTG.Name = "udtTG";
            udtTG.ShowText = false;
            udtTG.TextAlignment = ContentAlignment.MiddleRight;
            udtTG.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtTG.Watermark = "";
            // 
            // uiLabel8
            // 
            resources.ApplyResources(uiLabel8, "uiLabel8");
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Name = "uiLabel8";
            // 
            // udtSL
            // 
            udtSL.DoubleStep = 1D;
            resources.ApplyResources(udtSL, "udtSL");
            udtSL.Name = "udtSL";
            udtSL.ShowText = false;
            udtSL.TextAlignment = ContentAlignment.MiddleRight;
            udtSL.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtSL.Watermark = "";
            // 
            // uiLabel7
            // 
            resources.ApplyResources(uiLabel7, "uiLabel7");
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Name = "uiLabel7";
            // 
            // uiLabel6
            // 
            resources.ApplyResources(uiLabel6, "uiLabel6");
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Name = "uiLabel6";
            // 
            // cbDoKho
            // 
            cbDoKho.DataSource = null;
            cbDoKho.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbDoKho.FillColor = Color.White;
            resources.ApplyResources(cbDoKho, "cbDoKho");
            cbDoKho.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbDoKho.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbDoKho.Name = "cbDoKho";
            cbDoKho.SymbolSize = 24;
            cbDoKho.TextAlignment = ContentAlignment.MiddleLeft;
            cbDoKho.Watermark = "Chọn độ khó...";
            // 
            // uiLabel5
            // 
            resources.ApplyResources(uiLabel5, "uiLabel5");
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Name = "uiLabel5";
            // 
            // uiLabel4
            // 
            resources.ApplyResources(uiLabel4, "uiLabel4");
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Name = "uiLabel4";
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
            // cbKhoi
            // 
            cbKhoi.DataSource = null;
            cbKhoi.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
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
            tabSource.TipsFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // tpFile
            // 
            tpFile.BackColor = Color.White;
            tpFile.Controls.Add(btnSelectFile);
            tpFile.Controls.Add(txtFilePath);
            resources.ApplyResources(tpFile, "tpFile");
            tpFile.Name = "tpFile";
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(btnSelectFile, "btnSelectFile");
            btnSelectFile.LightColor = Color.FromArgb(24, 24, 24);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Radius = 10;
            btnSelectFile.Style = Sunny.UI.UIStyle.Custom;
            btnSelectFile.Symbol = 61717;
            btnSelectFile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            resources.ApplyResources(txtFilePath, "txtFilePath");
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.ShowText = false;
            txtFilePath.TextAlignment = ContentAlignment.MiddleCenter;
            txtFilePath.Watermark = "Đường dẫn tài liệu...";
            // 
            // tpText
            // 
            tpText.BackColor = Color.White;
            tpText.Controls.Add(txtText);
            resources.ApplyResources(tpText, "tpText");
            tpText.Name = "tpText";
            // 
            // txtText
            // 
            txtText.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtText.ButtonStyleInherited = false;
            resources.ApplyResources(txtText, "txtText");
            txtText.FillColor2 = Color.FromArgb(24, 24, 24);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.RectColor = Color.DarkGray;
            txtText.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtText.ScrollBarStyleInherited = false;
            txtText.ShowScrollBar = true;
            txtText.ShowText = false;
            txtText.Style = Sunny.UI.UIStyle.Custom;
            txtText.TextAlignment = ContentAlignment.MiddleLeft;
            txtText.Watermark = "Nhập văn bản vào đây...";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.White;
            resources.ApplyResources(uiLabel2, "uiLabel2");
            uiLabel2.ForeColor = Color.Navy;
            uiLabel2.Name = "uiLabel2";
            // 
            // flpPreview
            // 
            resources.ApplyResources(flpPreview, "flpPreview");
            flpPreview.BackColor = Color.WhiteSmoke;
            flpPreview.Name = "flpPreview";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblExamInfo);
            pnlHeader.Controls.Add(lblResultTitle);
            pnlHeader.Controls.Add(btnSaveToBank);
            resources.ApplyResources(pnlHeader, "pnlHeader");
            pnlHeader.FillColor = Color.MidnightBlue;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblExamInfo
            // 
            lblExamInfo.BackColor = Color.MidnightBlue;
            resources.ApplyResources(lblExamInfo, "lblExamInfo");
            lblExamInfo.ForeColor = Color.WhiteSmoke;
            lblExamInfo.Name = "lblExamInfo";
            // 
            // lblResultTitle
            // 
            lblResultTitle.BackColor = Color.MidnightBlue;
            resources.ApplyResources(lblResultTitle, "lblResultTitle");
            lblResultTitle.ForeColor = Color.WhiteSmoke;
            lblResultTitle.Name = "lblResultTitle";
            // 
            // btnSaveToBank
            // 
            resources.ApplyResources(btnSaveToBank, "btnSaveToBank");
            btnSaveToBank.BackColor = Color.MediumBlue;
            btnSaveToBank.FillColor = Color.Gainsboro;
            btnSaveToBank.FillColor2 = Color.Gainsboro;
            btnSaveToBank.ForeColor = Color.Black;
            btnSaveToBank.ForeDisableColor = Color.Black;
            btnSaveToBank.ForeHoverColor = Color.Black;
            btnSaveToBank.ForePressColor = Color.Black;
            btnSaveToBank.ForeSelectedColor = Color.Black;
            btnSaveToBank.Name = "btnSaveToBank";
            btnSaveToBank.Radius = 10;
            btnSaveToBank.Style = Sunny.UI.UIStyle.Custom;
            btnSaveToBank.Symbol = 61639;
            btnSaveToBank.SymbolColor = Color.Black;
            btnSaveToBank.SymbolHoverColor = Color.Black;
            btnSaveToBank.SymbolPressColor = Color.Black;
            btnSaveToBank.SymbolSelectedColor = Color.Black;
            btnSaveToBank.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(flpPreview);
            resources.ApplyResources(pnlBody, "pnlBody");
            pnlBody.Name = "pnlBody";
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // vSplitter
            // 
            resources.ApplyResources(vSplitter, "vSplitter");
            vSplitter.Name = "vSplitter";
            vSplitter.TabStop = false;
            // 
            // UC_AICreate
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(vSplitter);
            Controls.Add(pnlLeft);
            Name = "UC_AICreate";
            resources.ApplyResources(this, "$this");
            Load += UC_AICreate_Load;
            pnlLeft.ResumeLayout(false);
            pnlCauHinh.ResumeLayout(false);
            pnlNguonDuLieu.ResumeLayout(false);
            tabSource.ResumeLayout(false);
            tpFile.ResumeLayout(false);
            tpText.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UITabControl tabSource;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpText;
        private Sunny.UI.UISymbolButton btnSelectFile;
        private Sunny.UI.UISymbolButton btnCreateExam;
        private Sunny.UI.UIPanel pnlNguonDuLieu;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIPanel pnlCauHinh;
        private Sunny.UI.UILabel uiLabel3;

        #endregion

        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UIComboBox cbKhoi;
        private Sunny.UI.UITextBox txtText;
        private FlowLayoutPanel flpPreview;
        private Sunny.UI.UITextBox txtFilePath;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cbDoKho;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIUpDownTextBox udtSL;
        private Sunny.UI.UIUpDownTextBox udtTG;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UILabel lblExamInfo;
        private Sunny.UI.UILabel lblResultTitle;
        private Sunny.UI.UISymbolButton btnSaveToBank;
        private Splitter vSplitter;
    }
}
