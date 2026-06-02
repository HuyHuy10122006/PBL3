using exambank.data;
using exambank.data.Models;
using exambank.ui.LogicTest;
using Sunny.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Xceed.Document.NET;

namespace exambank.ui
{
    public partial class UC_TrangChu : UserControl
    {
        private UserModel _user;

        public UC_TrangChu(UserModel user)
        {
            InitializeComponent();
            _user = user;

            lblWelcome.Text = $"Xin chào, Giáo viên {_user.FullName}. Chúc bạn một ngày làm việc hiệu quả!";
            lblDate.Text = $"Ngày là: {DateTime.Now.ToString("dd/MM/yyyy, HH:mm:ss")}";

            this.VisibleChanged += UC_TrangChu_VisibleChanged;

            btnCard1Detail.Click += BtnCard1Detail_Click;
            btnCard2Detail.Click += BtnCard2Detail_Click;
            btnCard3Detail.Click += BtnCard3Detail_Click;
            btnCard4Detail.Click += BtnCard4Detail_Click;

            barChartAI.Text = "";
            SetupChart();
            LoadDataGrid();

            LoadDashboardData();
        }

        private void UC_TrangChu_VisibleChanged(object sender, EventArgs e)
        {
        
        public void LoadDashboardData()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var now = DateTime.Now;

                    int tongCauHoi = db.Questions.Count(q => q.CreatedByUserId == _user.Id);

                    int cauHoiAI = db.Questions.Count(q =>
                        q.CreatedByUserId == _user.Id &&
                        q.IsAIGenerated == true &&
                        q.CreatedAt.Month == now.Month &&
                        q.CreatedAt.Year == now.Year);

                    int tongDeThi = db.Exams.Count(e => e.CreatedByUserId == _user.Id);

                    int taiLieu = db.Documents.Count(d => d.UserId == _user.Id);

                    lblCard1Value.Text = tongCauHoi.ToString("N0");
                    lblCard2Value.Text = cauHoiAI.ToString("N0");
                    lblCard3Value.Text = tongDeThi.ToString("N0");
                    lblCard4Value.Text = taiLieu.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCard1Value.Text = "0";
                lblCard2Value.Text = "0";
                lblCard3Value.Text = "0";
                lblCard4Value.Text = "0";
            }
        }

        private void BtnCard1Detail_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Sẽ chuyển đến trang: Quản lý câu hỏi cá nhân");
        }

        private void BtnCard2Detail_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Sẽ chuyển đến trang: Lịch sử câu hỏi do AI tạo");
        }

        private void BtnCard3Detail_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Sẽ chuyển đến trang: Quản lý đề thi cá nhân");
        }

        private void BtnCard4Detail_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("Sẽ chuyển đến trang: Kho tài liệu nguồn");
        }

        public void SetupChart()
        {
            try
            {
                var option = new Sunny.UI.UIBarOption();
                option.Title = new Sunny.UI.UITitle();
                option.Title.Text = "Số lượng câu hỏi AI tạo (7 ngày qua)";

                option.XAxis.Data.Clear();
                option.Series.Clear();

                var series = new Sunny.UI.UIBarSeries();
                series.Name = "Số câu hỏi";

                using (var db = new ExamBankDbContext())
                {
                    var today = DateTime.Today;
                    var sevenDaysAgo = today.AddDays(-6);

                    var rawData = db.Questions
                        .Where(q => q.CreatedByUserId == _user.Id
                                 && q.IsAIGenerated == true
                                 && q.CreatedAt >= sevenDaysAgo)
                        .GroupBy(q => q.CreatedAt.Date)
                        .Select(g => new { Date = g.Key, Count = g.Count() })
                        .ToList();

                    for (int i = 6; i >= 0; i--)
                    {
                        var targetDate = today.AddDays(-i);

                        var dayData = rawData.FirstOrDefault(d => d.Date == targetDate);
                        int count = dayData != null ? dayData.Count : 0;

                        option.XAxis.Data.Add(targetDate.ToString("dd/MM"));

                        series.AddData(count);
                    }
                }

                option.Series.Add(series);
                barChartAI.SetOption(option);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biểu đồ: " + ex.Message, "Lỗi Chart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                dgvRecentActivities.Columns.Clear();
                dgvRecentActivities.Rows.Clear();

                dgvRecentActivities.Columns.Add("HanhDong", "Hành động");
                dgvRecentActivities.Columns.Add("MonKhoi", "Môn/Khối");
                dgvRecentActivities.Columns.Add("ThoiGian", "Thời gian");
                dgvRecentActivities.Columns.Add("ChiTiet", "Chi tiết");

                dgvRecentActivities.Columns["HanhDong"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgvRecentActivities.Columns["MonKhoi"].Width = 100;
                dgvRecentActivities.Columns["ThoiGian"].Width = 160;
                dgvRecentActivities.Columns["ChiTiet"].Width = 100;

                dgvRecentActivities.Columns["MonKhoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecentActivities.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecentActivities.Columns["ChiTiet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewColumn col in dgvRecentActivities.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvRecentActivities.ReadOnly = true;
                dgvRecentActivities.AllowUserToAddRows = false;
                dgvRecentActivities.AllowUserToDeleteRows = false;
                dgvRecentActivities.AllowUserToResizeColumns = false;
                dgvRecentActivities.AllowUserToResizeRows = false;

                using (var db = new ExamBankDbContext())
                {
                    var recentActivities = db.Questions
                        .Where(q => q.CreatedByUserId == _user.Id)
                        .OrderByDescending(q => q.CreatedAt)
                        .Take(5)
                        .ToList();

                    foreach (var item in recentActivities)
                    {
                        string actionName = item.IsAIGenerated ? "Đã tạo câu hỏi AI" : "Tạo câu hỏi thủ công";
                        string subjectGrade = $"{item.Subject} {item.Grade}";
                        string timeString = item.CreatedAt.ToString("dd/MM/yyyy HH:mm");

                        dgvRecentActivities.Rows.Add(actionName, subjectGrade, timeString, "Đã lưu");
                    }
                }

                dgvRecentActivities.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hoạt động gần đây: " + ex.Message, "Lỗi DataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}