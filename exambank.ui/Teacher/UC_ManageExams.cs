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

        private async void UC_ManageExams_Load(object sender, EventArgs e)
        {
            await LoadDataTable();
            dgvExams.AutoGenerateColumns = false;

            // Reload dữ liệu mỗi khi UC được hiển thị lại (chuyển tab)
            this.VisibleChanged += async (s, args) =>
            {
                if (this.Visible)
                {
                    await LoadDataTable();
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
            try
            {
                var newData = await _examService.GetExamsAsync(_loginUser.Id);
                _currentExams.Clear();
                foreach (var item in newData)
                {
                    _currentExams.Add(item);
                }
                InitControlDataAsync(_currentExams);
                BindGrid(_currentExams);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi LoadDataTable (Exams): " + ex.Message);
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
                        card.SelectionChanged += Card_SelectionChanged;
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
                    fullExamData.ExamQuestions = await _examService.LoadExamQuestionsAsync(fullExamData.Id);
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

        private async void miDelete_Click(object sender, EventArgs e)
        {
            var exam = GetSelectedExam();
            if (exam == null) return;

            if (exam.IsShared && exam.ApprovalStatus == ApprovalStatus.Approved)
            {
                var result = MessageBox.Show(
                    $"Đề thi \"{exam.Title}\" đã được chia sẻ lên ngân hàng chung và được duyệt.\nBạn có muốn HỦY CHIA SẺ đề thi này không?\n\n- [Yes/Có]: Hủy chia sẻ (Xóa hoàn toàn)\n- [No/Không]: Không hủy chia sẻ (Vẫn giữ trên ngân hàng)",
                    "Xác nhận hủy chia sẻ",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Cancel)
                {
                    return; // Nhấn X hoặc Cancel thì thoát ra không xóa nữa
                }
                
                // Bước xác nhận xóa khỏi kho cá nhân
                if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa đề thi \"{exam.Title}\" khỏi kho cá nhân của bạn không?"))
                {
                    if (result == DialogResult.Yes)
                    {
                        // Yes => Xóa hoàn toàn
                        if (await _examService.DeleteExamsAsync(new List<int> { exam.Id }))
                        {
                            UIMessageTip.ShowOk("Đã xóa và hủy chia sẻ thành công.");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        // No => Chuyển quyền sở hữu cho Admin để khỏi hiện ở kho cá nhân
                        if (await _examService.TransferExamOwnershipToAdminAsync(exam.Id))
                        {
                            UIMessageTip.ShowOk("Đã xóa khỏi kho cá nhân, đề thi vẫn còn trên ngân hàng chung.");
                        }
                    }
                    await LoadDataTable();
                }
                return;
            }

            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa đề thi \"{exam.Title}\"?"))
            {
                if (await _examService.DeleteExamsAsync(new List<int> { exam.Id }))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công.");
                    await LoadDataTable();
                }
            }
        }

        private async void btnSelectDelete_Click(object sender, EventArgs e)
        {
            var selectedExams = GetSelectedExamsFromCards();
            if (selectedExams.Count == 0) return;

            var sharedExams = selectedExams.Where(x => x.IsShared && x.ApprovalStatus == ApprovalStatus.Approved).ToList();
            var unsharedExams = selectedExams.Where(x => !(x.IsShared && x.ApprovalStatus == ApprovalStatus.Approved)).ToList();

            if (sharedExams.Count > 0)
            {
                var result = MessageBox.Show(
                    $"Trong số {selectedExams.Count} đề thi bạn chọn, có {sharedExams.Count} đề thi ĐÃ ĐƯỢC CHIA SẺ lên ngân hàng chung.\nBạn có muốn HỦY CHIA SẺ các đề thi này không?\n\n- [Yes/Có]: Hủy chia sẻ (Xóa hoàn toàn)\n- [No/Không]: Không hủy chia sẻ (Vẫn giữ trên ngân hàng)",
                    "Xác nhận hủy chia sẻ",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Cancel)
                {
                    return; // Nhấn X hoặc Cancel thì thoát ra không xóa nữa
                }
                
                // Bước xác nhận xóa khỏi kho cá nhân
                if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa {selectedExams.Count} đề thi đã chọn khỏi kho cá nhân không?"))
                {
                    if (result == DialogResult.Yes)
                    {
                        // Xóa tất cả
                        var idsToDelete = selectedExams.Select(x => x.Id).ToList();
                        await _examService.DeleteExamsAsync(idsToDelete);
                        UIMessageTip.ShowOk("Đã xóa toàn bộ đề thi thành công.");
                    }
                    else if (result == DialogResult.No)
                    {
                        // Detach shared exams, delete the rest
                        foreach(var shared in sharedExams)
                        {
                            await _examService.TransferExamOwnershipToAdminAsync(shared.Id);
                        }

                        if (unsharedExams.Count > 0)
                        {
                            var idsToDelete = unsharedExams.Select(x => x.Id).ToList();
                            await _examService.DeleteExamsAsync(idsToDelete);
                        }
                        UIMessageTip.ShowOk("Đã xử lý xóa thành công.");
                    }
                    await LoadDataTable();
                }
                return;
            }

            // Trường hợp không có đề thi nào đã chia sẻ
            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn xóa {selectedExams.Count} đề thi đã chọn?"))
            {
                List<int> idsToDelete = selectedExams.Select(x => x.Id).ToList();

                if (await _examService.DeleteExamsAsync(idsToDelete))
                {
                    UIMessageTip.ShowOk("Đã xóa thành công.");
                    await LoadDataTable();
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataTable();
        }

        private void UpdateSelectionLabel()
        {
            int count = GetSelectedExamsFromCards().Count;
            lblSelect.Text = $"{count} đề thi đang được chọn";
            pnlThaoTac.Visible = count > 0;
        }

        private void Card_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionLabel();
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            // UpdateSelectionLabel();
        }

        private List<ExamModel> GetSelectedExamsFromCards()
        {
            var list = new List<ExamModel>();
            if (flpExams != null)
            {
                foreach (Control ctrl in flpExams.Controls)
                {
                    if (ctrl is exambank.ui.Common.UC_ExamCard card && card.IsSelected)
                    {
                        list.Add(card.ExamData);
                    }
                }
            }
            return list;
        }

        private async void btnSelectShare_Click(object sender, EventArgs e)
        {
            var selectedExams = GetSelectedExamsFromCards();
            if (selectedExams.Count == 0) return;

            if (UIMessageBox.ShowAsk2($"Bạn có chắc chắn muốn chia sẻ {selectedExams.Count} đề thi đã chọn?"))
            {
                int successCount = 0;
                foreach (var exam in selectedExams)
                {
                    if (exam.OriginalExamId == null && !exam.IsShared)
                    {
                        bool isSharedNow = await _examService.ToggleShareExamAsync(exam.Id);
                        if (isSharedNow)
                        {
                            successCount++;
                        }
                    }
                }
                
                if (successCount > 0)
                {
                    UIMessageBox.ShowSuccess2($"Đã chia sẻ thành công {successCount} đề thi!");
                    await LoadDataTable();
                }
                else
                {
                    UIMessageBox.ShowWarning2("Không có đề thi nào hợp lệ để chia sẻ (Đã chia sẻ rồi hoặc đề lấy từ thư viện).");
                }
            }
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
                            Grade = frm.SelectedGrade,
                            CreatedByUserId = _loginUser.Id, // ID người dùng đăng nhập
                            CreatedAt = DateTime.Now
                        };

                        // 2. Gọi hàm từ Service để xử lý
                        bool success = await _examService.CreateExamByMatrixAsync(newExam);

                        if (success)
                        {
                            UIMessageBox.ShowSuccess2("Tạo đề thi từ ma trận thành công!");
                            await LoadDataTable(); // Load lại danh sách đề thi trên Grid
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