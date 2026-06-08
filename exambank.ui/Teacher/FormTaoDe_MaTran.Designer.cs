namespace exambank.ui
{
    partial class FormTaoDe_MaTran
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
            uiLabel9 = new Sunny.UI.UILabel();
            txtExamCode = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            txtExamName = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            grbCauHinh = new Sunny.UI.UIGroupBox();
            udtxtTime = new Sunny.UI.UIUpDownTextBox();
            udtxtCountQuestion = new Sunny.UI.UIUpDownTextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            cbMonHoc = new Sunny.UI.UIComboBox();
            lblKhoi = new Sunny.UI.UILabel();
            cbKhoi = new Sunny.UI.UIComboBox();
            uiLabel7 = new Sunny.UI.UILabel();
            pnlBtm.SuspendLayout();
            grbCauHinh.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.Location = new Point(1, 349);
            pnlBtm.Size = new Size(669, 55);
            // 
            // btnCancel
            // 
            btnCancel.FillColor = Color.FromArgb(192, 0, 0);
            btnCancel.FillColor2 = Color.FromArgb(192, 0, 0);
            btnCancel.FillHoverColor = Color.FromArgb(235, 115, 115);
            btnCancel.FillPressColor = Color.FromArgb(184, 64, 64);
            btnCancel.FillSelectedColor = Color.FromArgb(184, 64, 64);
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.LightColor = Color.FromArgb(253, 243, 243);
            btnCancel.Location = new Point(541, 12);
            btnCancel.RectColor = Color.FromArgb(230, 80, 80);
            btnCancel.RectHoverColor = Color.FromArgb(235, 115, 115);
            btnCancel.RectPressColor = Color.FromArgb(184, 64, 64);
            btnCancel.RectSelectedColor = Color.FromArgb(184, 64, 64);
            btnCancel.Style = Sunny.UI.UIStyle.Custom;
            btnCancel.Text = "Hủy";
            // 
            // btnOK
            // 
            btnOK.FillColor = Color.FromArgb(0, 0, 192);
            btnOK.FillColor2 = Color.FromArgb(0, 0, 192);
            btnOK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(426, 12);
            btnOK.Style = Sunny.UI.UIStyle.Custom;
            btnOK.Text = "Tạo";
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("Times New Roman", 12F);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.ImeMode = ImeMode.NoControl;
            uiLabel9.Location = new Point(20, 86);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(141, 36);
            uiLabel9.TabIndex = 7;
            uiLabel9.Text = "Mã đề thi:";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExamCode
            // 
            txtExamCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExamCode.BackColor = Color.Transparent;
            txtExamCode.Font = new Font("Times New Roman", 12F);
            txtExamCode.Location = new Point(168, 86);
            txtExamCode.Margin = new Padding(4, 5, 4, 5);
            txtExamCode.MinimumSize = new Size(1, 16);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Padding = new Padding(5);
            txtExamCode.RectColor = Color.DarkGray;
            txtExamCode.ShowText = false;
            txtExamCode.Size = new Size(402, 36);
            txtExamCode.TabIndex = 6;
            txtExamCode.TextAlignment = ContentAlignment.MiddleLeft;
            txtExamCode.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Times New Roman", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.ImeMode = ImeMode.NoControl;
            uiLabel1.Location = new Point(20, 41);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(141, 36);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "Tên đề thi:";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExamName
            // 
            txtExamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExamName.BackColor = Color.Transparent;
            txtExamName.Font = new Font("Times New Roman", 12F);
            txtExamName.Location = new Point(168, 41);
            txtExamName.Margin = new Padding(4, 5, 4, 5);
            txtExamName.MinimumSize = new Size(1, 16);
            txtExamName.Name = "txtExamName";
            txtExamName.Padding = new Padding(5);
            txtExamName.RectColor = Color.DarkGray;
            txtExamName.ShowText = false;
            txtExamName.Size = new Size(402, 36);
            txtExamName.TabIndex = 4;
            txtExamName.TextAlignment = ContentAlignment.MiddleLeft;
            txtExamName.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("Times New Roman", 12F);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.ImeMode = ImeMode.NoControl;
            uiLabel8.Location = new Point(20, 134);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(153, 36);
            uiLabel8.TabIndex = 17;
            uiLabel8.Text = "Thời gian (phút):";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grbCauHinh
            // 
            grbCauHinh.Controls.Add(udtxtTime);
            grbCauHinh.Controls.Add(udtxtCountQuestion);
            grbCauHinh.Controls.Add(uiLabel5);
            grbCauHinh.Controls.Add(cbMonHoc);
            grbCauHinh.Controls.Add(lblKhoi);
            grbCauHinh.Controls.Add(cbKhoi);
            grbCauHinh.Controls.Add(uiLabel9);
            grbCauHinh.Controls.Add(txtExamCode);
            grbCauHinh.Controls.Add(uiLabel8);
            grbCauHinh.Controls.Add(uiLabel7);
            grbCauHinh.Controls.Add(uiLabel1);
            grbCauHinh.Controls.Add(txtExamName);
            grbCauHinh.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbCauHinh.Location = new Point(25, 65);
            grbCauHinh.Margin = new Padding(4, 5, 4, 5);
            grbCauHinh.MinimumSize = new Size(1, 1);
            grbCauHinh.Name = "grbCauHinh";
            grbCauHinh.Padding = new Padding(0, 32, 0, 0);
            grbCauHinh.RectColor = Color.Gray;
            grbCauHinh.Size = new Size(595, 240);
            grbCauHinh.TabIndex = 20;
            grbCauHinh.Text = "Ma trận đề thi";
            grbCauHinh.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // udtxtTime
            // 
            udtxtTime.DoubleStep = 1D;
            udtxtTime.DoubleValue = 15D;
            udtxtTime.FillColor2 = Color.FromArgb(24, 24, 24);
            udtxtTime.Font = new Font("Times New Roman", 12F);
            udtxtTime.IntValue = 15;
            udtxtTime.Location = new Point(168, 133);
            udtxtTime.Margin = new Padding(4, 5, 4, 5);
            udtxtTime.MinimumSize = new Size(1, 16);
            udtxtTime.Name = "udtxtTime";
            udtxtTime.Padding = new Padding(5);
            udtxtTime.RectColor = Color.DarkGray;
            udtxtTime.ShowText = false;
            udtxtTime.Size = new Size(130, 36);
            udtxtTime.Style = Sunny.UI.UIStyle.Custom;
            udtxtTime.TabIndex = 18;
            udtxtTime.Text = "15";
            udtxtTime.TextAlignment = ContentAlignment.MiddleRight;
            udtxtTime.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtxtTime.Watermark = "";
            // 
            // udtxtCountQuestion
            // 
            udtxtCountQuestion.DoubleStep = 1D;
            udtxtCountQuestion.FillColor2 = Color.FromArgb(24, 24, 24);
            udtxtCountQuestion.Font = new Font("Microsoft Sans Serif", 12F);
            udtxtCountQuestion.Location = new Point(440, 134);
            udtxtCountQuestion.Margin = new Padding(4, 5, 4, 5);
            udtxtCountQuestion.MinimumSize = new Size(1, 16);
            udtxtCountQuestion.Name = "udtxtCountQuestion";
            udtxtCountQuestion.Padding = new Padding(5);
            udtxtCountQuestion.RectColor = Color.FromArgb(18, 58, 92);
            udtxtCountQuestion.ShowText = false;
            udtxtCountQuestion.Size = new Size(130, 36);
            udtxtCountQuestion.Style = Sunny.UI.UIStyle.Custom;
            udtxtCountQuestion.TabIndex = 19;
            udtxtCountQuestion.Text = "0";
            udtxtCountQuestion.TextAlignment = ContentAlignment.MiddleRight;
            udtxtCountQuestion.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtxtCountQuestion.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Times New Roman", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.ImeMode = ImeMode.NoControl;
            uiLabel5.Location = new Point(20, 181);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(85, 35);
            uiLabel5.TabIndex = 23;
            uiLabel5.Text = "Môn học:";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMonHoc
            // 
            cbMonHoc.DataSource = null;
            cbMonHoc.FillColor = Color.White;
            cbMonHoc.FillColor2 = Color.FromArgb(24, 24, 24);
            cbMonHoc.Font = new Font("Times New Roman", 10.8F);
            cbMonHoc.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMonHoc.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMonHoc.Location = new Point(168, 181);
            cbMonHoc.Margin = new Padding(4, 5, 4, 5);
            cbMonHoc.MinimumSize = new Size(63, 0);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Padding = new Padding(0, 0, 30, 2);
            cbMonHoc.RectColor = Color.FromArgb(18, 58, 92);
            cbMonHoc.Size = new Size(130, 35);
            cbMonHoc.Style = Sunny.UI.UIStyle.Custom;
            cbMonHoc.SymbolSize = 24;
            cbMonHoc.TabIndex = 20;
            cbMonHoc.TextAlignment = ContentAlignment.MiddleLeft;
            cbMonHoc.Watermark = "Chọn môn...";
            // 
            // lblKhoi
            // 
            lblKhoi.Font = new Font("Times New Roman", 12F);
            lblKhoi.ForeColor = Color.FromArgb(48, 48, 48);
            lblKhoi.Location = new Point(320, 181);
            lblKhoi.Name = "lblKhoi";
            lblKhoi.Size = new Size(110, 35);
            lblKhoi.TabIndex = 24;
            lblKhoi.Text = "Khối lớp:";
            lblKhoi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbKhoi
            // 
            cbKhoi.DataSource = null;
            cbKhoi.FillColor = Color.White;
            cbKhoi.Font = new Font("Times New Roman", 10.8F);
            cbKhoi.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbKhoi.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbKhoi.Location = new Point(440, 181);
            cbKhoi.Margin = new Padding(4, 5, 4, 5);
            cbKhoi.MinimumSize = new Size(63, 0);
            cbKhoi.Name = "cbKhoi";
            cbKhoi.Padding = new Padding(0, 0, 30, 2);
            cbKhoi.RectColor = Color.FromArgb(18, 58, 92);
            cbKhoi.Size = new Size(130, 35);
            cbKhoi.Style = Sunny.UI.UIStyle.Custom;
            cbKhoi.SymbolSize = 24;
            cbKhoi.TabIndex = 21;
            cbKhoi.TextAlignment = ContentAlignment.MiddleLeft;
            cbKhoi.Watermark = "Chọn khối...";
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("Times New Roman", 12F);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.ImeMode = ImeMode.NoControl;
            uiLabel7.Location = new Point(346, 135);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(85, 35);
            uiLabel7.TabIndex = 26;
            uiLabel7.Text = "Số câu:";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormTaoDe_MaTran
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(671, 407);
            ControlBoxForeColor = Color.Black;
            Controls.Add(grbCauHinh);
            Name = "FormTaoDe_MaTran";
            RectColor = Color.Gray;
            Text = "Tạo đề thi theo ma trận từ ngân hàng câu hỏi";
            TitleColor = SystemColors.ActiveCaption;
            TitleFont = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleForeColor = Color.Black;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Controls.SetChildIndex(grbCauHinh, 0);
            Controls.SetChildIndex(pnlBtm, 0);
            pnlBtm.ResumeLayout(false);
            grbCauHinh.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtExamCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtExamName;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIGroupBox grbCauHinh;
        private Sunny.UI.UIUpDownTextBox udtxtTime;
        private Sunny.UI.UIUpDownTextBox udtxtCountQuestion;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UILabel lblKhoi;
        private Sunny.UI.UIComboBox cbKhoi;
        private Sunny.UI.UILabel uiLabel7;
    }
}