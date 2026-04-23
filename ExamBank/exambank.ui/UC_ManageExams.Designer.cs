namespace exambank.ui
{
    partial class UC_ManageExams
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlHeader = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            btnCreateExam = new Sunny.UI.UIButton();
            lblGrade = new Sunny.UI.UILabel();
            lblSubject = new Sunny.UI.UILabel();
            cbGradeFilter = new Sunny.UI.UIComboBox();
            cbSubjectFilter = new Sunny.UI.UIComboBox();
            txtSearchExam = new Sunny.UI.UITextBox();
            dgvExams = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colShare = new DataGridViewImageColumn();
            colExport = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnlSidebar = new Sunny.UI.UIPanel();
            pnlBody = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlBody.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnCreateExam);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1076, 80);
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(20, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(392, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách Đề thi cá nhân";
            // 
            // btnCreateExam
            // 
            btnCreateExam.Font = new Font("Microsoft Sans Serif", 12F);
            btnCreateExam.LightColor = Color.FromArgb(24, 24, 24);
            btnCreateExam.Location = new Point(650, 20);
            btnCreateExam.MinimumSize = new Size(1, 1);
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Size = new Size(223, 35);
            btnCreateExam.Style = Sunny.UI.UIStyle.Custom;
            btnCreateExam.TabIndex = 1;
            btnCreateExam.Text = "[+] Tạo đề thi mới";
            btnCreateExam.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblGrade
            // 
            lblGrade.Font = new Font("Microsoft Sans Serif", 12F);
            lblGrade.ForeColor = Color.FromArgb(48, 48, 48);
            lblGrade.Location = new Point(20, 99);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(100, 23);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "Khối lớp:";
            // 
            // lblSubject
            // 
            lblSubject.Font = new Font("Microsoft Sans Serif", 12F);
            lblSubject.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubject.Location = new Point(20, 29);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(100, 23);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Môn học:";
            // 
            // cbGradeFilter
            // 
            cbGradeFilter.DataSource = null;
            cbGradeFilter.FillColor = Color.White;
            cbGradeFilter.Font = new Font("Microsoft Sans Serif", 12F);
            cbGradeFilter.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbGradeFilter.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbGradeFilter.Location = new Point(20, 124);
            cbGradeFilter.Margin = new Padding(4, 5, 4, 5);
            cbGradeFilter.MinimumSize = new Size(63, 0);
            cbGradeFilter.Name = "cbGradeFilter";
            cbGradeFilter.Padding = new Padding(0, 0, 30, 2);
            cbGradeFilter.Size = new Size(150, 29);
            cbGradeFilter.SymbolSize = 24;
            cbGradeFilter.TabIndex = 3;
            cbGradeFilter.TextAlignment = ContentAlignment.MiddleLeft;
            cbGradeFilter.Watermark = "";
            // 
            // cbSubjectFilter
            // 
            cbSubjectFilter.DataSource = null;
            cbSubjectFilter.FillColor = Color.White;
            cbSubjectFilter.Font = new Font("Microsoft Sans Serif", 12F);
            cbSubjectFilter.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbSubjectFilter.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbSubjectFilter.Location = new Point(20, 54);
            cbSubjectFilter.Margin = new Padding(4, 5, 4, 5);
            cbSubjectFilter.MinimumSize = new Size(63, 0);
            cbSubjectFilter.Name = "cbSubjectFilter";
            cbSubjectFilter.Padding = new Padding(0, 0, 30, 2);
            cbSubjectFilter.Size = new Size(150, 29);
            cbSubjectFilter.SymbolSize = 24;
            cbSubjectFilter.TabIndex = 1;
            cbSubjectFilter.TextAlignment = ContentAlignment.MiddleLeft;
            cbSubjectFilter.Watermark = "";
            // 
            // txtSearchExam
            // 
            txtSearchExam.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearchExam.Location = new Point(18, 17);
            txtSearchExam.Margin = new Padding(4, 5, 4, 5);
            txtSearchExam.MinimumSize = new Size(1, 16);
            txtSearchExam.Name = "txtSearchExam";
            txtSearchExam.Padding = new Padding(5);
            txtSearchExam.ShowText = false;
            txtSearchExam.Size = new Size(300, 35);
            txtSearchExam.TabIndex = 1;
            txtSearchExam.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchExam.Watermark = "Nhập mã, tên đề thi...";
            // 
            // dgvExams
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.BackgroundColor = Color.White;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.ColumnHeadersHeight = 32;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, colEdit, colShare, colExport, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle3;
            dgvExams.Dock = DockStyle.Fill;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.Font = new Font("Microsoft Sans Serif", 12F);
            dgvExams.GridColor = Color.FromArgb(80, 160, 255);
            dgvExams.Location = new Point(0, 0);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvExams.SelectedIndex = -1;
            dgvExams.Size = new Size(874, 509);
            dgvExams.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvExams.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã đề";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Tên đề thi";
            dataGridViewTextBoxColumn2.MinimumWidth = 200;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Môn học";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Số câu";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Thời gian";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Sửa";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.Width = 50;
            // 
            // colShare
            // 
            colShare.HeaderText = "Chia sẻ";
            colShare.MinimumWidth = 6;
            colShare.Name = "colShare";
            colShare.Width = 85;
            // 
            // colExport
            // 
            colExport.HeaderText = "Xuất";
            colExport.MinimumWidth = 6;
            colExport.Name = "colExport";
            colExport.Width = 55;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Xóa";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Width = 50;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(lblSubject);
            pnlSidebar.Controls.Add(cbSubjectFilter);
            pnlSidebar.Controls.Add(lblGrade);
            pnlSidebar.Controls.Add(cbGradeFilter);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Font = new Font("Microsoft Sans Serif", 12F);
            pnlSidebar.Location = new Point(0, 80);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.MinimumSize = new Size(1, 1);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(202, 577);
            pnlSidebar.TabIndex = 3;
            pnlSidebar.Text = null;
            pnlSidebar.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(uiPanel2);
            pnlBody.Controls.Add(uiPanel1);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBody.Location = new Point(202, 80);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.MinimumSize = new Size(1, 1);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(874, 577);
            pnlBody.TabIndex = 4;
            pnlBody.Text = null;
            pnlBody.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(dgvExams);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 68);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(874, 509);
            uiPanel2.TabIndex = 3;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(txtSearchExam);
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(874, 68);
            uiPanel1.TabIndex = 2;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // UC_ManageExams
            // 
            Controls.Add(pnlBody);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "UC_ManageExams";
            Size = new Size(1076, 657);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Hàm hỗ trợ thêm cột icon nhanh
        private void AddIconColumn(out DataGridViewImageColumn col, string header, Image img)
        {
            col = new DataGridViewImageColumn();
            col.HeaderText = header;
            col.Image = img;
            col.Width = 60;
            dgvExams.Columns.Add(col);
        }

        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIButton btnCreateExam;
        private Sunny.UI.UITextBox txtSearchExam;
        private Sunny.UI.UIDataGridView dgvExams;
        private Sunny.UI.UIComboBox cbSubjectFilter;
        private Sunny.UI.UIComboBox cbGradeFilter;
        private Sunny.UI.UILabel lblSubject;
        private Sunny.UI.UILabel lblGrade;
        // Các cột chức năng (Dùng ImageColumn cho chuyên nghiệp)
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colShare;
        private System.Windows.Forms.DataGridViewImageColumn colExport;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Sunny.UI.UIPanel pnlSidebar;
        private Sunny.UI.UIPanel pnlBody;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
    }
}
