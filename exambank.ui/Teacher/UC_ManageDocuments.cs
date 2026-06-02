using exambank.data;
using exambank.data.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace exambank.ui
{
    public partial class UC_ManageDocuments : UserControl
    {
        private UserModel _user;

        public UC_ManageDocuments(UserModel user)
        {
            InitializeComponent();
            _user = user;

            this.AutoScaleMode = AutoScaleMode.None;

            dgvDocuments.CellDoubleClick += DgvDocuments_CellDoubleClick;
            
            SetupContextMenu();
            LoadData();
        }
        private void SetupContextMenu()
        {
            // Tạo menu nổi
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem itemDelete = new ToolStripMenuItem("🗑️ Xóa tài liệu này");

            // Gắn sự kiện khi bấm nút Xóa
            itemDelete.Click += ItemDelete_Click;
            menu.Items.Add(itemDelete);

            // Gắn menu này vào bảng
            dgvDocuments.ContextMenuStrip = menu;

            // Ép bảng chọn đúng dòng khi người dùng click chuột phải (Mặc định WinForms không có cái này)
            dgvDocuments.CellMouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    dgvDocuments.ClearSelection();
                    dgvDocuments.Rows[e.RowIndex].Selected = true;
                    dgvDocuments.CurrentCell = dgvDocuments.Rows[e.RowIndex].Cells[1];
                }
            };
        }
        private void ItemDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có đang chọn dòng nào không
            if (dgvDocuments.CurrentRow != null && dgvDocuments.CurrentRow.Index >= 0)
            {
                // Lấy Id và Tên của tài liệu ở dòng đang chọn
                int docId = Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value);
                string fileName = dgvDocuments.CurrentRow.Cells[1].Value?.ToString();

                // Cảnh báo gắt hơn vì đây là xóa vĩnh viễn
                DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa VĨNH VIỄN tài liệu:\n'{fileName}'\n(Bao gồm cả file gốc trên máy tính)?",
                                                       "Cảnh báo xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Error);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new ExamBankDbContext())
                        {
                            var doc = db.Documents.FirstOrDefault(d => d.Id == docId);
                            if (doc != null)
                            {
                                // 1. Xóa file vật lý trên ổ cứng (Nếu file tồn tại)
                                if (!string.IsNullOrEmpty(doc.FilePath) && System.IO.File.Exists(doc.FilePath))
                                {
                                    try
                                    {
                                        System.IO.File.Delete(doc.FilePath);
                                    }
                                    catch (Exception exFile)
                                    {
                                        MessageBox.Show("Không thể xóa file gốc vì file đang được mở ở phần mềm khác.\nHãy đóng file và thử lại!\nLỗi: " + exFile.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return; // Dừng lại, không xóa trong DB nữa nếu file chưa xóa được
                                    }
                                }

                                // 2. Xóa cứng hoàn toàn khỏi Database
                                db.Documents.Remove(doc);
                                db.SaveChanges();

                                // 3. Tải lại bảng để tài liệu biến mất khỏi giao diện
                                LoadData();

                                MessageBox.Show("Đã xóa vĩnh viễn tài liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadData()
        {
            try
            {
                dgvDocuments.Rows.Clear();
                using (var db = new ExamBankDbContext())
                {
                    var docs = db.Documents
                        .Where(d => d.UserId == _user.Id && d.IsActive)
                        .OrderByDescending(d => d.UploadedAt)
                        .ToList();

                    foreach (var item in docs)
                    {
                        dgvDocuments.Rows.Add(
                            item.Id,
                            item.FileName,
                            item.DocumentType,
                            item.UploadedAt.ToString("dd/MM/yyyy HH:mm")
                        );
                    }
                }
                dgvDocuments.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int docId = Convert.ToInt32(dgvDocuments.Rows[e.RowIndex].Cells[0].Value);

                using (var db = new ExamBankDbContext())
                {
                    var doc = db.Documents.FirstOrDefault(d => d.Id == docId);

                    if (doc != null && !string.IsNullOrEmpty(doc.FilePath))
                    {
                        MoFile(doc.FilePath);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy đường dẫn file lưu trữ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void MoFile(string duongDan)
        {
            try
            {
                Process.Start(new ProcessStartInfo(duongDan) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}