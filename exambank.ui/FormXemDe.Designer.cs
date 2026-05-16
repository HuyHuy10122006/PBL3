namespace exambank.ui
{
    partial class FormXemDe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpQuestions = new FlowLayoutPanel();
            pnlHeader = new Sunny.UI.UIPanel();
            udtTime = new Sunny.UI.UIUpDownTextBox();
            lblTotalQuestions = new Sunny.UI.UILabel();
            lblTime = new Sunny.UI.UILabel();
            cbMonHoc = new Sunny.UI.UIComboBox();
            lblMonHoc = new Sunny.UI.UILabel();
            txtExamCode = new Sunny.UI.UITextBox();
            lblExamCode = new Sunny.UI.UILabel();
            txtTitle = new Sunny.UI.UITextBox();
            pnlActions = new Sunny.UI.UIPanel();
            btnSave = new Sunny.UI.UISymbolButton();
            btnShare = new Sunny.UI.UISymbolButton();
            btnExport = new Sunny.UI.UISymbolButton();
            btnEdit = new Sunny.UI.UISymbolButton();
            btnClose = new Sunny.UI.UISymbolButton();
            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // flpQuestions
            // 
            flpQuestions.AutoScroll = true;
            flpQuestions.Dock = DockStyle.Fill;
            flpQuestions.FlowDirection = FlowDirection.TopDown;
            flpQuestions.Location = new Point(0, 184);
            flpQuestions.Name = "flpQuestions";
            flpQuestions.Size = new Size(1061, 645);
            flpQuestions.TabIndex = 0;
            flpQuestions.WrapContents = false;
            flpQuestions.SizeChanged += flpQuestions_SizeChanged;
            flpQuestions.ControlAdded += UpdateUCCount;
            flpQuestions.ControlRemoved += UpdateUCCount;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(udtTime);
            pnlHeader.Controls.Add(lblTotalQuestions);
            pnlHeader.Controls.Add(lblTime);
            pnlHeader.Controls.Add(cbMonHoc);
            pnlHeader.Controls.Add(lblMonHoc);
            pnlHeader.Controls.Add(txtExamCode);
            pnlHeader.Controls.Add(lblExamCode);
            pnlHeader.Controls.Add(txtTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.White;
            pnlHeader.FillColor2 = Color.White;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 35);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.RectColor = Color.Gray;
            pnlHeader.Size = new Size(1061, 149);
            pnlHeader.TabIndex = 1;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // udtTime
            // 
            udtTime.BackColor = Color.Transparent;
            udtTime.DoubleStep = 1D;
            udtTime.DoubleValue = 10D;
            udtTime.FillColor2 = Color.FromArgb(24, 24, 24);
            udtTime.Font = new Font("Times New Roman", 12F);
            udtTime.IntValue = 10;
            udtTime.Location = new Point(183, 103);
            udtTime.Margin = new Padding(4, 5, 4, 5);
            udtTime.MinimumSize = new Size(1, 16);
            udtTime.Name = "udtTime";
            udtTime.Padding = new Padding(5);
            udtTime.RectColor = Color.Silver;
            udtTime.ShowText = false;
            udtTime.Size = new Size(158, 36);
            udtTime.Style = Sunny.UI.UIStyle.Custom;
            udtTime.TabIndex = 3;
            udtTime.Text = "10";
            udtTime.TextAlignment = ContentAlignment.MiddleRight;
            udtTime.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtTime.Visible = false;
            udtTime.Watermark = "";
            // 
            // lblTotalQuestions
            // 
            lblTotalQuestions.BackColor = Color.Transparent;
            lblTotalQuestions.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalQuestions.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotalQuestions.Location = new Point(429, 103);
            lblTotalQuestions.Name = "lblTotalQuestions";
            lblTotalQuestions.Size = new Size(245, 36);
            lblTotalQuestions.TabIndex = 8;
            lblTotalQuestions.Text = "Tổng số câu hỏi: ";
            lblTotalQuestions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.FromArgb(48, 48, 48);
            lblTime.Location = new Point(31, 103);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(310, 36);
            lblTime.TabIndex = 7;
            lblTime.Text = "Thời gian làm bài:";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMonHoc
            // 
            cbMonHoc.BackColor = Color.Transparent;
            cbMonHoc.DataSource = null;
            cbMonHoc.FillColor = Color.White;
            cbMonHoc.FillColor2 = Color.FromArgb(24, 24, 24);
            cbMonHoc.Font = new Font("Times New Roman", 12F);
            cbMonHoc.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMonHoc.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMonHoc.Location = new Point(509, 57);
            cbMonHoc.Margin = new Padding(4, 5, 4, 5);
            cbMonHoc.MinimumSize = new Size(63, 0);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Padding = new Padding(0, 0, 30, 2);
            cbMonHoc.RectColor = Color.Silver;
            cbMonHoc.Size = new Size(165, 36);
            cbMonHoc.Style = Sunny.UI.UIStyle.Custom;
            cbMonHoc.SymbolSize = 24;
            cbMonHoc.TabIndex = 4;
            cbMonHoc.Text = "cb Môn học";
            cbMonHoc.TextAlignment = ContentAlignment.MiddleLeft;
            cbMonHoc.Visible = false;
            cbMonHoc.Watermark = "";
            // 
            // lblMonHoc
            // 
            lblMonHoc.BackColor = Color.Transparent;
            lblMonHoc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonHoc.ForeColor = Color.FromArgb(48, 48, 48);
            lblMonHoc.Location = new Point(429, 57);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(245, 36);
            lblMonHoc.TabIndex = 6;
            lblMonHoc.Text = "Môn học:";
            lblMonHoc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExamCode
            // 
            txtExamCode.BackColor = Color.Transparent;
            txtExamCode.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtExamCode.ButtonStyleInherited = false;
            txtExamCode.FillColor2 = Color.FromArgb(24, 24, 24);
            txtExamCode.Font = new Font("Times New Roman", 12F);
            txtExamCode.Location = new Point(93, 57);
            txtExamCode.Margin = new Padding(4, 5, 4, 5);
            txtExamCode.MinimumSize = new Size(1, 16);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Padding = new Padding(5);
            txtExamCode.RectColor = Color.Silver;
            txtExamCode.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtExamCode.ScrollBarStyleInherited = false;
            txtExamCode.ShowText = false;
            txtExamCode.Size = new Size(248, 36);
            txtExamCode.Style = Sunny.UI.UIStyle.Custom;
            txtExamCode.TabIndex = 1;
            txtExamCode.Text = "txt Mã đề";
            txtExamCode.TextAlignment = ContentAlignment.MiddleLeft;
            txtExamCode.Visible = false;
            txtExamCode.Watermark = "";
            // 
            // lblExamCode
            // 
            lblExamCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExamCode.BackColor = Color.Transparent;
            lblExamCode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExamCode.ForeColor = Color.FromArgb(48, 48, 48);
            lblExamCode.Location = new Point(31, 57);
            lblExamCode.Name = "lblExamCode";
            lblExamCode.Size = new Size(310, 36);
            lblExamCode.TabIndex = 5;
            lblExamCode.Text = "Mã đề:";
            lblExamCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Transparent;
            txtTitle.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtTitle.ButtonStyleInherited = false;
            txtTitle.FillColor2 = Color.FromArgb(24, 24, 24);
            txtTitle.FillReadOnlyColor = Color.White;
            txtTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(22, 5);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.ReadOnly = true;
            txtTitle.RectColor = Color.Silver;
            txtTitle.RectReadOnlyColor = Color.White;
            txtTitle.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtTitle.ScrollBarStyleInherited = false;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(1011, 42);
            txtTitle.Style = Sunny.UI.UIStyle.Custom;
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Tên đề";
            txtTitle.TextAlignment = ContentAlignment.MiddleCenter;
            txtTitle.Watermark = "";
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnSave);
            pnlActions.Controls.Add(btnShare);
            pnlActions.Controls.Add(btnExport);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnClose);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.FillColor = Color.White;
            pnlActions.FillColor2 = Color.White;
            pnlActions.Font = new Font("Microsoft Sans Serif", 12F);
            pnlActions.Location = new Point(0, 829);
            pnlActions.Margin = new Padding(4, 5, 4, 5);
            pnlActions.MinimumSize = new Size(1, 1);
            pnlActions.Name = "pnlActions";
            pnlActions.RectColor = Color.Gray;
            pnlActions.Size = new Size(1061, 58);
            pnlActions.TabIndex = 0;
            pnlActions.Text = null;
            pnlActions.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.FillColor = Color.FromArgb(0, 0, 192);
            btnSave.FillColor2 = Color.FromArgb(0, 0, 192);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(770, 12);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 35);
            btnSave.Style = Sunny.UI.UIStyle.Custom;
            btnSave.Symbol = 61639;
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnShare
            // 
            btnShare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShare.BackColor = Color.Transparent;
            btnShare.FillColor = Color.FromArgb(0, 0, 192);
            btnShare.FillColor2 = Color.FromArgb(0, 0, 192);
            btnShare.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShare.Location = new Point(106, 12);
            btnShare.MinimumSize = new Size(1, 1);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(190, 35);
            btnShare.Style = Sunny.UI.UIStyle.Custom;
            btnShare.Symbol = 61540;
            btnShare.TabIndex = 3;
            btnShare.Text = "Chia sẻ";
            btnShare.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnShare.Click += btnShare_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.Transparent;
            btnExport.FillColor = Color.FromArgb(0, 0, 192);
            btnExport.FillColor2 = Color.FromArgb(0, 0, 192);
            btnExport.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(327, 12);
            btnExport.MinimumSize = new Size(1, 1);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(190, 35);
            btnExport.Style = Sunny.UI.UIStyle.Custom;
            btnExport.Symbol = 362830;
            btnExport.TabIndex = 2;
            btnExport.Text = "Xuất file word";
            btnExport.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnExport.Click += btnExport_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.FillColor = Color.FromArgb(0, 0, 192);
            btnEdit.FillColor2 = Color.FromArgb(0, 0, 192);
            btnEdit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(546, 12);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(190, 35);
            btnEdit.Style = Sunny.UI.UIStyle.Custom;
            btnEdit.Symbol = 61508;
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FillColor = Color.FromArgb(192, 0, 0);
            btnClose.FillColor2 = Color.FromArgb(192, 0, 0);
            btnClose.FillHoverColor = Color.FromArgb(235, 115, 115);
            btnClose.FillPressColor = Color.FromArgb(184, 64, 64);
            btnClose.FillSelectedColor = Color.FromArgb(184, 64, 64);
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.LightColor = Color.FromArgb(253, 243, 243);
            btnClose.Location = new Point(921, 12);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = Color.FromArgb(230, 80, 80);
            btnClose.RectHoverColor = Color.FromArgb(235, 115, 115);
            btnClose.RectPressColor = Color.FromArgb(184, 64, 64);
            btnClose.RectSelectedColor = Color.FromArgb(184, 64, 64);
            btnClose.Size = new Size(125, 35);
            btnClose.Style = Sunny.UI.UIStyle.Custom;
            btnClose.Symbol = 361453;
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // FormXemDe
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1061, 887);
            ControlBoxForeColor = Color.Black;
            Controls.Add(flpQuestions);
            Controls.Add(pnlActions);
            Controls.Add(pnlHeader);
            Name = "FormXemDe";
            RectColor = Color.Black;
            Text = "Xem chi tiết đề thi";
            TitleColor = SystemColors.ActiveCaption;
            TitleFont = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleForeColor = Color.Black;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FormXemDe_Load;
            pnlHeader.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpQuestions;
        private Sunny.UI.UIPanel pnlActions;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UIUpDownTextBox udtTime;
        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UILabel lblExamCode;
        private Sunny.UI.UILabel lblTotalQuestions;
        private Sunny.UI.UILabel lblTime;
        private Sunny.UI.UILabel lblMonHoc;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnShare;
        private Sunny.UI.UISymbolButton btnExport;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UITextBox txtExamCode;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UISymbolButton btnSave;
    }
}