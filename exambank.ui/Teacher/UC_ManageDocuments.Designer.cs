namespace exambank.ui
{
    partial class UC_ManageDocuments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvDocuments = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFileName = new DataGridViewTextBoxColumn();
            colDocumentType = new DataGridViewTextBoxColumn();
            colUploadedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 51, 102);
            lblTitle.Location = new Point(23, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(242, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "KHO TÀI LIỆU NGUỒN";
            // 
            // dgvDocuments
            // 
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.AllowUserToDeleteRows = false;
            dgvDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.BackgroundColor = Color.White;
            dgvDocuments.BorderStyle = BorderStyle.None;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Columns.AddRange(new DataGridViewColumn[] { colId, colFileName, colDocumentType, colUploadedAt });
            dgvDocuments.Location = new Point(23, 81);
            dgvDocuments.Margin = new Padding(4, 3, 4, 3);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowTemplate.Height = 40;
            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.Size = new Size(992, 577);
            dgvDocuments.TabIndex = 1;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colFileName
            // 
            colFileName.HeaderText = "Tên tài liệu";
            colFileName.Name = "colFileName";
            colFileName.ReadOnly = true;
            // 
            // colDocumentType
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDocumentType.DefaultCellStyle = dataGridViewCellStyle1;
            colDocumentType.HeaderText = "Định dạng";
            colDocumentType.Name = "colDocumentType";
            colDocumentType.ReadOnly = true;
            // 
            // colUploadedAt
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colUploadedAt.DefaultCellStyle = dataGridViewCellStyle2;
            colUploadedAt.HeaderText = "Ngày tải lên";
            colUploadedAt.Name = "colUploadedAt";
            colUploadedAt.ReadOnly = true;
            // 
            // UC_ManageDocuments
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(dgvDocuments);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_ManageDocuments";
            Size = new Size(1050, 692);
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadedAt;
    }
}