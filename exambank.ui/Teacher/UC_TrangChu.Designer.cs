namespace exambank.ui
{
    partial class UC_TrangChu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new Sunny.UI.UILabel();
            this.panelQ = new Sunny.UI.UIPanel();
            this.iconQ = new Sunny.UI.UISymbolLabel();
            this.lblTotalQuestions = new Sunny.UI.UILabel();
            this.lblTitleQ = new Sunny.UI.UILabel();
            this.panelE = new Sunny.UI.UIPanel();
            this.iconE = new Sunny.UI.UISymbolLabel();
            this.lblTotalExams = new Sunny.UI.UILabel();
            this.lblTitleE = new Sunny.UI.UILabel();
            this.panelS = new Sunny.UI.UIPanel();
            this.iconS = new Sunny.UI.UISymbolLabel();
            this.lblTotalSubjects = new Sunny.UI.UILabel();
            this.lblTitleS = new Sunny.UI.UILabel();
            this.dgvRecentExams = new Sunny.UI.UIDataGridView();
            this.panelQ.SuspendLayout();
            this.panelE.SuspendLayout();
            this.panelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentExams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(600, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng trở lại với hệ thống EduGenAI!";
            // 
            // panelQ
            // 
            this.panelQ.Controls.Add(this.lblTotalQuestions);
            this.panelQ.Controls.Add(this.lblTitleQ);
            this.panelQ.Controls.Add(this.iconQ);
            this.panelQ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelQ.Location = new System.Drawing.Point(30, 80);
            this.panelQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelQ.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelQ.Name = "panelQ";
            this.panelQ.Radius = 15;
            this.panelQ.RectColor = System.Drawing.Color.Transparent;
            this.panelQ.Size = new System.Drawing.Size(250, 120);
            this.panelQ.TabIndex = 1;
            this.panelQ.Text = null;
            this.panelQ.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconQ
            // 
            this.iconQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F); // Dùng Font để chỉnh kích thước icon
            this.iconQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.iconQ.Location = new System.Drawing.Point(150, 30);
            this.iconQ.MinimumSize = new System.Drawing.Size(1, 1);
            this.iconQ.Name = "iconQ";
            this.iconQ.Size = new System.Drawing.Size(100, 100);
            this.iconQ.Symbol = 61447;
            this.iconQ.TabIndex = 2;
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.lblTotalQuestions.Location = new System.Drawing.Point(20, 50);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(150, 50);
            this.lblTotalQuestions.TabIndex = 1;
            this.lblTotalQuestions.Text = "1,250";
            // 
            // lblTitleQ
            // 
            this.lblTitleQ.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.lblTitleQ.Location = new System.Drawing.Point(20, 15);
            this.lblTitleQ.Name = "lblTitleQ";
            this.lblTitleQ.Size = new System.Drawing.Size(200, 30);
            this.lblTitleQ.TabIndex = 0;
            this.lblTitleQ.Text = "Tổng số câu hỏi";
            // 
            // panelE
            // 
            this.panelE.Controls.Add(this.lblTotalExams);
            this.panelE.Controls.Add(this.lblTitleE);
            this.panelE.Controls.Add(this.iconE);
            this.panelE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.panelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelE.Location = new System.Drawing.Point(310, 80);
            this.panelE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelE.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelE.Name = "panelE";
            this.panelE.Radius = 15;
            this.panelE.RectColor = System.Drawing.Color.Transparent;
            this.panelE.Size = new System.Drawing.Size(250, 120);
            this.panelE.TabIndex = 2;
            this.panelE.Text = null;
            this.panelE.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconE
            // 
            this.iconE.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.iconE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.iconE.Location = new System.Drawing.Point(150, 30);
            this.iconE.MinimumSize = new System.Drawing.Size(1, 1);
            this.iconE.Name = "iconE";
            this.iconE.Size = new System.Drawing.Size(100, 100);
            this.iconE.Symbol = 61573;
            this.iconE.TabIndex = 2;
            // 
            // lblTotalExams
            // 
            this.lblTotalExams.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExams.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalExams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblTotalExams.Location = new System.Drawing.Point(20, 50);
            this.lblTotalExams.Name = "lblTotalExams";
            this.lblTotalExams.Size = new System.Drawing.Size(150, 50);
            this.lblTotalExams.TabIndex = 1;
            this.lblTotalExams.Text = "45";
            // 
            // lblTitleE
            // 
            this.lblTitleE.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblTitleE.Location = new System.Drawing.Point(20, 15);
            this.lblTitleE.Name = "lblTitleE";
            this.lblTitleE.Size = new System.Drawing.Size(200, 30);
            this.lblTitleE.TabIndex = 0;
            this.lblTitleE.Text = "Số đề thi đã tạo";
            // 
            // panelS
            // 
            this.panelS.Controls.Add(this.lblTotalSubjects);
            this.panelS.Controls.Add(this.lblTitleS);
            this.panelS.Controls.Add(this.iconS);
            this.panelS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.panelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelS.Location = new System.Drawing.Point(590, 80);
            this.panelS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelS.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelS.Name = "panelS";
            this.panelS.Radius = 15;
            this.panelS.RectColor = System.Drawing.Color.Transparent;
            this.panelS.Size = new System.Drawing.Size(250, 120);
            this.panelS.TabIndex = 3;
            this.panelS.Text = null;
            this.panelS.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconS
            // 
            this.iconS.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.iconS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.iconS.Location = new System.Drawing.Point(150, 30);
            this.iconS.MinimumSize = new System.Drawing.Size(1, 1);
            this.iconS.Name = "iconS";
            this.iconS.Size = new System.Drawing.Size(100, 100);
            this.iconS.Symbol = 61480;
            this.iconS.TabIndex = 2;
            // 
            // lblTotalSubjects
            // 
            this.lblTotalSubjects.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSubjects.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.lblTotalSubjects.Location = new System.Drawing.Point(20, 50);
            this.lblTotalSubjects.Name = "lblTotalSubjects";
            this.lblTotalSubjects.Size = new System.Drawing.Size(150, 50);
            this.lblTotalSubjects.TabIndex = 1;
            this.lblTotalSubjects.Text = "8";
            // 
            // lblTitleS
            // 
            this.lblTitleS.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.lblTitleS.Location = new System.Drawing.Point(20, 15);
            this.lblTitleS.Name = "lblTitleS";
            this.lblTitleS.Size = new System.Drawing.Size(200, 30);
            this.lblTitleS.TabIndex = 0;
            this.lblTitleS.Text = "Môn học quản lý";
            // 
            // dgvRecentExams
            // 
            this.dgvRecentExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentExams.Location = new System.Drawing.Point(30, 230);
            this.dgvRecentExams.Name = "dgvRecentExams";
            this.dgvRecentExams.RectColor = System.Drawing.Color.LightGray;
            this.dgvRecentExams.RowTemplate.Height = 40;
            this.dgvRecentExams.Size = new System.Drawing.Size(810, 400);
            this.dgvRecentExams.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvRecentExams.Style = Sunny.UI.UIStyle.Custom;
            this.dgvRecentExams.TabIndex = 4;
            // 
            // UC_TrangChu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvRecentExams);
            this.Controls.Add(this.panelS);
            this.Controls.Add(this.panelE);
            this.Controls.Add(this.panelQ);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(880, 660);
            this.panelQ.ResumeLayout(false);
            this.panelE.ResumeLayout(false);
            this.panelS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblWelcome;
        private Sunny.UI.UIPanel panelQ;
        private Sunny.UI.UILabel lblTotalQuestions;
        private Sunny.UI.UILabel lblTitleQ;
        private Sunny.UI.UISymbolLabel iconQ;
        private Sunny.UI.UIPanel panelE;
        private Sunny.UI.UILabel lblTotalExams;
        private Sunny.UI.UILabel lblTitleE;
        private Sunny.UI.UISymbolLabel iconE;
        private Sunny.UI.UIPanel panelS;
        private Sunny.UI.UILabel lblTotalSubjects;
        private Sunny.UI.UILabel lblTitleS;
        private Sunny.UI.UISymbolLabel iconS;
        private Sunny.UI.UIDataGridView dgvRecentExams;
    }
}