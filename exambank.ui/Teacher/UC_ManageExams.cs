using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Microsoft.EntityFrameworkCore;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_ManageExams : UserControl
    {
        // Sử dụng Service để thao tác với Database
        private readonly ExamService _examService = new ExamService();
        private List<ExamModel> _currentExams = new List<ExamModel>();

        public UC_ManageExams()
        {
            InitializeComponent();
            InitControlData();
            LoadDataFromDatabase();
        }

        /// <summary>
        /// Khởi tạo dữ liệu cho các ComboBox từ file Constants
        /// </summary>
        private void InitControlData()
        {
            // Load danh sách môn học
            cbSubject.Items.Clear();
            cbSubject.Items.Add("Chọn môn");
            cbSubject.Items.AddRange(Constants.List_MonHoc);
            cbSubject.SelectedIndex = 0;

            // Load danh sách khối lớp
            cbGrade.Items.Clear();
            cbGrade.Items.Add("Chọn khối");
            cbGrade.Items.AddRange(Constants.List_Khoi);
            cbGrade.SelectedIndex = 0;

            // Đăng ký sự kiện
            dgvExams.SelectionChanged += DgvExams_SelectionChanged;

            // Xử lý tìm kiếm khi nhấn Enter hoặc nút Search trên TextBox
            txtSearch.DoEnter += (s, e) => LoadDataFromDatabase();
            txtSearch.ButtonClick += (s, e) => LoadDataFromDatabase();

            // Lọc nhanh khi thay đổi ComboBox
            cbSubject.SelectedIndexChanged += (s, e) => LoadDataFromDatabase();
            cbGrade.SelectedIndexChanged += (s, e) => LoadDataFromDatabase();
        }

        /// <summary>
        /// Gọi Service để lấy dữ liệu từ DB
        /// </summary>
        private void LoadDataFromDatabase()
        {
            string keyword = txtSearch.Text.Trim();
            string subject = cbSubject.Text;
            string grade = cbGrade.Text;

            // Gọi hàm GetExams từ ExamService
            _currentExams = _examService.GetExams(keyword, subject, grade);

            DisplayDataToGrid(_currentExams);
        }

        private void DisplayDataToGrid(List<ExamModel> exams)
        {
            dgvExams.Rows.Clear();
            foreach (var exam in exams)
            {
                // Thêm dòng mới dựa trên cấu trúc cột trong Designer
                int rowIndex = dgvExams.Rows.Add(
                    exam.ExamCode,
                    exam.Title,
                    exam.Subject,
                    exam.TotalQuestions,
                    exam.Duration + " phút",
                    Properties.Resources.icon_share,
                    Properties.Resources.icon_export,
                    "Xem"
                );

                // Lưu ID hoặc nguyên Object vào Tag để xử lý sau này
                dgvExams.Rows[rowIndex].Tag = exam.Id;
            }

            // Reset thông báo số lượng chọn
            UpdateSelectionLabel();
        }

        private void DgvExams_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionLabel();
        }

        private void UpdateSelectionLabel()
        {
            int count = dgvExams.SelectedRows.Count;
            lblSelect.Text = $"{count} đề thi đang được chọn";

            // Hiển thị/Ẩn panel thao tác dưới cùng dựa trên việc có chọn hay không
            pnlThaoTac.Visible = count > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbSubject.SelectedIndex = 0;
            cbGrade.SelectedIndex = 0;
            LoadDataFromDatabase();
        }

        /// <summary>
        /// Xử lý xóa các đề thi đã chọn sử dụng Transaction trong Service
        /// </summary>
        private void btnSelectDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvExams.SelectedRows;
            if (selectedRows.Count == 0) return;

            if (UIMessageBox.ShowAsk($"Bạn có chắc chắn muốn xóa {selectedRows.Count} đề thi đã chọn? Thao tác này sẽ xóa tất cả các liên kết câu hỏi liên quan."))
            {
                // Thu thập danh sách ID đề thi từ Tag của dòng
                List<int> idsToDelete = new List<int>();
                foreach (DataGridViewRow row in selectedRows)
                {
                    if (row.Tag != null)
                        idsToDelete.Add((int)row.Tag);
                }

                // Gọi Service thực hiện xóa hàng loạt
                bool success = _examService.DeleteExams(idsToDelete);

                if (success)
                {
                    UIMessageBox.ShowSuccess("Xóa thành công các đề thi đã chọn.");
                    LoadDataFromDatabase();
                }
                else
                {
                    UIMessageBox.ShowError("Có lỗi xảy ra trong quá trình xóa dữ liệu.");
                }
            }
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra nếu không phải click vào hàng dữ liệu
            if (e.RowIndex < 0) return;

            // 2. Xác định cột được nhấn (dựa trên Name bạn đặt trong Designer)
            // Giả sử tên cột là "xem" như trong file ExamService.cs bạn gửi
            var columnName = dgvExams.Columns[e.ColumnIndex].Name;

            if (columnName == "xem" || dgvExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "Xem")
            {

                // 3. Lấy ID từ Tag của dòng
                if (dgvExams.Rows[e.RowIndex].Tag is int examId)
                {

                    // 4. Lấy dữ liệu chi tiết kèm câu hỏi từ Service
                    // Chúng ta cần lấy đầy đủ object ExamModel bao gồm cả list câu hỏi bên trong
                    var fullExamData = _examService.GetExams("", "", "")
                                                  .FirstOrDefault(x => x.Id == examId);

                    if (fullExamData != null)
                    {
                        // Nạp danh sách câu hỏi cho object này trước khi truyền sang Form xem
                        fullExamData.ExamQuestions = LoadExamQuestions(examId);

                        // 5. Mở FormXemDe bạn vừa viết
                        using (FormXemDe frm = new FormXemDe(fullExamData))
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        UIMessageBox.ShowError("Không tìm thấy dữ liệu đề thi.");
                    }
                }
            }
        }

        /// <summary>
        /// Hàm phụ trợ để nạp danh sách ExamQuestionModel kèm Question chi tiết
        /// </summary>
        private List<ExamQuestionModel> LoadExamQuestions(int examId)
        {
            // Sử dụng dbContext để lấy dữ liệu liên kết
            using (var db = new exambank.data.ExamBankDbContext())
            {
                return db.ExamQuestions
                         .Include("Question") // Nạp luôn thông tin câu hỏi chi tiết
                         .Where(eq => eq.ExamId == examId)
                         .OrderBy(eq => eq.QuestionOrder)
                         .ToList();
            }
        }

        private void btnSelectShare_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Tính năng chia sẻ đang được phát triển.");
        } 
    }
}