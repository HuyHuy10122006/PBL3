using exambank.data.Models;
using exambank.logic;
using exambank.ui.Base;
using exambank.logic.Service;
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
    public partial class UC_ManageExams : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly ExamService _examService = new ExamService();
        private List<ExamModel> _currentExams;
        private FlowLayoutPanel flpExams;

        public UC_ManageExams(UserModel loginUser, List<ExamModel> exams)
        {
            InitializeComponent();
            _loginUser = loginUser;
            _currentExams = exams;

            flpExams = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(15),
                BackColor = Color.FromArgb(245, 247, 250),
                WrapContents = true
            };
            dgvExams.Visible = false;
            dgvExams.Parent.Controls.Add(flpExams);
            flpExams.BringToFront();
        }

        private void UC_ManageExams_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            dgvExams.AutoGenerateColumns = false;

            // Reload dữ liệu mỗi khi UC được hiển thị lại (chuyển tab)
            this.VisibleChanged += (s, args) =>
            {
                if (this.Visible)
                {
                    LoadDataTable();
                }
            };
        }

        private void InitControlDataAsync(List<ExamModel> data)
        {

            List<string> subjects = _examService.GetCboValues(data, e => e.Subject);
            subjects.Insert(0, "Tất cả");
            cbSubject.DataSource = subjects;

            //List<string> grades = _examService.GetCboValues(_currentExams, q => q.Grade);
            //grades.Insert(0, "Tất cả");
            //cbGrade.DataSource = grades;
        }

        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _examService.GetExamsAsync(_loginUser.Id));
            _currentExams.Clear();
            foreach (var item in newData)
            {
                _currentExams.Add(item);
            }
            InitControlDataAsync(_currentExams);
            BindGrid(_currentExams);
        }

        private void BindGrid(List<ExamModel> data)
        {
            if (flpExams != null)
            {
                flpExams.SuspendLayout();
                flpExams.Controls.Clear();

                if (data.Count == 0)
                {
                    var lblEmpty = new Label
                    {
                        Text = "📝 Bạn chưa có đề thi nào. Hãy tạo đề thi mới!",
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
                        var card = new exambank.ui.Common.UC_ExamCard(exam, true);
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
                miShare.Text = e.Exam.IsShared ? "Hủy chia sẻ" : "Chia sẻ";
                Rectangle rect = e.SourceControl.ClientRectangle;
                cmsActions.Tag = e.Exam;
                cmsActions.Show(e.SourceControl, rect.Left, rect.Bottom);
            }
            else if (e.Action == "View")
            {
                cmsActions.Tag = e.Exam;
                miView_Click(null, EventArgs.Empty);
            }
        }

        private void Filter()
        {
            // Logic lọc nhanh trên list hiện tại
            string keyword = txtSearch.Text.Trim().ToLower();
            string subject = cbSubject.Text;
            //string grade = cbGrade.Text;

            var filtered = _currentExams.Where(e =>
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

        private void dgvExams_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            // Kiểm tra chuột trái và đúng cột thao tác
            if (e.Button == MouseButtons.Left && dgvExams.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Chọn hàng đó luôn
                dgvExams.CurrentCell = dgvExams.Rows[e.RowIndex].Cells[e.ColumnIndex];

                int examId = (int)dgvExams.Rows[e.RowIndex].Cells["colID"].Value;
                var ext = _currentExams.FirstOrDefault(x => x.Id == examId);
                if (ext != null)
                {
                    miShare.Text = ext.IsShared ? "Hủy chia sẻ" : "Chia sẻ";
                }

                Rectangle rect = dgvExams.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsActions.Show(dgvExams, rect.Left, rect.Bottom);
            }
        }

        private ExamModel GetSelectedExam()
        {
            if (cmsActions.Tag is ExamModel exam) return exam;
            if (dgvExams.CurrentRow != null)
            {
                int examId = (int)dgvExams.CurrentRow.Cells["colID"].Value;
                return _currentExams.FirstOrDefault(x => x.Id == examId);
            }
            return null;
        }

        private async void miView_Click(object sender, EventArgs e)
        {
            var fullExamData = GetSelectedExam();
            if (fullExamData == null) return;

            try
            {
                if (fullExamData.ExamQuestions == null || fullExamData.ExamQuestions.Count == 0)
                {
                    fullExamData.ExamQuestions = await Task.Run(() => _examService.LoadExamQuestionsAsync(fullExamData.Id));
                }

                using (FormXemDe frm = new FormXemDe(fullExamData))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miShare_Click(object sender, EventArgs e)
        {
            var exam = GetSelectedExam();
            if (exam == null) return;

            // Chặn chia sẻ đề clone từ ngân hàng chung
            if (exam.OriginalExamId != null)
            {
                UIMessageBox.ShowWarning2("Đề thi này được lưu từ Ngân hàng đề thi chung nên không thể chia sẻ lại.\nBạn chỉ có thể chia sẻ đề thi do chính mình tạo.");
                return;
            }

            try
            {
                bool isSharedNow = await _examService.ToggleShareExamAsync(exam.Id);
                exam.IsShared = isSharedNow;
                if (isSharedNow)
                {
                    exam.ApprovalStatus = ApprovalStatus.Pending;
                    BindGrid(_currentExams);
                    UIMessageBox.ShowSuccess2("Đã gửi đề thi chờ Admin duyệt!\nĐề thi sẽ hiển thị trên ngân hàng chung sau khi được phê duyệt.");
                }
                else
                {
                    exam.ApprovalStatus = ApprovalStatus.None;
                    BindGrid(_currentExams);
                    UIMessageBox.ShowSuccess2("Đã hủy chia sẻ đề thi!");
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miExport_Click(object sender, EventArgs e)
        {
            var fullExamData = GetSelectedExam();
            if (fullExamData == null) return;

            try
            {
                if (fullExamData.ExamQuestions == null || fullExamData.ExamQuestions.Count == 0)
                {
                    // Nạp câu hỏi (Dùng Task.Run để không lag)
                    fullExamData.ExamQuestions = await Task.Run(() => _examService.LoadExamQuestionsAsync(fullExamData.Id));
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

        private async void miDelete_Click(object sender, EventArgs e)
        {
            var exam = GetSelectedExam();
            if (exam == null) return;

            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa đề thi \"{exam.Title}\"?"))
            {
                if (await _examService.DeleteExamsAsync(new List<int> { exam.Id }))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công.");
                    LoadDataTable();
                }
            }
        }

        private async void btnSelectDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvExams.SelectedRows;
            if (selectedRows.Count == 0) return;

            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa {selectedRows.Count} đề thi đã chọn?"))
            {
                List<int> idsToDelete = new List<int>();
                foreach (DataGridViewRow row in selectedRows)
                {
                    idsToDelete.Add((int)row.Cells["colID"].Value);
                }

                if (await _examService.DeleteExamsAsync(idsToDelete))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công.");
                    LoadDataTable();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            int count = dgvExams.SelectedRows.Count;
            lblSelect.Text = $"{count} đề thi đang được chọn";
            pnlThaoTac.Visible = count > 0;
        }

        private void btnSelectShare_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Chưa có.");
        }

        private async void btnCreateExamByMatrix_Click(object sender, EventArgs e)
        {
            using (var frm = new FormTaoDe_MaTran())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    try
                    {
                        // 1. Tạo đối tượng ExamModel từ dữ liệu trên Form
                        var newExam = new ExamModel
                        {
                            Title = frm.ExamTitle,
                            ExamCode = frm.ExamCode,
                            Duration = frm.Duration,
                            TotalQuestions = frm.QuestionCount,
                            Subject = frm.SelectedSubject,
                            CreatedByUserId = _loginUser.Id, // ID người dùng đăng nhập
                            CreatedAt = DateTime.Now
                        };

                        // 2. Gọi hàm từ Service để xử lý
                        bool success = await _examService.CreateExamByMatrixAsync(newExam);

                        if (success)
                        {
                            UIMessageBox.ShowSuccess2("Tạo đề thi từ ma trận thành công!");
                            LoadDataTable(); // Load lại danh sách đề thi trên Grid
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị các lỗi từ tầng Service
                        UIMessageBox.ShowError2(ex.Message);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void dgvExams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvExams.ClearSelection();
        }
    }
}