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

        private void UC_AICreate_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            try
            {
                // 1. Nạp dữ liệu Khối (THPT)
                cbKhoi.Items.Clear();
                cbKhoi.Items.AddRange(new object[] { "Lớp 6", "Lớp 7", "Lớp 8", "Lớp 9", "Lớp 10", "Lớp 11", "Lớp 12" });

                // 2. Nạp dữ liệu Độ khó (Sử dụng uiComboBox1)
                cbDoKho.Items.Clear();
                cbDoKho.Items.AddRange(new object[] { "Nhận biết", "Thông hiểu", "Vận dụng", "Vận dụng cao" });

                // 3. Nạp dữ liệu Môn học (Ưu tiên Database, nếu trống thì dùng danh sách mặc định)
                cbMonHoc.Items.Clear();

                using (var db = new ExamBankDbContext()) // Thay bằng DbContext của bạn
                {
                    var dbCategories = db.Categories
                                         .Where(c => c.IsActive)
                                         .OrderBy(c => c.Name)
                                         .Select(c => c.Name)
                                         .ToList();

                    //if (dbCategories.Count > 0)
                    if(false)
                    {
                        foreach (var cat in dbCategories) cbMonHoc.Items.Add(cat);
                    }
                    else
                    {
                        // Danh sách môn học THPT cố định nếu Database chưa có dữ liệu mẫu
                        string[] defaultSubjects = {
                    "Toán học", "Vật lý", "Hóa học", "Sinh học",
                    "Ngữ văn", "Lịch sử", "Địa lý", "Tiếng Anh",
                    "Tin học", "GDCD"
                };
                        cbMonHoc.Items.AddRange(defaultSubjects);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi khởi tạo dữ liệu: " + ex.Message, "Lỗi hệ thống",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateExam_Click_(object sender, EventArgs e)
        {
            var listQuestions = new List<QuestionModel>
            {
                new QuestionModel {
                    Id = 1,
                    Question = "Lập trình C# thuộc nền tảng nào?",
                    OptionA = ".NET Framework",
                    OptionB = "Java Virtual Machine",
                    OptionC = "Python Runtime",
                    OptionD = "",
                    Answer = "A",
                    Explanation = "C# là ngôn ngữ lập trình thuộc nền tảng .NET Framework."
                },
                new QuestionModel {
                    Id = 2,
                    Question = "WinForms dùng để phát triển ứng dụng gì?",
                    OptionA = "Web",
                    OptionB = "Desktop (Window)",
                    OptionC = "Mobile",
                    OptionD = "",
                    Answer = "B",
                    Explanation = "WinForms là một framework để phát triển ứng dụng Desktop trên Windows."
                },
                new QuestionModel {
                    Id = 3,
                    // Câu hỏi rất dài để test việc xuống dòng
                    Question = "Trong kiến trúc phần mềm hiện đại, việc sử dụng các Design Patterns như Dependency Injection, Factory Pattern kết hợp với mô hình Microservices đòi hỏi lập trình viên phải hiểu rõ về cơ chế quản lý bộ nhớ và vòng đời của đối tượng. Bạn hãy cho biết lợi ích lớn nhất của việc tách biệt Business Logic ra khỏi Data Access Layer là gì?",
    
                    // Các đáp án có cái ngắn, có cái rất dài
                    OptionA = "Tăng khả năng bảo trì và dễ dàng viết Unit Test cho từng thành phần độc lập.",
                    OptionB = "Làm cho ứng dụng chạy nhanh hơn 200% do giảm thiểu số lượng câu lệnh SQL thực thi trực tiếp trên luồng chính của hệ thống.",
                    OptionC = "Giúp giao diện người dùng (UI) tự động đẹp hơn mà không cần can thiệp vào CSS hoặc các thư viện UI bên thứ ba như SunnyUI hay MaterialSkin.",
                    OptionD = "Đây là một quy trình bắt buộc trong mọi dự án phần mềm theo tiêu chuẩn ISO-9001 và nếu không thực hiện thì mã nguồn sẽ không thể biên dịch được trên môi trường Production.",
                    Answer = "A",
                    Explanation = "Tách biệt Business Logic ra khỏi Data Access Layer giúp tăng khả năng bảo trì và dễ dàng viết Unit Test cho từng thành phần độc lập."
                }
            };

            LoadAllQuestions(listQuestions);
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

                    // Gợi ý: Có thể hiển thị một thông báo nhỏ khi chọn file thành công
                    UIMessageTip.ShowOk("Đã nhận file: " + ofd.SafeFileName);

                    // Bạn có thể thêm logic đọc nội dung file ở đây nếu muốn hiển thị preview ngay
                }
            }
        }

        private async void btnCreateExam_Click(object sender, EventArgs e)
        {
            string inputData = ""; // Biến chứa nội dung văn bản hoặc đường dẫn file
            bool isFilePath = false; // Cờ đánh dấu để AI Service biết cách xử lý

            // 1. Kiểm tra nguồn dữ liệu dựa trên Tab đang chọn
            if (tabSource.SelectedIndex == 0) // Giả định Tab 0 là tpFile
            {
                if (string.IsNullOrEmpty(txtFilePath.Text))
                {
                    MessageBox.Show("Vui lòng chọn file tài liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                inputData = txtFilePath.Text;
                isFilePath = true;
            }
            else // Tab 1 là tpText (Nhập văn bản trực tiếp)
            {
                if (string.IsNullOrWhiteSpace(txtText.Text)) // Giả sử TextBox nhập liệu là txtText
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
                int soCau = (int)udtSL.IntValue;

                // 3. Gọi AI thực tế 
                var questions = await aiService.GenerateQuestionsAsync(inputData, monHoc, doKho, soCau, isFilePath);

                // 4. Hiển thị kết quả
                if (questions != null && questions.Count > 0)
                {
                    LoadAllQuestions(questions);
                    lblExamInfo.Text = $"Tổng: {questions.Count} câu  |  Thời gian: {udtTG.IntValue} phút";
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
    }
}
