namespace exambank.ui
{
    partial class UC_ViewExamBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.txtSearchPublic = new Sunny.UI.UITextBox();
            this.pnlSidebar = new Sunny.UI.UIPanel();
            this.lblFilterHeader = new Sunny.UI.UILabel();
            this.cbSubjectFilter = new Sunny.UI.UIComboBox();
            this.cbGradeFilter = new Sunny.UI.UIComboBox();
            this.cbSortOrder = new Sunny.UI.UIComboBox();
            this.lblSubject = new Sunny.UI.UILabel();
            this.lblGrade = new Sunny.UI.UILabel();
            this.lblSort = new Sunny.UI.UILabel();
            this.pnlMain = new Sunny.UI.UIPanel();
            this.dgvPublicExams = new Sunny.UI.UIDataGridView();

            // Khởi tạo các cột
            this.colExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownloadCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreview = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCopy = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDownload = new System.Windows.Forms.DataGridViewImageColumn();

            // --- pnlHeader ---
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 75;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(243, 249, 255);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.txtSearchPublic);

            this.lblTitle.Text = "Ngân hàng Đề thi chung";
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 22);
            this.lblTitle.Size = new System.Drawing.Size(350, 32);

            this.txtSearchPublic.Watermark = "Tìm kiếm đề thi hoặc giáo viên...";
            this.txtSearchPublic.Location = new System.Drawing.Point(400, 22);
            this.txtSearchPublic.Size = new System.Drawing.Size(400, 32);

            // --- pnlSidebar (Bộ lọc) ---
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 220;
            this.pnlSidebar.Text = "";
            this.pnlSidebar.Controls.Add(this.lblFilterHeader);
            this.pnlSidebar.Controls.Add(this.lblSubject);
            this.pnlSidebar.Controls.Add(this.cbSubjectFilter);
            this.pnlSidebar.Controls.Add(this.lblGrade);
            this.pnlSidebar.Controls.Add(this.cbGradeFilter);
            this.pnlSidebar.Controls.Add(this.lblSort);
            this.pnlSidebar.Controls.Add(this.cbSortOrder);

            this.lblFilterHeader.Text = "BỘ LỌC HỆ THỐNG";
            this.lblFilterHeader.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterHeader.Location = new System.Drawing.Point(15, 60);

            // Lọc Môn học
            this.lblSubject.Text = "Môn học:";
            this.lblSubject.Location = new System.Drawing.Point(15, 100);
            this.cbSubjectFilter.Location = new System.Drawing.Point(15, 125);
            this.cbSubjectFilter.Width = 190;
            this.cbSubjectFilter.Items.AddRange(new object[] { "Tất cả môn", "Toán học", "Vật lý", "Hóa học", "Tiếng Anh" });

            // Lọc Khối
            this.lblGrade.Text = "Khối lớp:";
            this.lblGrade.Location = new System.Drawing.Point(15, 175);
            this.cbGradeFilter.Location = new System.Drawing.Point(15, 200);
            this.cbGradeFilter.Width = 190;
            this.cbGradeFilter.Items.AddRange(new object[] { "Tất cả khối", "Khối 10", "Khối 11", "Khối 12" });

            // Sắp xếp
            this.lblSort.Text = "Sắp xếp theo:";
            this.lblSort.Location = new System.Drawing.Point(15, 250);
            this.cbSortOrder.Location = new System.Drawing.Point(15, 275);
            this.cbSortOrder.Width = 190;
            this.cbSortOrder.Items.AddRange(new object[] { "Mới nhất", "Tải nhiều nhất", "Đánh giá cao" });

            // --- pnlMain & dgvPublicExams ---
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Controls.Add(this.dgvPublicExams);

            this.dgvPublicExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPublicExams.Columns.Clear();

            // Cấu hình Cột Dữ liệu
            this.colExamID.HeaderText = "Mã đề";
            this.colExamID.Name = "colExamID";
            this.colExamID.Width = 70;

            this.colExamName.HeaderText = "Tên đề thi";
            this.colExamName.Name = "colExamName";
            this.colExamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colAuthor.HeaderText = "Người chia sẻ";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Width = 150;

            this.colSubject.HeaderText = "Môn";
            this.colSubject.Name = "colSubject";
            this.colSubject.Width = 80;

            this.colDownloadCount.HeaderText = "Lượt tải";
            this.colDownloadCount.Name = "colDownloadCount";
            this.colDownloadCount.Width = 80;

            // Cấu hình Cột Thao tác (Image)
            this.colPreview.HeaderText = "Xem";
            this.colPreview.Name = "colPreview";
            //this.colPreview.Image = global::YourProjectName.Properties.Resources.view_icon; // Đổi YourProjectName thành tên Project của bạn
            this.colPreview.Width = 50;

            this.colCopy.HeaderText = "Lưu";
            this.colCopy.Name = "colCopy";
            //this.colCopy.Image = global::YourProjectName.Properties.Resources.copy_icon;
            this.colCopy.Width = 50;

            this.colDownload.HeaderText = "Tải";
            this.colDownload.Name = "colDownload";
            //this.colDownload.Image = global::YourProjectName.Properties.Resources.download_icon;
            this.colDownload.Width = 50;

            this.dgvPublicExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.colExamID, this.colExamName, this.colAuthor, this.colSubject,
        this.colDownloadCount, this.colPreview, this.colCopy, this.colDownload
    });

            // Thêm các Panel vào UserControl
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Size = new System.Drawing.Size(1100, 650);
        }

        #endregion
        // Các Container chính
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UIPanel pnlSidebar;
        private Sunny.UI.UIPanel pnlMain;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UITextBox txtSearchPublic;
        private Sunny.UI.UIDataGridView dgvPublicExams;

        // Các bộ lọc bên Sidebar
        private Sunny.UI.UILabel lblFilterHeader;
        private Sunny.UI.UIComboBox cbSubjectFilter;
        private Sunny.UI.UIComboBox cbGradeFilter;
        private Sunny.UI.UIComboBox cbSortOrder;
        private Sunny.UI.UILabel lblSubject;
        private Sunny.UI.UILabel lblGrade;
        private Sunny.UI.UILabel lblSort;

        // Các cột dữ liệu
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadCount;

        // Các cột thao tác bằng Image
        private System.Windows.Forms.DataGridViewImageColumn colPreview;
        private System.Windows.Forms.DataGridViewImageColumn colCopy;
        private System.Windows.Forms.DataGridViewImageColumn colDownload;
    }
}
