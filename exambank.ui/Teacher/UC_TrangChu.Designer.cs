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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            lblWelcome = new Sunny.UI.UILabel();
            panelQ = new Sunny.UI.UIPanel();
            lblTotalQuestions = new Sunny.UI.UILabel();
            lblTitleQ = new Sunny.UI.UILabel();
            iconQ = new Sunny.UI.UISymbolLabel();
            panelE = new Sunny.UI.UIPanel();
            lblTotalExams = new Sunny.UI.UILabel();
            lblTitleE = new Sunny.UI.UILabel();
            iconE = new Sunny.UI.UISymbolLabel();
            panelS = new Sunny.UI.UIPanel();
            lblTotalSubjects = new Sunny.UI.UILabel();
            lblTitleS = new Sunny.UI.UILabel();
            iconS = new Sunny.UI.UISymbolLabel();
            dgvRecentExams = new Sunny.UI.UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSTT = new DataGridViewTextBoxColumn();
            colExamCode = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colTotalQuestions = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            uiLabel1 = new Sunny.UI.UILabel();
            panelQ.SuspendLayout();
            panelE.SuspendLayout();
            panelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentExams).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(48, 48, 48);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(810, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng trở lại với hệ thống EduGenAI!";
            // 
            // panelQ
            // 
            panelQ.Controls.Add(lblTotalQuestions);
            panelQ.Controls.Add(lblTitleQ);
            panelQ.Controls.Add(iconQ);
            panelQ.FillColor = Color.FromArgb(235, 245, 255);
            panelQ.Font = new Font("Microsoft Sans Serif", 12F);
            panelQ.Location = new Point(30, 80);
            panelQ.Margin = new Padding(4, 5, 4, 5);
            panelQ.MinimumSize = new Size(1, 1);
            panelQ.Name = "panelQ";
            panelQ.Radius = 15;
            panelQ.RectColor = Color.LightGray;
            panelQ.Size = new Size(250, 120);
            panelQ.TabIndex = 1;
            panelQ.Text = null;
            panelQ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTotalQuestions
            // 
            lblTotalQuestions.BackColor = Color.Transparent;
            lblTotalQuestions.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalQuestions.ForeColor = Color.FromArgb(45, 120, 200);
            lblTotalQuestions.Location = new Point(20, 50);
            lblTotalQuestions.Name = "lblTotalQuestions";
            lblTotalQuestions.Size = new Size(150, 50);
            lblTotalQuestions.TabIndex = 1;
            lblTotalQuestions.Text = "1,250";
            // 
            // lblTitleQ
            // 
            lblTitleQ.BackColor = Color.Transparent;
            lblTitleQ.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleQ.ForeColor = Color.FromArgb(45, 120, 200);
            lblTitleQ.Location = new Point(20, 15);
            lblTitleQ.Name = "lblTitleQ";
            lblTitleQ.Size = new Size(200, 30);
            lblTitleQ.TabIndex = 0;
            lblTitleQ.Text = "Tổng số câu hỏi";
            // 
            // iconQ
            // 
            iconQ.BackColor = Color.White;
            iconQ.Font = new Font("Microsoft Sans Serif", 48F);
            iconQ.ForeColor = Color.FromArgb(210, 230, 250);
            iconQ.Location = new Point(150, 30);
            iconQ.MinimumSize = new Size(1, 1);
            iconQ.Name = "iconQ";
            iconQ.Radius = 15;
            iconQ.Size = new Size(97, 87);
            iconQ.Symbol = 57444;
            iconQ.SymbolSize = 35;
            iconQ.TabIndex = 2;
            // 
            // panelE
            // 
            panelE.Controls.Add(lblTotalExams);
            panelE.Controls.Add(lblTitleE);
            panelE.Controls.Add(iconE);
            panelE.FillColor = Color.FromArgb(255, 245, 235);
            panelE.Font = new Font("Microsoft Sans Serif", 12F);
            panelE.Location = new Point(310, 80);
            panelE.Margin = new Padding(4, 5, 4, 5);
            panelE.MinimumSize = new Size(1, 1);
            panelE.Name = "panelE";
            panelE.Radius = 15;
            panelE.RectColor = Color.LightGray;
            panelE.Size = new Size(250, 120);
            panelE.TabIndex = 2;
            panelE.Text = null;
            panelE.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTotalExams
            // 
            lblTotalExams.BackColor = Color.Transparent;
            lblTotalExams.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalExams.ForeColor = Color.FromArgb(220, 120, 40);
            lblTotalExams.Location = new Point(20, 50);
            lblTotalExams.Name = "lblTotalExams";
            lblTotalExams.Size = new Size(150, 50);
            lblTotalExams.TabIndex = 1;
            lblTotalExams.Text = "45";
            // 
            // lblTitleE
            // 
            lblTitleE.BackColor = Color.Transparent;
            lblTitleE.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleE.ForeColor = Color.FromArgb(220, 120, 40);
            lblTitleE.Location = new Point(20, 15);
            lblTitleE.Name = "lblTitleE";
            lblTitleE.Size = new Size(200, 30);
            lblTitleE.TabIndex = 0;
            lblTitleE.Text = "Số đề thi đã tạo";
            // 
            // iconE
            // 
            iconE.BackColor = Color.White;
            iconE.Font = new Font("Microsoft Sans Serif", 48F);
            iconE.ForeColor = Color.FromArgb(250, 225, 210);
            iconE.Location = new Point(150, 30);
            iconE.MinimumSize = new Size(1, 1);
            iconE.Name = "iconE";
            iconE.Radius = 15;
            iconE.Size = new Size(97, 87);
            iconE.Symbol = 363064;
            iconE.SymbolSize = 35;
            iconE.TabIndex = 2;
            // 
            // panelS
            // 
            panelS.Controls.Add(lblTotalSubjects);
            panelS.Controls.Add(lblTitleS);
            panelS.Controls.Add(iconS);
            panelS.FillColor = Color.FromArgb(240, 250, 240);
            panelS.Font = new Font("Microsoft Sans Serif", 12F);
            panelS.Location = new Point(590, 80);
            panelS.Margin = new Padding(4, 5, 4, 5);
            panelS.MinimumSize = new Size(1, 1);
            panelS.Name = "panelS";
            panelS.Radius = 15;
            panelS.RectColor = Color.LightGray;
            panelS.Size = new Size(250, 120);
            panelS.TabIndex = 3;
            panelS.Text = null;
            panelS.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSubjects
            // 
            lblTotalSubjects.BackColor = Color.Transparent;
            lblTotalSubjects.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalSubjects.ForeColor = Color.FromArgb(60, 160, 80);
            lblTotalSubjects.Location = new Point(20, 50);
            lblTotalSubjects.Name = "lblTotalSubjects";
            lblTotalSubjects.Size = new Size(150, 50);
            lblTotalSubjects.TabIndex = 1;
            lblTotalSubjects.Text = "8";
            // 
            // lblTitleS
            // 
            lblTitleS.BackColor = Color.Transparent;
            lblTitleS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleS.ForeColor = Color.FromArgb(60, 160, 80);
            lblTitleS.Location = new Point(20, 15);
            lblTitleS.Name = "lblTitleS";
            lblTitleS.Size = new Size(200, 30);
            lblTitleS.TabIndex = 0;
            lblTitleS.Text = "Môn học quản lý";
            // 
            // iconS
            // 
            iconS.BackColor = Color.White;
            iconS.Font = new Font("Microsoft Sans Serif", 48F);
            iconS.ForeColor = Color.FromArgb(220, 240, 220);
            iconS.Location = new Point(150, 30);
            iconS.MinimumSize = new Size(1, 1);
            iconS.Name = "iconS";
            iconS.Radius = 15;
            iconS.Size = new Size(97, 87);
            iconS.Symbol = 61485;
            iconS.SymbolSize = 35;
            iconS.TabIndex = 2;
            // 
            // dgvRecentExams
            // 
            dgvRecentExams.AllowUserToAddRows = false;
            dgvRecentExams.AllowUserToDeleteRows = false;
            dgvRecentExams.AllowUserToResizeColumns = false;
            dgvRecentExams.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.WhiteSmoke;
            dgvRecentExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvRecentExams.BackgroundColor = Color.White;
            dgvRecentExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.LightGray;
            dataGridViewCellStyle12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvRecentExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvRecentExams.ColumnHeadersHeight = 32;
            dgvRecentExams.Columns.AddRange(new DataGridViewColumn[] { colID, colSTT, colExamCode, colTitle, colSubject, colTotalQuestions, colCreatedAt });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvRecentExams.DefaultCellStyle = dataGridViewCellStyle13;
            dgvRecentExams.EnableHeadersVisualStyles = false;
            dgvRecentExams.Font = new Font("Microsoft Sans Serif", 12F);
            dgvRecentExams.GridColor = Color.Black;
            dgvRecentExams.Location = new Point(33, 320);
            dgvRecentExams.Name = "dgvRecentExams";
            dgvRecentExams.ReadOnly = true;
            dgvRecentExams.RectColor = Color.Black;
            dgvRecentExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvRecentExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvRecentExams.RowHeadersVisible = false;
            dgvRecentExams.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRecentExams.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvRecentExams.RowTemplate.Height = 33;
            dgvRecentExams.ScrollBarColor = Color.Black;
            dgvRecentExams.ScrollBarRectColor = Color.Black;
            dgvRecentExams.ScrollBarStyleInherited = false;
            dgvRecentExams.SelectedIndex = -1;
            dgvRecentExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentExams.Size = new Size(807, 378);
            dgvRecentExams.StripeOddColor = Color.WhiteSmoke;
            dgvRecentExams.TabIndex = 4;
            // 
            // colID
            // 
            colID.DataPropertyName = "Id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colSTT
            // 
            colSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colSTT.DataPropertyName = "STT";
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 75;
            // 
            // colExamCode
            // 
            colExamCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colExamCode.DataPropertyName = "ExamCode";
            colExamCode.HeaderText = "Mã đề";
            colExamCode.MinimumWidth = 6;
            colExamCode.Name = "colExamCode";
            colExamCode.ReadOnly = true;
            colExamCode.Width = 91;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Tên đề thi";
            colTitle.MinimumWidth = 200;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colSubject.DataPropertyName = "Subject";
            colSubject.HeaderText = "Môn học";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            colSubject.Width = 110;
            // 
            // colTotalQuestions
            // 
            colTotalQuestions.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colTotalQuestions.DataPropertyName = "TotalQuestions";
            colTotalQuestions.HeaderText = "Số câu";
            colTotalQuestions.MinimumWidth = 6;
            colTotalQuestions.Name = "colTotalQuestions";
            colTotalQuestions.ReadOnly = true;
            colTotalQuestions.Width = 93;
            // 
            // colCreatedAt
            // 
            colCreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colCreatedAt.DataPropertyName = "CreatedAt";
            colCreatedAt.HeaderText = "Ngày tạo";
            colCreatedAt.MinimumWidth = 6;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.Width = 114;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            uiLabel1.Location = new Point(30, 279);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(247, 29);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "Đề đã tạo gần đây";
            // 
            // UC_TrangChu
            // 
            BackColor = Color.WhiteSmoke;
            Controls.Add(uiLabel1);
            Controls.Add(dgvRecentExams);
            Controls.Add(panelQ);
            Controls.Add(panelS);
            Controls.Add(panelE);
            Controls.Add(lblWelcome);
            Name = "UC_TrangChu";
            Size = new Size(880, 774);
            panelQ.ResumeLayout(false);
            panelE.ResumeLayout(false);
            panelS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentExams).EndInit();
            ResumeLayout(false);

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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colExamCode;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colTotalQuestions;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Sunny.UI.UILabel uiLabel1;
    }
}