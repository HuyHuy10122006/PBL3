using exambank.data.Models;
using exambank.logic;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormXemDe : UIForm
    {
        private ExamModel _currentExam;
        private ExamService _examService = new ExamService();
        private bool _isFromPublicBank;
        private int _currentUserId;

        public FormXemDe(ExamModel exam, bool isFromPublicBank = false, int currentUserId = 0)
        {
            InitializeComponent();
            _currentExam = exam;
            _isFromPublicBank = isFromPublicBank;
            _currentUserId = currentUserId;
        }

        private void FormXemDe_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin đề thi
            if (_currentExam != null)
            {
                txtTitle.Text = _currentExam.Title;
                lblExamCode.Text = $"Mã đề: {_currentExam.ExamCode}";
                txtExamCode.Text = _currentExam.ExamCode;
                lblMonHoc.Text = $"Môn học: {_currentExam.Subject}";
                cbMonHoc.Items.Add(_currentExam.Subject);
                cbMonHoc.Items.AddRange(Base.Constants.List_MonHoc);
                cbMonHoc.SelectedIndex = 0;
                lblTime.Text = $"Thời gian làm bài: {_currentExam.Duration} phút";
                udtTime.Text = _currentExam.Duration.ToString();
                lblTotalQuestions.Text = $"Tổng số câu hỏi: {_currentExam.ExamQuestions?.Count ?? 0}";
            }

            // Tối ưu hóa UI để tránh nháy khi load nhiều control
            flpQuestions.DoubleBuffered(true);
            LoadQuestions();

            if (_isFromPublicBank)
            {
                // Ở ngân hàng chung: Không cho sửa, chia sẻ
                btnEdit.Visible = false;
                btnShare.Visible = false;
                btnExport.Visible = false;
                btnSave.Text = "Lưu về máy"; // Xuất file Word
                btnSave.Symbol = 362830; // Icon xuất file
            }
        }

        private void LoadQuestions()
        {
            // Tạm dừng layout để tăng tốc độ thêm control
            flpQuestions.SuspendLayout();
            flpQuestions.Controls.Clear();

            if (_currentExam.ExamQuestions == null || _currentExam.ExamQuestions.Count == 0)
            {
                UIMessageBox.ShowWarning2("Đề thi này chưa có câu hỏi nào.");
                flpQuestions.ResumeLayout();
                return;
            }

            // Sắp xếp câu hỏi theo thứ tự (QuestionOrder)
            var sortedQuestions = _currentExam.ExamQuestions.OrderBy(eq => eq.QuestionOrder).ToList();

            int count = 1;
            foreach (var examQuest in sortedQuestions)
            {
                if (examQuest.Question != null)
                {
                    UC_Question uc = new UC_Question(examQuest.Question, $"Câu {count}:");
                    uc.Width = flpQuestions.ClientSize.Width - 30;
                    flpQuestions.Controls.Add(uc);
                    count++;
                }
            }
            flpQuestions.ResumeLayout(true);
        }

        // Cập nhật lại kích thước các UC khi Form hoặc FlowLayoutPanel thay đổi kích thước
        private void flpQuestions_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpQuestions.Controls)
            {
                if (ctrl is UC_Question uc)
                {
                    uc.Width = flpQuestions.ClientSize.Width - 30;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Hiển thị các control chỉnh sửa
            txtTitle.ReadOnly = !txtTitle.ReadOnly;
            txtExamCode.Visible = !txtExamCode.Visible;
            cbMonHoc.Visible = !cbMonHoc.Visible;
            udtTime.Visible = !udtTime.Visible;

            if (txtTitle.ReadOnly)
            {
                // Cập nhật lại thông tin đề thi
                UpdateExamInfo();
            }
        }

        private void UpdateUCCount(object sender, ControlEventArgs e)
        {
            // Cập nhật số lượng mỗi khi thêm hoặc xóa UC
            int count = flpQuestions.Controls.Count;
            lblTotalQuestions.Text = $"Tổng số câu hỏi: {count}";
        }

        //Hàm cập nhật thông tin đề thi từ các control ẩn sang label
        private void UpdateExamInfo()
        {
            lblExamCode.Text = $"Mã đề: {txtExamCode.Text}";
            lblMonHoc.Text = $"Môn học: {cbMonHoc.Text}";
            lblTime.Text = $"Thời gian làm bài: {udtTime.Text} phút";
        }

        // Hàm xử lý sự kiện khi nhấn nút Lưu
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isFromPublicBank)
                {
                    // XUẤT FILE WORD (Admin chỉ xuất file, không lưu đề)
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Word Document|*.docx";
                        saveFileDialog.Title = "Lưu đề thi ra file Word";
                        saveFileDialog.FileName = $"{_currentExam.Title}.docx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var docService = new DocumentService();
                            await Task.Run(() => docService.ExportToWord(saveFileDialog.FileName, _currentExam,
                                _currentExam.ExamQuestions.Select(eq => eq.Question).ToList()
                            ));

                            UIMessageBox.ShowSuccess2("Xuất file Word thành công!");
                        }
                    }
                }
                else
                {
                    // LƯU CẬP NHẬT ĐỀ THI HIỆN TẠI (TRONG NGÂN HÀNG CÁ NHÂN)
                    // 1. Cập nhật thông tin cơ bản của đề thi từ các Control trên Form
                    _currentExam.Title = txtTitle.Text.Trim();
                    _currentExam.ExamCode = txtExamCode.Text.Trim();
                    _currentExam.Subject = cbMonHoc.Text;
                    _currentExam.Duration = (int)udtTime.IntValue;

                    // 2. Thu thập danh sách câu hỏi hiện tại từ UI
                    var updatedQuestions = new List<ExamQuestionModel>();
                    int currentOrder = 1;

                    // Duyệt qua từng UC để lấy dữ liệu
                    foreach (Control ctrl in flpQuestions.Controls)
                    {
                        if (ctrl is UC_Question uc)
                        {
                            QuestionModel qData = uc.GetData();
                            if (qData != null)
                            {
                                // 1. Tìm ExamQuestion cũ trong danh sách của Đề thi
                                var examQuest = _currentExam.ExamQuestions.FirstOrDefault(eq => eq.QuestionId == qData.Id);

                                if (examQuest != null)
                                {
                                    examQuest.Question = qData;
                                }
                                else
                                {
                                    examQuest = new ExamQuestionModel { ExamId = _currentExam.Id, QuestionId = qData.Id, Question = qData };
                                }

                                // 2. Cập nhật số thứ tự câu hỏi dựa trên vị trí hiện tại trên UI
                                examQuest.QuestionOrder = currentOrder++;
                                updatedQuestions.Add(examQuest);
                            }
                        }
                    }

                    // 3. Cập nhật lại danh sách ExamQuestions của Model
                    _currentExam.ExamQuestions = updatedQuestions;
                    _currentExam.TotalQuestions = updatedQuestions.Count;

                    // 4. Gọi Service
                    bool isSuccess = await _examService.UpdateExamAsync(_currentExam);

                    if (isSuccess)
                    {
                        UIMessageBox.ShowSuccess2("Cập nhật đề thi thành công!");

                        // Chuyển về chế độ xem (Read Only)
                        if (!txtTitle.ReadOnly) btnEdit_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Có lỗi xảy ra khi lưu: " + ex.Message);
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Word Document|*.docx";
                    saveFileDialog.Title = "Lưu đề thi ra file Word";
                    saveFileDialog.FileName = $"{_currentExam.Title}.docx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var docService = new DocumentService();
                        // Chạy tác vụ xuất file trên một luồng khác để tránh treo UI nếu file nặng
                        await Task.Run(() => docService.ExportToWord(saveFileDialog.FileName, _currentExam,
                            _currentExam.ExamQuestions.Select(eq => eq.Question).ToList()
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

        private void btnShare_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo2("Chức năng chưa có.");
        }
    }
}
