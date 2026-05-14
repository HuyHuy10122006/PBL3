using Sunny.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_TrangChu : UserControl
    {
        // Chuỗi kết nối đến Database của bạn
        private string connectionString = @"Server=HOANGHUNG\SQLEXPRESS;Database=baicsharp;Integrated Security=True;";

        public UC_TrangChu()
        {
            InitializeComponent();
            this.Load += UC_TrangChu_Load;
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Chào mừng trở lại với hệ thống EduGenAI!";

            // Gọi hàm lấy số liệu thật từ SQL Server
            LoadRealStatistics();
            LoadRecentExams();
        }

        private void LoadRealStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Đếm tổng câu hỏi 
                    SqlCommand cmdQ = new SqlCommand("SELECT COUNT(*) FROM CauHoi", conn);
                    lblTotalQuestions.Text = cmdQ.ExecuteScalar()?.ToString() ?? "0";

                    // Đếm tổng đề thi 
                    SqlCommand cmdE = new SqlCommand("SELECT COUNT(*) FROM DeThi", conn);
                    lblTotalExams.Text = cmdE.ExecuteScalar()?.ToString() ?? "0";

                    // Đếm tổng môn học 
                    SqlCommand cmdS = new SqlCommand("SELECT COUNT(*) FROM MonHoc", conn);
                    lblTotalSubjects.Text = cmdS.ExecuteScalar()?.ToString() ?? "0";
                }
            }
            catch (Exception ex)
            {
                // Nếu DB chưa có bảng hoặc sai tên bảng, tạm thời hiện 0
                Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
                lblTotalQuestions.Text = "0";
                lblTotalExams.Text = "0";
                lblTotalSubjects.Text = "0";
            }
        }

        private void LoadRecentExams()
        {
            // Tạm thời hiển thị dữ liệu giả cho bảng đề thi gần đây
            // Khi nào có bảng chứa dữ liệu thật trong SQL, chúng ta sẽ viết câu SELECT nối vào sau!
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đề");
            dt.Columns.Add("Tên đề thi");
            dt.Columns.Add("Môn học");
            dt.Columns.Add("Ngày tạo");

            dt.Rows.Add("DTH001", "Kiểm tra giữa kỳ Mạng máy tính", "Mạng máy tính", "14/05/2026");
            dt.Rows.Add("DTH002", "Trắc nghiệm Phân tích thiết kế hệ thống", "OOAD", "12/05/2026");
            dt.Rows.Add("DTH003", "Đề thi Xác suất thống kê", "Xác suất thống kê", "10/05/2026");

            dgvRecentExams.DataSource = dt;
            dgvRecentExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentExams.ReadOnly = true;
            dgvRecentExams.AllowUserToAddRows = false;
        }
    }
}