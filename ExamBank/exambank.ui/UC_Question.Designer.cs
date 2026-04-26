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
            uiPanel1 = new Sunny.UI.UIPanel();
            btnDelete = new Sunny.UI.UISymbolButton();
            lblNumber = new Sunny.UI.UILabel();
            btnRegenerate = new Sunny.UI.UISymbolButton();
            btnEdit = new Sunny.UI.UISymbolButton();
            txtContentDisplay = new Sunny.UI.UITextBox();
            flpOptions = new FlowLayoutPanel();
            txtAnsA = new Sunny.UI.UITextBox();
            txtAnsB = new Sunny.UI.UITextBox();
            txtAnsC = new Sunny.UI.UITextBox();
            txtAnsD = new Sunny.UI.UITextBox();
            pnlCard.SuspendLayout();
            uiPanel1.SuspendLayout();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.Controls.Add(uiPanel1);
            pnlCard.Controls.Add(txtContentDisplay);
            pnlCard.Controls.Add(flpOptions);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.FillColor = Color.White;
            pnlCard.Font = new Font("Segoe UI", 12F);
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(0, 0, 0, 15);
            pnlCard.MinimumSize = new Size(1, 1);
            pnlCard.Name = "pnlCard";
            pnlCard.Radius = 12;
            pnlCard.RectColor = Color.FromArgb(216, 216, 216);
            pnlCard.Size = new Size(864, 280);
            pnlCard.TabIndex = 0;
            pnlCard.Text = null;
            pnlCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnDelete);
            uiPanel1.Controls.Add(lblNumber);
            uiPanel1.Controls.Add(btnRegenerate);
            uiPanel1.Controls.Add(btnEdit);
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.FillColor = Color.CornflowerBlue;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 12;
            uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            uiPanel1.Size = new Size(864, 41);
            uiPanel1.TabIndex = 4;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FillColor = Color.Gainsboro;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.ForeColor = Color.FromArgb(220, 53, 69);
            btnDelete.Location = new Point(801, 5);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5, 0, 0, 0);
            btnDelete.Radius = 10;
            btnDelete.Size = new Size(55, 30);
            btnDelete.Symbol = 61453;
            btnDelete.SymbolColor = Color.FromArgb(192, 0, 0);
            btnDelete.TabIndex = 5;
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblNumber
            // 
            lblNumber.BackColor = Color.CornflowerBlue;
            lblNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(14, 5);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(92, 30);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Câu 1";
            lblNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegenerate
            // 
            btnRegenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegenerate.FillColor = Color.Gainsboro;
            btnRegenerate.Font = new Font("Microsoft Sans Serif", 12F);
            btnRegenerate.ForeColor = Color.FromArgb(0, 150, 136);
            btnRegenerate.Location = new Point(741, 5);
            btnRegenerate.MinimumSize = new Size(1, 1);
            btnRegenerate.Name = "btnRegenerate";
            btnRegenerate.Padding = new Padding(5, 0, 0, 0);
            btnRegenerate.Radius = 10;
            btnRegenerate.Size = new Size(55, 30);
            btnRegenerate.Symbol = 61473;
            btnRegenerate.SymbolColor = Color.FromArgb(0, 192, 0);
            btnRegenerate.TabIndex = 6;
            btnRegenerate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.FillColor = Color.Gainsboro;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.ForeColor = Color.DimGray;
            btnEdit.Location = new Point(681, 5);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(5, 0, 0, 0);
            btnEdit.Radius = 10;
            btnEdit.RectColor = Color.Silver;
            btnEdit.Size = new Size(55, 30);
            btnEdit.Symbol = 61508;
            btnEdit.SymbolColor = Color.Black;
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
            txtContentDisplay.Size = new Size(839, 32);
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
            flpOptions.Size = new Size(818, 149);
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
            // 
            // UC_Question
            // 
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            Name = "UC_Question";
            Padding = new Padding(0, 0, 0, 10);
            Size = new Size(864, 286);
            Resize += UC_Question_Resize;
            pnlCard.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            flpOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlCard;
        private Sunny.UI.UILabel lblNumber;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        #endregion

        private Sunny.UI.UITextBox txtContentDisplay;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnRegenerate;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UITextBox txtAnsA;
        private Sunny.UI.UITextBox txtAnsB;
        private Sunny.UI.UITextBox txtAnsC;
        private Sunny.UI.UITextBox txtAnsD;
    }
}
