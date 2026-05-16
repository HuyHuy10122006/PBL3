namespace exambank.ui
{
    partial class UC_Question
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
            pnlCard = new Sunny.UI.UIPanel();
            lblDoKho = new Sunny.UI.UILabel();
            cbDoKho = new Sunny.UI.UIComboBox();
            lblMonHoc = new Sunny.UI.UILabel();
            cbMonHoc = new Sunny.UI.UIComboBox();
            lblKhoi = new Sunny.UI.UILabel();
            cbKhoi = new Sunny.UI.UIComboBox();
            pnlHeader = new Sunny.UI.UIPanel();
            lblNumber = new Sunny.UI.UISymbolLabel();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnEdit = new Sunny.UI.UISymbolButton();
            txtContentDisplay = new Sunny.UI.UITextBox();
            flpOptions = new FlowLayoutPanel();
            txtAnsA = new Sunny.UI.UITextBox();
            txtAnsB = new Sunny.UI.UITextBox();
            txtAnsC = new Sunny.UI.UITextBox();
            txtAnsD = new Sunny.UI.UITextBox();
            pnlCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.Controls.Add(lblDoKho);
            pnlCard.Controls.Add(cbDoKho);
            pnlCard.Controls.Add(lblMonHoc);
            pnlCard.Controls.Add(cbMonHoc);
            pnlCard.Controls.Add(lblKhoi);
            pnlCard.Controls.Add(cbKhoi);
            pnlCard.Controls.Add(pnlHeader);
            pnlCard.Controls.Add(txtContentDisplay);
            pnlCard.Controls.Add(flpOptions);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.FillColor = Color.White;
            pnlCard.Font = new Font("Segoe UI", 12F);
            pnlCard.Location = new Point(15, 15);
            pnlCard.Margin = new Padding(10, 5, 10, 5);
            pnlCard.MinimumSize = new Size(1, 1);
            pnlCard.Name = "pnlCard";
            pnlCard.Radius = 12;
            pnlCard.RectColor = Color.DimGray;
            pnlCard.Size = new Size(834, 415);
            pnlCard.TabIndex = 0;
            pnlCard.Text = null;
            pnlCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblDoKho
            // 
            lblDoKho.Font = new Font("Times New Roman", 12F);
            lblDoKho.ForeColor = Color.FromArgb(48, 48, 48);
            lblDoKho.ImeMode = ImeMode.NoControl;
            lblDoKho.Location = new Point(15, 314);
            lblDoKho.Name = "lblDoKho";
            lblDoKho.Size = new Size(89, 35);
            lblDoKho.TabIndex = 31;
            lblDoKho.Text = "Độ khó:";
            lblDoKho.TextAlign = ContentAlignment.MiddleLeft;
            lblDoKho.Visible = false;
            // 
            // cbDoKho
            // 
            cbDoKho.DataSource = null;
            cbDoKho.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbDoKho.FillColor = Color.White;
            cbDoKho.FillColor2 = Color.FromArgb(24, 24, 24);
            cbDoKho.Font = new Font("Times New Roman", 10.8F);
            cbDoKho.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbDoKho.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbDoKho.Location = new Point(110, 314);
            cbDoKho.Margin = new Padding(4, 5, 4, 5);
            cbDoKho.MinimumSize = new Size(63, 0);
            cbDoKho.Name = "cbDoKho";
            cbDoKho.Padding = new Padding(0, 0, 30, 2);
            cbDoKho.ReadOnly = true;
            cbDoKho.RectColor = Color.FromArgb(18, 58, 92);
            cbDoKho.Size = new Size(151, 35);
            cbDoKho.Style = Sunny.UI.UIStyle.Custom;
            cbDoKho.SymbolSize = 24;
            cbDoKho.TabIndex = 30;
            cbDoKho.TextAlignment = ContentAlignment.MiddleLeft;
            cbDoKho.Visible = false;
            cbDoKho.Watermark = "Chọn độ khó...";
            // 
            // lblMonHoc
            // 
            lblMonHoc.Font = new Font("Times New Roman", 12F);
            lblMonHoc.ForeColor = Color.FromArgb(48, 48, 48);
            lblMonHoc.ImeMode = ImeMode.NoControl;
            lblMonHoc.Location = new Point(14, 361);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(90, 35);
            lblMonHoc.TabIndex = 29;
            lblMonHoc.Text = "Môn học:";
            lblMonHoc.TextAlign = ContentAlignment.MiddleLeft;
            lblMonHoc.Visible = false;
            // 
            // cbMonHoc
            // 
            cbMonHoc.DataSource = null;
            cbMonHoc.FillColor = Color.White;
            cbMonHoc.FillColor2 = Color.FromArgb(24, 24, 24);
            cbMonHoc.Font = new Font("Times New Roman", 10.8F);
            cbMonHoc.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMonHoc.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMonHoc.Location = new Point(110, 361);
            cbMonHoc.Margin = new Padding(4, 5, 4, 5);
            cbMonHoc.MinimumSize = new Size(63, 0);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Padding = new Padding(0, 0, 30, 2);
            cbMonHoc.ReadOnly = true;
            cbMonHoc.RectColor = Color.FromArgb(18, 58, 92);
            cbMonHoc.Size = new Size(151, 35);
            cbMonHoc.Style = Sunny.UI.UIStyle.Custom;
            cbMonHoc.SymbolSize = 24;
            cbMonHoc.TabIndex = 26;
            cbMonHoc.TextAlignment = ContentAlignment.MiddleLeft;
            cbMonHoc.Visible = false;
            cbMonHoc.Watermark = "Chọn môn...";
            // 
            // lblKhoi
            // 
            lblKhoi.Font = new Font("Times New Roman", 12F);
            lblKhoi.ForeColor = Color.FromArgb(48, 48, 48);
            lblKhoi.ImeMode = ImeMode.NoControl;
            lblKhoi.Location = new Point(14, 267);
            lblKhoi.Name = "lblKhoi";
            lblKhoi.Size = new Size(88, 35);
            lblKhoi.TabIndex = 28;
            lblKhoi.Text = "Khối lớp:";
            lblKhoi.TextAlign = ContentAlignment.MiddleLeft;
            lblKhoi.Visible = false;
            // 
            // cbKhoi
            // 
            cbKhoi.DataSource = null;
            cbKhoi.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbKhoi.FillColor = Color.White;
            cbKhoi.FillColor2 = Color.FromArgb(24, 24, 24);
            cbKhoi.Font = new Font("Times New Roman", 10.8F);
            cbKhoi.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbKhoi.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbKhoi.Location = new Point(109, 267);
            cbKhoi.Margin = new Padding(4, 5, 4, 5);
            cbKhoi.MinimumSize = new Size(63, 0);
            cbKhoi.Name = "cbKhoi";
            cbKhoi.Padding = new Padding(0, 0, 30, 2);
            cbKhoi.ReadOnly = true;
            cbKhoi.RectColor = Color.FromArgb(18, 58, 92);
            cbKhoi.Size = new Size(152, 35);
            cbKhoi.Style = Sunny.UI.UIStyle.Custom;
            cbKhoi.SymbolSize = 24;
            cbKhoi.TabIndex = 27;
            cbKhoi.TextAlignment = ContentAlignment.MiddleLeft;
            cbKhoi.Visible = false;
            cbKhoi.Watermark = "Chọn khối...";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblNumber);
            pnlHeader.Controls.Add(btnDelete);
            pnlHeader.Controls.Add(btnEdit);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.Gainsboro;
            pnlHeader.FillColor2 = Color.CornflowerBlue;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 12;
            pnlHeader.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            pnlHeader.RectColor = Color.Gray;
            pnlHeader.RectSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right;
            pnlHeader.Size = new Size(834, 41);
            pnlHeader.TabIndex = 4;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = Color.FromArgb(64, 64, 64);
            lblNumber.Location = new Point(3, 5);
            lblNumber.MinimumSize = new Size(1, 1);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(258, 30);
            lblNumber.Symbol = 0;
            lblNumber.SymbolColor = Color.Blue;
            lblNumber.SymbolSize = 0;
            lblNumber.TabIndex = 8;
            lblNumber.Text = "Câu 1:";
            lblNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FillColor = Color.Transparent;
            btnDelete.FillColor2 = Color.Transparent;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.ForeColor = Color.FromArgb(220, 53, 69);
            btnDelete.Location = new Point(789, 8);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5, 0, 0, 0);
            btnDelete.Radius = 10;
            btnDelete.RectColor = Color.Transparent;
            btnDelete.Size = new Size(34, 30);
            btnDelete.Symbol = 61453;
            btnDelete.SymbolColor = Color.Gray;
            btnDelete.SymbolHoverColor = Color.FromArgb(192, 0, 0);
            btnDelete.TabIndex = 5;
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.FillColor = Color.Transparent;
            btnEdit.FillColor2 = Color.Transparent;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(749, 8);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(5, 0, 0, 0);
            btnEdit.Radius = 10;
            btnEdit.RectColor = Color.Transparent;
            btnEdit.Size = new Size(34, 30);
            btnEdit.Symbol = 61508;
            btnEdit.SymbolColor = Color.DimGray;
            btnEdit.SymbolHoverColor = Color.Black;
            btnEdit.TabIndex = 7;
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEdit.Click += btnEdit_Click;
            // 
            // txtContentDisplay
            // 
            txtContentDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContentDisplay.FillColor2 = Color.White;
            txtContentDisplay.FillReadOnlyColor = Color.White;
            txtContentDisplay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContentDisplay.ForeColor = Color.Black;
            txtContentDisplay.ForeDisableColor = Color.Black;
            txtContentDisplay.ForeReadOnlyColor = Color.Black;
            txtContentDisplay.Location = new Point(14, 51);
            txtContentDisplay.Margin = new Padding(4, 5, 4, 5);
            txtContentDisplay.MinimumSize = new Size(1, 16);
            txtContentDisplay.Multiline = true;
            txtContentDisplay.Name = "txtContentDisplay";
            txtContentDisplay.Padding = new Padding(5);
            txtContentDisplay.ReadOnly = true;
            txtContentDisplay.RectColor = Color.Silver;
            txtContentDisplay.RectReadOnlyColor = Color.White;
            txtContentDisplay.ShowText = false;
            txtContentDisplay.Size = new Size(809, 32);
            txtContentDisplay.TabIndex = 3;
            txtContentDisplay.Text = "Nội dung câu hỏi?";
            txtContentDisplay.TextAlignment = ContentAlignment.MiddleLeft;
            txtContentDisplay.Watermark = "";
            // 
            // flpOptions
            // 
            flpOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpOptions.BackColor = Color.Transparent;
            flpOptions.Controls.Add(txtAnsA);
            flpOptions.Controls.Add(txtAnsB);
            flpOptions.Controls.Add(txtAnsC);
            flpOptions.Controls.Add(txtAnsD);
            flpOptions.FlowDirection = FlowDirection.TopDown;
            flpOptions.Location = new Point(35, 91);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(788, 149);
            flpOptions.TabIndex = 2;
            flpOptions.WrapContents = false;
            // 
            // txtAnsA
            // 
            txtAnsA.FillColor2 = Color.White;
            txtAnsA.FillReadOnlyColor = Color.White;
            txtAnsA.Font = new Font("Times New Roman", 12F);
            txtAnsA.ForeColor = Color.Black;
            txtAnsA.ForeDisableColor = Color.Black;
            txtAnsA.ForeReadOnlyColor = Color.Black;
            txtAnsA.Location = new Point(4, 5);
            txtAnsA.Margin = new Padding(4, 5, 4, 5);
            txtAnsA.MinimumSize = new Size(1, 16);
            txtAnsA.Multiline = true;
            txtAnsA.Name = "txtAnsA";
            txtAnsA.Padding = new Padding(5);
            txtAnsA.Radius = 10;
            txtAnsA.ReadOnly = true;
            txtAnsA.RectColor = Color.Silver;
            txtAnsA.RectReadOnlyColor = Color.White;
            txtAnsA.ShowText = false;
            txtAnsA.Size = new Size(199, 27);
            txtAnsA.TabIndex = 0;
            txtAnsA.Text = "txtAnsA";
            txtAnsA.TextAlignment = ContentAlignment.MiddleLeft;
            txtAnsA.Watermark = "";
            txtAnsA.Click += Answer_Click;
            // 
            // txtAnsB
            // 
            txtAnsB.FillColor2 = Color.White;
            txtAnsB.FillReadOnlyColor = Color.White;
            txtAnsB.Font = new Font("Times New Roman", 12F);
            txtAnsB.ForeColor = Color.Black;
            txtAnsB.ForeDisableColor = Color.Black;
            txtAnsB.ForeReadOnlyColor = Color.Black;
            txtAnsB.Location = new Point(4, 42);
            txtAnsB.Margin = new Padding(4, 5, 4, 5);
            txtAnsB.MinimumSize = new Size(1, 16);
            txtAnsB.Multiline = true;
            txtAnsB.Name = "txtAnsB";
            txtAnsB.Padding = new Padding(5);
            txtAnsB.Radius = 10;
            txtAnsB.ReadOnly = true;
            txtAnsB.RectColor = Color.Silver;
            txtAnsB.RectReadOnlyColor = Color.White;
            txtAnsB.ShowText = false;
            txtAnsB.Size = new Size(199, 27);
            txtAnsB.Symbol = 61528;
            txtAnsB.TabIndex = 1;
            txtAnsB.Text = "txtAnsB";
            txtAnsB.TextAlignment = ContentAlignment.MiddleLeft;
            txtAnsB.Watermark = "";
            txtAnsB.Click += Answer_Click;
            // 
            // txtAnsC
            // 
            txtAnsC.FillColor2 = Color.White;
            txtAnsC.FillReadOnlyColor = Color.White;
            txtAnsC.Font = new Font("Times New Roman", 12F);
            txtAnsC.ForeColor = Color.Black;
            txtAnsC.ForeDisableColor = Color.Black;
            txtAnsC.ForeReadOnlyColor = Color.Black;
            txtAnsC.Location = new Point(4, 79);
            txtAnsC.Margin = new Padding(4, 5, 4, 5);
            txtAnsC.MinimumSize = new Size(1, 16);
            txtAnsC.Multiline = true;
            txtAnsC.Name = "txtAnsC";
            txtAnsC.Padding = new Padding(5);
            txtAnsC.Radius = 10;
            txtAnsC.ReadOnly = true;
            txtAnsC.RectColor = Color.Silver;
            txtAnsC.RectReadOnlyColor = Color.White;
            txtAnsC.ShowText = false;
            txtAnsC.Size = new Size(199, 27);
            txtAnsC.Symbol = 61528;
            txtAnsC.TabIndex = 2;
            txtAnsC.Text = "txtAnsC";
            txtAnsC.TextAlignment = ContentAlignment.MiddleLeft;
            txtAnsC.Watermark = "";
            txtAnsC.Click += Answer_Click;
            // 
            // txtAnsD
            // 
            txtAnsD.FillColor2 = Color.White;
            txtAnsD.FillReadOnlyColor = Color.White;
            txtAnsD.Font = new Font("Times New Roman", 12F);
            txtAnsD.ForeColor = Color.Black;
            txtAnsD.ForeDisableColor = Color.Black;
            txtAnsD.ForeReadOnlyColor = Color.Black;
            txtAnsD.Location = new Point(4, 116);
            txtAnsD.Margin = new Padding(4, 5, 4, 5);
            txtAnsD.MinimumSize = new Size(1, 16);
            txtAnsD.Multiline = true;
            txtAnsD.Name = "txtAnsD";
            txtAnsD.Padding = new Padding(5);
            txtAnsD.Radius = 10;
            txtAnsD.ReadOnly = true;
            txtAnsD.RectColor = Color.Silver;
            txtAnsD.RectReadOnlyColor = Color.White;
            txtAnsD.ShowText = false;
            txtAnsD.Size = new Size(199, 27);
            txtAnsD.Symbol = 61528;
            txtAnsD.TabIndex = 3;
            txtAnsD.Text = "txtAnsD";
            txtAnsD.TextAlignment = ContentAlignment.MiddleLeft;
            txtAnsD.Watermark = "";
            txtAnsD.Click += Answer_Click;
            // 
            // UC_Question
            // 
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            Margin = new Padding(10, 5, 10, 5);
            Name = "UC_Question";
            Padding = new Padding(15);
            Size = new Size(864, 446);
            pnlCard.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            flpOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlCard;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        #endregion

        private Sunny.UI.UITextBox txtContentDisplay;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UITextBox txtAnsA;
        private Sunny.UI.UITextBox txtAnsB;
        private Sunny.UI.UITextBox txtAnsC;
        private Sunny.UI.UITextBox txtAnsD;
        private Sunny.UI.UILabel lblDoKho;
        private Sunny.UI.UIComboBox cbDoKho;
        private Sunny.UI.UILabel lblMonHoc;
        private Sunny.UI.UIComboBox cbMonHoc;
        private Sunny.UI.UILabel lblKhoi;
        private Sunny.UI.UIComboBox cbKhoi;
        private Sunny.UI.UISymbolLabel lblNumber;
    }
}
