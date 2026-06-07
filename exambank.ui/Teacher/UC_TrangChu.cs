using exambank.data;
using exambank.data.Models;
using exambank.logic.Service;
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

            BeautifyCards();
            AddHoverEffect(pnlCard4);

            barChartAI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.Text = $"Xin chào, Giáo viên {_user.FullName}. Chúc bạn một ngày làm việc hiệu quả!";
            lblDate.Text = $"Ngày là: {DateTime.Now.ToString("dd/MM/yyyy, HH:mm:ss")}";

            this.VisibleChanged += UC_TrangChu_VisibleChanged;

            barChartAI.Text = "";
            SetupChart();
            LoadDataGrid();

            LoadDashboardData();
            SetupClickableCard();
        }

        private void BeautifyCards()
        {
            StyleCard(pnlCard1, lblCard1Title, lblCard1Value, "📚", Color.FromArgb(41, 128, 185));
            StyleCard(pnlCard2, lblCard2Title, lblCard2Value, "💡", Color.FromArgb(211, 84, 0));
            StyleCard(pnlCard3, lblCard3Title, lblCard3Value, "📝", Color.FromArgb(39, 174, 96));
            StyleCard(pnlCard4, lblCard4Title, lblCard4Value, "📁", Color.FromArgb(142, 68, 173));
        }
        // Hàm tạo hiệu ứng thẻ nổi lên 5 pixel khi di chuột vào
        private void AddHoverEffect(Control card)
        {
            int originalY = card.Top; // Lưu lại vị trí ban đầu

            EventHandler mouseEnter = (s, e) => { card.Top = originalY - 5; }; // Đẩy thẻ lên
            EventHandler mouseLeave = (s, e) => { card.Top = originalY; };     // Trả về chỗ cũ

            // Gán hiệu ứng cho cái nền thẻ
            card.MouseEnter += mouseEnter;
            card.MouseLeave += mouseLeave;

            // Gán hiệu ứng cho cả các chữ, icon nằm bên trong thẻ để chuột không bị giật
            foreach (Control child in card.Controls)
            {
                child.MouseEnter += mouseEnter;
                child.MouseLeave += mouseLeave;
            }
        }

        private void StyleCard(Control card, Control title, Control value, string icon, Color mainColor)
        {
            title.ForeColor = mainColor;
            value.ForeColor = Color.FromArgb(45, 52, 54);

            Label lblIcon = new Label();
            lblIcon.Text = icon;
            lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 50F, FontStyle.Regular);
            lblIcon.ForeColor = Color.FromArgb(60, mainColor);
            lblIcon.BackColor = Color.Transparent;
            lblIcon.AutoSize = false;
            lblIcon.Size = new Size(90, 90);
            lblIcon.TextAlign = ContentAlignment.MiddleRight;
            lblIcon.Location = new Point(card.Width - 100, (card.Height - 90) / 2);
            lblIcon.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            card.Controls.Add(lblIcon);
            lblIcon.SendToBack();

            if (card is Sunny.UI.UIPanel uiPanel)
            {
                uiPanel.Radius = 15;
                uiPanel.RectSize = 1;
                uiPanel.RectColor = mainColor;
            }
        }

        private void SetupClickableCard()
        {
            Control theTim = pnlCard4;

            theTim.Cursor = Cursors.Hand;
            theTim.Click += OpenManageDocuments_Click;

            foreach (Control item in theTim.Controls)
            {
                item.Cursor = Cursors.Hand;
                item.Click += OpenManageDocuments_Click;
            }
        }

        private void OpenManageDocuments_Click(object sender, EventArgs e)
        {
            UC_ManageDocuments ucKhoTaiLieu = new UC_ManageDocuments(_user);
            ucKhoTaiLieu.Dock = DockStyle.Fill;

            var mainPanel = this.Parent;

            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ucKhoTaiLieu);
            }
        }

        private void UC_TrangChu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadDashboardData();
                SetupChart();
                LoadDataGrid();
            }
        }

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

        public void SetupChart()
        {
            try
            {
                var option = new Sunny.UI.UIBarOption();
                option.Title = new Sunny.UI.UITitle();
                option.Title.Text = "Số lượng câu hỏi AI tạo (7 ngày qua)";
                option.ToolTip = new Sunny.UI.UIBarToolTip();
                option.ToolTip.Visible = true;

                option.XAxis.Data.Clear();
                option.Series.Clear();

                var series = new Sunny.UI.UIBarSeries();
                series.Name = "Số câu hỏi";
                series.ShowValue = true;
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
                dgvRecentActivities.Columns.Add("Mon", "Môn");
                dgvRecentActivities.Columns.Add("Khoi", "Khối");
                dgvRecentActivities.Columns.Add("ThoiGian", "Thời gian");
                dgvRecentActivities.Columns.Add("ChiTiet", "Chi tiết");

                dgvRecentActivities.Columns["HanhDong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRecentActivities.Columns["Mon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvRecentActivities.Columns["Khoi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvRecentActivities.Columns["ThoiGian"].Width = 140;
                dgvRecentActivities.Columns["ChiTiet"].Width = 80;

                dgvRecentActivities.Columns["Mon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecentActivities.Columns["Khoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                        .Take(10)
                        .ToList();

                    foreach (var item in recentActivities)
                    {
                        string actionName = item.IsAIGenerated ? "Đã tạo câu hỏi AI" : "Tạo câu hỏi thủ công";
                        string timeString = item.CreatedAt.ToString("dd/MM/yyyy HH:mm");

                        dgvRecentActivities.Rows.Add(actionName, item.Subject, item.Grade, timeString, "Đã lưu");
                    }
                }

                dgvRecentActivities.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi DataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}