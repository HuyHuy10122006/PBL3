namespace exambank.ui
{
    partial class FormDangNhap
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

        private void InitializeComponent()
        {
            pnlLoginCard = new Sunny.UI.UIPanel();
            uc = new UC_DangNhap();
            lblAC = new Sunny.UI.UILabel();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Controls.Add(uc);
            pnlLoginCard.FillColor = Color.White;
            pnlLoginCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlLoginCard.Location = new Point(250, 50);
            pnlLoginCard.Margin = new Padding(4, 5, 4, 5);
            pnlLoginCard.MinimumSize = new Size(1, 1);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Radius = 10;
            pnlLoginCard.RectColor = Color.FromArgb(220, 220, 220);
            pnlLoginCard.Size = new Size(450, 600);
            pnlLoginCard.TabIndex = 0;
            pnlLoginCard.Text = null;
            pnlLoginCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uc
            // 
            uc.BackColor = Color.FromArgb(243, 244, 246);
            uc.BackgroundImageLayout = ImageLayout.Stretch;
            uc.Dock = DockStyle.Fill;
            uc.Location = new Point(0, 0);
            uc.Name = "uc";
            uc.Size = new Size(450, 600);
            uc.TabIndex = 0;
            // 
            // lblAC
            // 
            lblAC.Font = new Font("Microsoft Sans Serif", 12F);
            lblAC.ForeColor = Color.FromArgb(48, 48, 48);
            lblAC.Location = new Point(60, 104);
            lblAC.Name = "lblAC";
            lblAC.Size = new Size(1, 1);
            lblAC.TabIndex = 1;
            // 
            // FormDangNhap
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_w8z9now8z9now8z9;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 674);
            Controls.Add(lblAC);
            Controls.Add(pnlLoginCard);
            Name = "FormDangNhap";
            Padding = new Padding(2, 36, 2, 2);
            Resizable = true;
            Text = "EduGenAI - Login";
            ZoomScaleRect = new Rectangle(19, 19, 950, 600);
            Resize += FormDangNhap_Resize;
            pnlLoginCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlLoginCard;

        #endregion

        private exambank.ui.UC_DangNhap uc;
        private Sunny.UI.UILabel lblAC;
    }
}