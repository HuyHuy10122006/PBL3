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
            ucLogin = new UC_DangNhap();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Controls.Add(ucLogin);
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
            // ucLogin
            // 
            ucLogin.BackColor = Color.FromArgb(243, 244, 246);
            ucLogin.BackgroundImageLayout = ImageLayout.Stretch;
            ucLogin.Dock = DockStyle.Fill;
            ucLogin.Location = new Point(0, 0);
            ucLogin.Name = "ucLogin";
            ucLogin.Size = new Size(450, 600);
            ucLogin.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 674);
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

        #endregion
        private Sunny.UI.UIPanel pnlLoginCard;
        public exambank.ui.UC_DangNhap ucLogin;
    }
}