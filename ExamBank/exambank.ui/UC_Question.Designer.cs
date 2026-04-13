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
            flpOptions = new FlowLayoutPanel();
            lblContent = new Sunny.UI.UILabel();
            lblNumber = new Sunny.UI.UILabel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(flpOptions);
            pnlCard.Controls.Add(lblContent);
            pnlCard.Controls.Add(lblNumber);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.FillColor = Color.White;
            pnlCard.FillColor2 = Color.White;
            pnlCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.MinimumSize = new Size(1, 1);
            pnlCard.Name = "pnlCard";
            pnlCard.Radius = 15;
            pnlCard.RectColor = Color.Black;
            pnlCard.Size = new Size(437, 265);
            pnlCard.TabIndex = 0;
            pnlCard.Text = null;
            pnlCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flpOptions
            // 
            flpOptions.FlowDirection = FlowDirection.TopDown;
            flpOptions.Location = new Point(70, 70);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(324, 178);
            flpOptions.TabIndex = 0;
            // 
            // lblContent
            // 
            lblContent.Font = new Font("Segoe UI", 12F);
            lblContent.ForeColor = Color.FromArgb(48, 48, 48);
            lblContent.Location = new Point(70, 15);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(324, 50);
            lblContent.TabIndex = 1;
            // 
            // lblNumber
            // 
            lblNumber.BackColor = Color.FromArgb(80, 160, 255);
            lblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(15, 15);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(40, 40);
            lblNumber.TabIndex = 2;
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Question
            // 
            Controls.Add(pnlCard);
            Name = "UC_Question";
            Padding = new Padding(0, 0, 0, 10);
            Size = new Size(437, 275);
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlCard;
        private Sunny.UI.UILabel lblNumber;
        private Sunny.UI.UILabel lblContent;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        #endregion
    }
}
