using exambank.data.Models;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_TrangChu : UserControl
    {
        private UserModel _loginUser;
        private QuestionService _questionService = new QuestionService();
        private ExamService _examService = new ExamService();
        private List<ExamModel> _recentExams = new List<ExamModel>();
        public UC_TrangChu(UserModel loginUser)
        {
            InitializeComponent();
            _loginUser = loginUser;
            this.Load += UC_TrangChu_Load;
        }

        private async void UC_TrangChu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Chào mừng {_loginUser.FullName} trở lại với hệ thống EduGenAI!";

            await LoadRealStatistics();

            //Lấy Rentent Exams (Đề thi gần đây) để hiển thị lên bảng
            _recentExams = await _examService.GetRecentExamsAsync(_loginUser.Id);
            LoadRecentExams();
        }

        private async Task LoadRealStatistics()
        {
            try
            {
                // Đếm tổng câu hỏi 
                lblTotalQuestions.Text = (await _questionService.GetQuestionsAsync(_loginUser.Id)).Count.ToString();

                // Đếm tổng đề thi 
                lblTotalExams.Text = (await _examService.GetExamsAsync(_loginUser.Id)).Count.ToString();

                // Đếm tổng môn học 
                lblTotalSubjects.Text = (await _questionService.GetUserSubjectsAsync(_loginUser.Id)).Count.ToString();
            }
            catch (Exception ex)
            {
                // Nếu DB chưa có bảng hoặc sai tên bảng, tạm thời hiện 0
                Debug.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
                lblTotalQuestions.Text = "0";
                lblTotalExams.Text = "0";
                lblTotalSubjects.Text = "0";
            }
        }

        private void LoadRecentExams()
        {
            // Hiển thị danh sách đề thi gần đây lên DataGridView
            dgvRecentExams.DataSource = _recentExams.Select(e => new
            {
                Id = e.Id,
                STT = _recentExams.IndexOf(e) + 1,
                ExamCode = e.ExamCode,
                Title = e.Title,
                Subject = e.Subject,
                TotalQuestions = e.TotalQuestions,
                CreatedAt = e.CreatedAt
            }).ToList();
        }
    }
}