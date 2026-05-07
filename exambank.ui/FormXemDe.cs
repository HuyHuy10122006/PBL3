using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using exambank.data.Models;
using Sunny.UI;

namespace exambank.ui
{
    public partial class FormXemDe : UIForm
    {
        private ExamModel _currentExam;

        public FormXemDe(ExamModel exam)
        {
            InitializeComponent();
            _currentExam = exam;

            // Tối ưu hóa UI để tránh nháy khi load nhiều control
            flpQuestions.DoubleBuffered(true);

            this.Text = $"Đề thi: {_currentExam.Title}";
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            // Tạm dừng layout để tăng tốc độ thêm control
            flpQuestions.SuspendLayout();
            flpQuestions.Controls.Clear();

            if (_currentExam.ExamQuestions == null || _currentExam.ExamQuestions.Count == 0)
            {
                UIMessageBox.ShowInfo("Đề thi này chưa có câu hỏi nào.");
                flpQuestions.ResumeLayout();
                return;
            }

            // Sắp xếp câu hỏi theo thứ tự (QuestionOrder)
            var sortedQuestions = _currentExam.ExamQuestions
                                              .OrderBy(eq => eq.QuestionOrder)
                                              .ToList();

            int count = 1;
            foreach (var examQuest in sortedQuestions)
            {
                if (examQuest.Question != null)
                {
                    // Khởi tạo UserControl hiển thị câu hỏi
                    UC_Question uc = new UC_Question();

                    // Thiết lập chiều rộng của UC bằng với FlowLayoutPanel (trừ đi scrollbar)
                    uc.Width = flpQuestions.ClientSize.Width - 25;

                    // Gán dữ liệu vào UC
                    // Header sẽ hiển thị "Câu 1:", "Câu 2:", ...
                    uc.SetData(examQuest.Question, $"Câu {count}:");

                    // Thêm vào FlowLayoutPanel
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
                    uc.Width = flpQuestions.ClientSize.Width - 25;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Helper class để giảm giật lag khi cuộn
    public static class ControlExtensions
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            prop?.SetValue(control, enabled, null);
        }
    }
}