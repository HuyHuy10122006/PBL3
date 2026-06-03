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
    public partial class UC_ExamBank : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly ExamService _examService = new ExamService();
        private List<ExamModel> _allSharedExams = new List<ExamModel>();
        private FlowLayoutPanel flpExams;

        public UC_ExamBank(UserModel loginUser)
        {
            InitializeComponent();
            _loginUser = loginUser;

            // Khởi tạo FlowLayoutPanel thay thế DataGridView
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

            // Khởi tạo combo trạng thái
            cboTT.Items.Clear();
            cboTT.Items.AddRange(new object[] { "Tất cả", "Chờ duyệt", "Đã duyệt", "Từ chối" });
            cboTT.SelectedIndex = 0;
        }

        private void UC_ViewExamBank_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            dgvPublicExams.AutoGenerateColumns = false;

            // Reload dữ liệu mỗi khi UC được hiển thị lại
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
        }

        private async Task LoadDataTable()
        {
            var newData = await Task.Run(() => _examService.GetSharedExamsAllStatusAsync());
            _allSharedExams.Clear();
            foreach (var item in newData)
            {
                _allSharedExams.Add(item);
            }
            InitControlDataAsync(_allSharedExams);
            Filter();
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
                        Text = "📭 Không có đề thi nào phù hợp",
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
                        // showActions = true để hiện nút ⋮ cho Admin duyệt
                        var card = new exambank.ui.Common.UC_ExamCard(exam, true);
                        card.ActionClicked += Card_ActionClicked;
                        flpExams.Controls.Add(card);
                    }
                }

                // Cập nhật đếm
                int pendingCount = data.Count(e => e.ApprovalStatus == ApprovalStatus.Pending);
                uiPanel2.Text = $"Danh sách đề thi ({data.Count} đề" +
                    (pendingCount > 0 ? $" - {pendingCount} chờ duyệt)" : ")");

                flpExams.ResumeLayout();
            }
        }

        private void Card_ActionClicked(object sender, exambank.ui.Common.ExamCardEventArgs e)
        {
            if (e.Action == "More")
            {
                var exam = e.Exam;

                // Cập nhật text menu dựa theo trạng thái
                miExport.Text = exam.ApprovalStatus == ApprovalStatus.Approved ? "Hủy duyệt" : "✓ Duyệt";
                miExport.Visible = exam.ApprovalStatus != ApprovalStatus.Approved || exam.ApprovalStatus == ApprovalStatus.Approved;
                miSave.Text = exam.ApprovalStatus == ApprovalStatus.Rejected ? "Đã từ chối" : "✗ Từ chối";
                miSave.Enabled = exam.ApprovalStatus != ApprovalStatus.Rejected;

                cmsActions.Tag = exam;
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
                    exam.ExamQuestions = await Task.Run(() => _examService.LoadExamQuestionsAsync(exam.Id));
                }
                using (FormXemDe frm = new FormXemDe(exam))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        // ========== XỬ LÝ DUYỆT / TỪ CHỐI ==========

        private async void miExport_Click(object sender, EventArgs e)
        {
            if (cmsActions.Tag is not ExamModel exam) return;

            try
            {
                if (exam.ApprovalStatus == ApprovalStatus.Approved)
                {
                    // Hủy duyệt -> quay về Pending
                    var repo = new exambank.data.DatabaseRepository(new exambank.data.ExamBankDbContext());
                    var freshExam = await repo.GetExamByIdAsync(exam.Id);
                    if (freshExam != null)
                    {
                        freshExam.ApprovalStatus = ApprovalStatus.Pending;
                        await repo.UpdateExamAsync(freshExam);
                        UIMessageTip.ShowOk("Đã hủy duyệt đề thi.");
                    }
                }
                else
                {
                    // Duyệt đề thi
                    bool success = await _examService.ApproveExamAsync(exam.Id);
                    if (success)
                    {
                        UIMessageTip.ShowOk("Đã duyệt đề thi thành công!");
                    }
                }
                await LoadDataTable();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private async void miSave_Click(object sender, EventArgs e)
        {
            if (cmsActions.Tag is not ExamModel exam) return;

            try
            {
                // Hỏi lý do từ chối
                string reason = "";
                using (var inputForm = CreateReasonInputForm())
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        reason = inputForm.Tag as string ?? "";
                    }
                    else
                    {
                        return; // Hủy bỏ
                    }
                }

                bool success = await _examService.RejectExamAsync(exam.Id, reason);
                if (success)
                {
                    UIMessageTip.ShowOk("Đã từ chối đề thi.");
                    await LoadDataTable();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Lỗi: {ex.Message}");
            }
        }

        private void miView_Click(object sender, EventArgs e)
        {
            if (cmsActions.Tag is ExamModel exam)
            {
                ViewExamDetail(exam);
            }
        }

        /// <summary>
        /// Tạo form nhập lý do từ chối
        /// </summary>
        private Form CreateReasonInputForm()
        {
            var form = new Form
            {
                Text = "Lý do từ chối",
                Size = new Size(450, 220),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            var lblTitle = new Label
            {
                Text = "Nhập lý do từ chối đề thi:",
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 11f, FontStyle.Bold)
            };

            var txtReason = new TextBox
            {
                Location = new Point(20, 45),
                Size = new Size(395, 80),
                Multiline = true,
                Font = new Font("Segoe UI", 10f),
                PlaceholderText = "VD: Đề thi chưa đạt yêu cầu về nội dung..."
            };

            var btnOk = new Button
            {
                Text = "Xác nhận từ chối",
                Location = new Point(190, 140),
                Size = new Size(130, 35),
                BackColor = Color.FromArgb(244, 67, 54),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                DialogResult = DialogResult.OK
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += (s, e) =>
            {
                form.Tag = txtReason.Text.Trim();
            };

            var btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(330, 140),
                Size = new Size(85, 35),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10f),
                DialogResult = DialogResult.Cancel
            };
            btnCancel.FlatAppearance.BorderSize = 1;

            form.Controls.AddRange(new Control[] { lblTitle, txtReason, btnOk, btnCancel });
            form.AcceptButton = btnOk;
            form.CancelButton = btnCancel;

            return form;
        }

        // ========== LỌC ==========

        private void Filter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string subject = cbSubject.Text;
            string statusFilter = cboTT.Text;

            var filtered = _allSharedExams.Where(e =>
                (string.IsNullOrWhiteSpace(keyword) || 
                 e.Title.ToLower().Contains(keyword) || 
                 e.ExamCode.ToLower().Contains(keyword) ||
                 (e.Author?.FullName?.ToLower().Contains(keyword) ?? false)) &&
                (subject == "Tất cả" || e.Subject == subject) &&
                (statusFilter == "Tất cả" ||
                 (statusFilter == "Chờ duyệt" && e.ApprovalStatus == ApprovalStatus.Pending) ||
                 (statusFilter == "Đã duyệt" && e.ApprovalStatus == ApprovalStatus.Approved) ||
                 (statusFilter == "Từ chối" && e.ApprovalStatus == ApprovalStatus.Rejected))
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
            // Giữ lại cho backward compatibility nhưng DataGridView đã ẩn
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
