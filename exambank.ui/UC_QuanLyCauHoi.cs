using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using exambank.data;
using exambank.data.Models;

namespace exambank.ui
{
    public partial class UC_QuanLyCauHoi : UserControl
    {
        public UC_QuanLyCauHoi()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += UC_QuanLyCauHoi_Load;
                dgvQuestions.DataBindingComplete += DgvQuestions_DataBindingComplete;
                dgvQuestions.DataError += DgvQuestions_DataError;
            }
        }

        private void DgvQuestions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Bỏ qua lỗi DataError của DataGridView để tránh bị spam hộp thoại lỗi
            e.ThrowException = false;
        }

        private async void UC_QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return; // Tránh chạy DB lúc thiết kế giao diện
            await LoadDataAsync();
        }

        private async System.Threading.Tasks.Task LoadDataAsync()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var repo = new DatabaseRepository(db);
                    var questions = await repo.GetAllQuestionsAsync();
                    
                    // Chuyển danh sách sang BindingList hoặc DataSource
                    var bindingList = new BindingList<QuestionModel>(questions);
                    dgvQuestions.DataSource = bindingList;
                }
            }
            catch (Exception ex)
            {
                // Thay vì hiển thị MessageBox làm block UI, in log ra màn hình Console/Debug hoặc UI Label
                Console.WriteLine($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void DgvQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] visibleCols = { "Id", "Question", "OptionA", "OptionB", "OptionC", "OptionD", "Answer", "CreatedAt" };
            foreach (DataGridViewColumn col in dgvQuestions.Columns)
            {
                if (Array.Exists(visibleCols, c => c == col.Name))
                {
                    col.Visible = true;
                    // Đặt tiêu đề cho đẹp
                    if(col.Name == "Id") { col.HeaderText = "ID"; col.Width = 60; }
                    if(col.Name == "Question") col.HeaderText = "Câu hỏi";
                    if(col.Name == "OptionA") col.HeaderText = "Đáp án A";
                    if(col.Name == "OptionB") col.HeaderText = "Đáp án B";
                    if(col.Name == "OptionC") col.HeaderText = "Đáp án C";
                    if(col.Name == "OptionD") col.HeaderText = "Đáp án D";
                    if(col.Name == "Answer") col.HeaderText = "Đáp án đúng";
                    if(col.Name == "CreatedAt") { col.HeaderText = "Ngày tạo"; col.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; }
                }
                else
                {
                    col.Visible = false;
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        // Thêm hàm public để FormGiaoVien gọi Refresh khi chuyển tab
        public async void RefreshData()
        {
            await LoadDataAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa câu hỏi đã chọn?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var db = new ExamBankDbContext())
                    {
                        var repo = new DatabaseRepository(db);
                        foreach (DataGridViewRow row in dgvQuestions.SelectedRows)
                        {
                            if (row.DataBoundItem is QuestionModel q)
                            {
                                await repo.DeleteQuestionAsync(q.Id);
                            }
                        }
                    }
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync(); // Cập nhật lại grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa câu hỏi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}