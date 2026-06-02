using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_ViewExamBank : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly ExamService _examService = new ExamService();
        private List<ExamModel> _publicExams = new List<ExamModel>();
        public UC_ViewExamBank(UserModel loginUser)
        {
            InitializeComponent();
            _loginUser = loginUser;
        }

        private void UC_ViewExamBank_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            dgvPublicExams.AutoGenerateColumns = false;
        }

        private void InitControlDataAsync(List<ExamModel> data)
        {

            List<string> subjects = _examService.GetCboValues(data, e => e.Subject);
            subjects.Insert(0, "Tất cả");
            cbSubject.DataSource = subjects;

            //List<string> grades = _examService.GetCboValues(data, q => q.Grade);
            //grades.Insert(0, "Tất cả");
            //cbGrade.DataSource = grades;
        }

        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _examService.GetPublicExamsAsync());
            _publicExams.Clear();
            foreach (var item in newData)
            {
                _publicExams.Add(item);
            }
            InitControlDataAsync(_publicExams);
            BindGrid(_publicExams);
        }

        private void BindGrid(List<ExamModel> data)
        {
            var displayList = data.Select(e => new
            {
                Id = e.Id,
                STT = data.IndexOf(e) + 1,
                ExamCode = e.ExamCode,
                Title = e.Title,
                Author = e.Author != null ? e.Author.FullName : "N/A",
                Subject = e.Subject,
                TotalQuestions = e.TotalQuestions,
            }).ToList();

            dgvPublicExams.DataSource = displayList;
        }

        private void Filter()
        {
            // Logic lọc nhanh trên list hiện tại
            string keyword = txtSearch.Text.Trim().ToLower();
            string subject = cbSubject.Text;
            //string grade = cbGrade.Text;

            var filtered = _publicExams.Where(e =>
                (string.IsNullOrWhiteSpace(keyword) || e.Title.ToLower().Contains(keyword) || e.ExamCode.ToLower().Contains(keyword)) &&
                (subject == "Tất cả" || e.Subject == subject)
            ).ToList();

            BindGrid(filtered);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dgvPublicExams_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            // Kiểm tra chuột trái và đúng cột thao tác
            if (e.Button == MouseButtons.Left && dgvPublicExams.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Chọn hàng đó luôn
                dgvPublicExams.CurrentCell = dgvPublicExams.Rows[e.RowIndex].Cells[e.ColumnIndex];

                Rectangle rect = dgvPublicExams.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsActions.Show(dgvPublicExams, rect.Left, rect.Bottom);
            }
        }

        private async void miExport_Click(object sender, EventArgs e)
        {
            if (dgvPublicExams.CurrentRow == null) return;
            try
            {
                // Lấy ID
                int examId = (int)dgvPublicExams.CurrentRow.Cells["colID"].Value;
                var fullExamData = _publicExams.FirstOrDefault(x => x.Id == examId);

                if (fullExamData != null)
                {
                    if (fullExamData.ExamQuestions == null || fullExamData.ExamQuestions.Count == 0)
                    {
                        // Nạp câu hỏi (Dùng Task.Run để không lag)
                        fullExamData.ExamQuestions = await Task.Run(() => _examService.LoadExamQuestionsAsync(examId));
                    }

                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Word Document|*.docx";
                        saveFileDialog.Title = "Lưu đề thi ra file Word";
                        saveFileDialog.FileName = $"{fullExamData.Title}.docx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var docService = new DocumentService();
                            // Chạy tác vụ xuất file trên một luồng khác để tránh treo UI nếu file nặng
                            await Task.Run(() => docService.ExportToWord(saveFileDialog.FileName, fullExamData,
                                fullExamData.ExamQuestions.Select(eq => eq.Question).ToList()
                            ));

                            UIMessageBox.ShowSuccess2("Xuất file Word thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi khi xuất file: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void dgvPublicExams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPublicExams.ClearSelection();
        }

    }
}
