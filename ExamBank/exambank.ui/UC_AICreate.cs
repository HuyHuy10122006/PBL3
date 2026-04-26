using exambank.data;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using exambank.data.Models;

namespace exambank.ui
{
    public partial class UC_AICreate : UserControl
    {
        public UC_AICreate()
        {
            InitializeComponent();
        }

        private void UC_AICreate_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            try
            {
                // 1. Nạp dữ liệu Khối
                cbKhoi.Items.Clear();
                cbKhoi.Items.AddRange(new object[] { "Lớp 1", "Lớp 2", "Lớp 3", "Lớp 4", "Lớp 5", "Lớp 6", "Lớp 7", "Lớp 8", "Lớp 9", "Lớp 10", "Lớp 11", "Lớp 12" });

                // 2. Nạp dữ liệu Độ khó
                cbDoKho.Items.Clear();
                cbDoKho.Items.AddRange(new object[] { "Nhận biết", "Thông hiểu", "Vận dụng", "Vận dụng cao" });

                // 3. Nạp dữ liệu Môn học
                cbMonHoc.Items.Clear();
                string[] defaultSubjects = {
                    "Toán học", "Vật lý", "Hóa học", "Sinh học",
                    "Ngữ văn", "Lịch sử", "Địa lý", "Tiếng Anh",
                    "Tin học", "GDCD"
                };
                cbMonHoc.Items.AddRange(defaultSubjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi khởi tạo dữ liệu: " + ex.Message, "Lỗi hệ thống",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Thiết lập bộ lọc file
                ofd.Filter = "Document Files|*.pdf;*.docx;*.txt|All Files|*.*";
                ofd.Title = "Chọn tài liệu nguồn để tạo đề thi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn lên TextBox
                    txtFilePath.Text = ofd.FileName;
                    UIMessageTip.ShowOk("Chọn file thành công.");
                    // logic đọc nội dung file...
                }
            }
        }

        private async void btnCreateExam_Click(object sender, EventArgs e)
        {
            string inputData = "";
            bool isFilePath = false;

            // 1. Kiểm tra nguồn dữ liệu dựa trên Tab đang chọn
            if (tabSource.SelectedIndex == 0) // Tab 0 là tpFile
            {
                if (string.IsNullOrEmpty(txtFilePath.Text))
                {
                    MessageBox.Show("Vui lòng chọn file tài liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                inputData = txtFilePath.Text;
                isFilePath = true;
            }
            else // Tab 1 là tpText
            {
                if (string.IsNullOrWhiteSpace(txtText.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung văn bản để AI phân tích!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                inputData = txtText.Text;
                isFilePath = false;
            }

            // 2. Thiết lập trạng thái UI
            btnCreateExam.Enabled = false;
            btnCreateExam.Text = "AI đang soạn đề...";

            try
            {
                AIServiceTest aiService = new AIServiceTest();

                // Thu thập cấu hình từ UI
                string monHoc = cbMonHoc.Text;
                string doKho = cbDoKho.Text;
                int soCau = (int)iudSL.Value;

                // 3. Gọi AI
                var questions = await aiService.GenerateQuestionsAsync(inputData, monHoc, doKho, soCau, isFilePath);

                // 4. Hiển thị kết quả
                if (questions != null && questions.Count > 0)
                {
                    LoadAllQuestions(questions);
                    lblExamInfo.Text = $"Tổng: {questions.Count} câu  |  Thời gian: {iudTG.Value} phút";
                }
                else
                {
                    MessageBox.Show("AI không thể tạo được câu hỏi từ nội dung này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCreateExam.Enabled = true;
                btnCreateExam.Text = "TẠO ĐỀ THI";
            }
        }
        public async void LoadAllQuestions(List<QuestionModel> questions)
        {
            flpPreview.SuspendLayout();
            flpPreview.Controls.Clear();

            foreach (var item in questions)
            {
                UC_Question uc = new UC_Question();
                uc.SetData(item, questions.IndexOf(item) + 1);

                // Đảm bảo UC luôn khít chiều ngang của Panel cha
                uc.Width = flpPreview.ClientSize.Width - (flpPreview.Padding.Left + flpPreview.Padding.Right + 10);

                uc.Margin = new Padding(0, 0, 0, 20);
                flpPreview.Controls.Add(uc);
            }
            flpPreview.ResumeLayout(true);
        }
    }
}
