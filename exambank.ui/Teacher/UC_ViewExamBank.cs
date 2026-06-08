using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.logic.Service;
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
        private FlowLayoutPanel flpExams;

        public UC_ViewExamBank(UserModel loginUser)
        {
            InitializeComponent();
            _loginUser = loginUser;

            // Tạo FlowLayoutPanel thay thế DataGridView
            flpExams = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(15),
                BackColor = Color.FromArgb(245, 247, 250),
                WrapContents = true
            };
            dgvPublicExams.Visible = false;
            pnlDgv.Controls.Add(flpExams);
            flpExams.BringToFront();
        }

        private async void UC_ViewExamBank_Load(object sender, EventArgs e)
        {
            await LoadDataTable();
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
            try
            {
                var newData = await _examService.GetPublicExamsAsync();
                _publicExams.Clear();
                foreach (var item in newData)
                {
                    _publicExams.Add(item);
                }
                InitControlDataAsync(_publicExams);
                BindGrid(_publicExams);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi LoadDataTable (ViewExamBank): " + ex.Message);
            }
        }

        private void BindGrid(List<ExamModel> data)
        {
            if (flpExams != null)
            {
                flpExams.SuspendLayout();
                flpExams.Controls.Clear();

                if (data.Count == 0)
                {
                    // Hiển thị thông báo trống
                    var lblEmpty = new Label
                    {
                        Text = "📭 Chưa có đề thi nào được chia sẻ",
                        Font = new Font("Segoe UI", 14f, FontStyle.Regular),
                        ForeColor = Color.FromArgb(160, 160, 160),
                        AutoSize = false,
                        Size = new Size(flpExams.Width - 40, 60),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    flpExams.Controls.Add(lblEmpty);
                }
                else
                {
                    foreach (var exam in data)
                    {
                        var card = new exambank.ui.Common.UC_ExamCard(exam, false);
                        card.ActionClicked += Card_ActionClicked;
                        flpExams.Controls.Add(card);
                    }
                }

                flpExams.ResumeLayout();
            }
        }

        private void Card_ActionClicked(object sender, exambank.ui.Common.ExamCardEventArgs e)
        {
            if (e.Action == "More")
            {
                cmsActions.Tag = e.Exam;
                Rectangle rect = e.SourceControl.ClientRectangle;
                cmsActions.Show(e.SourceControl, rect.Left, rect.Bottom);
            }
            else if (e.Action == "View")
            {
                cmsActions.Tag = e.Exam;
                ViewExamDetail(e.Exam);
            }
        }

        private async void ViewExamDetail(ExamModel exam)
        {
            if (exam == null) return;
            try
            {
                if (exam.ExamQuestions == null || exam.ExamQuestions.Count == 0)
                {
                    exam.ExamQuestions = await _examService.LoadExamQuestionsAsync(exam.Id);
                }
                using (FormXemDe frm = new FormXemDe(exam, true, _loginUser.Id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
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
            ExamModel fullExamData = null;

            // Lấy từ Tag (context menu từ card)
            if (cmsActions.Tag is ExamModel tagExam)
            {
                fullExamData = tagExam;
            }
            else if (dgvPublicExams.CurrentRow != null)
            {
                int examId = (int)dgvPublicExams.CurrentRow.Cells["colID"].Value;
                fullExamData = _publicExams.FirstOrDefault(x => x.Id == examId);
            }

            if (fullExamData == null) return;

            try
            {
                if (fullExamData.ExamQuestions == null || fullExamData.ExamQuestions.Count == 0)
                {
                    // Nạp câu hỏi (Dùng Task.Run để không lag)
                    fullExamData.ExamQuestions = await _examService.LoadExamQuestionsAsync(fullExamData.Id);
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
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi khi xuất file: {ex.Message}");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataTable();
        }

        private void dgvPublicExams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPublicExams.ClearSelection();
        }

    }
}
