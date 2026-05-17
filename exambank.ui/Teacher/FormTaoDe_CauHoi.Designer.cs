namespace exambank.ui
{
    partial class FormTaoDe_CauHoi
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
            lblInfo = new Sunny.UI.UILabel();
            grbCauHinh = new Sunny.UI.UIGroupBox();
            udtxtTG = new Sunny.UI.UIUpDownTextBox();
            pnlBtm.SuspendLayout();
            grbCauHinh.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.Location = new Point(1, 384);
            pnlBtm.Size = new Size(647, 55);
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
            btnCancel.Location = new Point(519, 12);
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
            btnOK.Location = new Point(404, 12);
            btnOK.Style = Sunny.UI.UIStyle.Custom;
            btnOK.Text = "Tạo";
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("Times New Roman", 12F);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.ImeMode = ImeMode.NoControl;
            uiLabel9.Location = new Point(26, 105);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(153, 36);
            uiLabel9.TabIndex = 7;
            uiLabel9.Text = "Mã đề thi:";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExamCode
            // 
            txtExamCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExamCode.BackColor = Color.Transparent;
            txtExamCode.Font = new Font("Times New Roman", 12F);
            txtExamCode.Location = new Point(189, 105);
            txtExamCode.Margin = new Padding(4, 5, 4, 5);
            txtExamCode.MinimumSize = new Size(1, 16);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Padding = new Padding(5);
            txtExamCode.RectColor = Color.DarkGray;
            txtExamCode.ShowText = false;
            txtExamCode.Size = new Size(393, 36);
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
            uiLabel1.Location = new Point(26, 51);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(153, 36);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "Tên đề thi:";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExamName
            // 
            txtExamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExamName.BackColor = Color.Transparent;
            txtExamName.Font = new Font("Times New Roman", 12F);
            txtExamName.Location = new Point(189, 51);
            txtExamName.Margin = new Padding(4, 5, 4, 5);
            txtExamName.MinimumSize = new Size(1, 16);
            txtExamName.Name = "txtExamName";
            txtExamName.Padding = new Padding(5);
            txtExamName.RectColor = Color.DarkGray;
            txtExamName.ShowText = false;
            txtExamName.Size = new Size(393, 36);
            txtExamName.TabIndex = 4;
            txtExamName.TextAlignment = ContentAlignment.MiddleLeft;
            txtExamName.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("Times New Roman", 12F);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.ImeMode = ImeMode.NoControl;
            uiLabel8.Location = new Point(26, 158);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(153, 36);
            uiLabel8.TabIndex = 17;
            uiLabel8.Text = "Thời gian (phút):";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.FromArgb(48, 48, 48);
            lblInfo.Location = new Point(25, 55);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(515, 29);
            lblInfo.TabIndex = 19;
            lblInfo.Text = "Số câu hỏi đã chọn: ";
            // 
            // grbCauHinh
            // 
            grbCauHinh.Controls.Add(udtxtTG);
            grbCauHinh.Controls.Add(uiLabel9);
            grbCauHinh.Controls.Add(txtExamCode);
            grbCauHinh.Controls.Add(uiLabel8);
            grbCauHinh.Controls.Add(uiLabel1);
            grbCauHinh.Controls.Add(txtExamName);
            grbCauHinh.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbCauHinh.Location = new Point(25, 103);
            grbCauHinh.Margin = new Padding(4, 5, 4, 5);
            grbCauHinh.MinimumSize = new Size(1, 1);
            grbCauHinh.Name = "grbCauHinh";
            grbCauHinh.Padding = new Padding(0, 32, 0, 0);
            grbCauHinh.RectColor = Color.Gray;
            grbCauHinh.Size = new Size(595, 242);
            grbCauHinh.TabIndex = 20;
            grbCauHinh.Text = "Thông tin đề thi";
            grbCauHinh.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // udtxtTG
            // 
            udtxtTG.DoubleStep = 1D;
            udtxtTG.DoubleValue = 15D;
            udtxtTG.FillColor2 = Color.FromArgb(24, 24, 24);
            udtxtTG.Font = new Font("Times New Roman", 12F);
            udtxtTG.IntValue = 15;
            udtxtTG.Location = new Point(189, 157);
            udtxtTG.Margin = new Padding(4, 5, 4, 5);
            udtxtTG.MinimumSize = new Size(1, 16);
            udtxtTG.Name = "udtxtTG";
            udtxtTG.Padding = new Padding(5);
            udtxtTG.RectColor = Color.DarkGray;
            udtxtTG.ShowText = false;
            udtxtTG.Size = new Size(145, 36);
            udtxtTG.Style = Sunny.UI.UIStyle.Custom;
            udtxtTG.TabIndex = 18;
            udtxtTG.Text = "15";
            udtxtTG.TextAlignment = ContentAlignment.MiddleRight;
            udtxtTG.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udtxtTG.Watermark = "";
            // 
            // FormTaoDe_CauHoi
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(649, 442);
            ControlBoxForeColor = Color.Black;
            Controls.Add(grbCauHinh);
            Controls.Add(lblInfo);
            Name = "FormTaoDe_CauHoi";
            RectColor = Color.Gray;
            Text = "Tạo đề thi từ câu hỏi đã chọn";
            TitleColor = SystemColors.ActiveCaption;
            TitleFont = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleForeColor = Color.Black;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Controls.SetChildIndex(lblInfo, 0);
            Controls.SetChildIndex(pnlBtm, 0);
            Controls.SetChildIndex(grbCauHinh, 0);
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
        private Sunny.UI.UILabel lblInfo;
        private Sunny.UI.UIGroupBox grbCauHinh;
        private Sunny.UI.UIUpDownTextBox udtxtTG;
    }
}