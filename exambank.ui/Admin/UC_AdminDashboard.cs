using exambank.data;
using exambank.data.Models;
using exambank.ui.Base;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Color = System.Drawing.Color;
using Font = System.Drawing.Font;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace exambank.ui.Admin
{
    public partial class UC_AdminDashboard : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly UserService _userService = new UserService();
        private readonly QuestionService _question_service = new QuestionService();
        private readonly ExamService _examService = new ExamService();

        private List<UIPanel> _dashboardCards = new List<UIPanel>();
        private UIPanel _pnlChart;
        private Chart _aiChart;

        public UC_AdminDashboard(UserModel loginUser)
        {
            _loginUser = loginUser ?? throw new ArgumentNullException(nameof(loginUser));
            InitializeComponent();
            ApplyVisualStyle();
            CreateStatCards();
            InitializeChart();
            this.Load += UC_AdminDashboard_Load;
            this.Resize += (s, e) => AdjustLayout();
            this.VisibleChanged += (s, e) => { if (this.Visible) _ = LoadStatisticsAsync(); };
        }

        private void ApplyVisualStyle()
        {
            this.BackColor = Color.FromArgb(248, 250, 252);
            pnlHeader.FillColor = Color.White;
            pnlHeader.RectColor = Color.FromArgb(230, 230, 230);
            pnlCards.BackColor = Color.Transparent;
            pnlContent.BackColor = Color.Transparent;
            dgvSystemLogs.BackgroundColor = Color.White;
        }

        private void InitializeChart()
        {
            _pnlChart = new UIPanel
            {
                Dock = DockStyle.Top,
                Height = 280,
                FillColor = Color.White,
                RectColor = Color.FromArgb(225, 228, 232),
                RectSize = 1,
                Radius = 10,
                Style = UIStyle.Custom
            };

            _aiChart = new Chart { Dock = DockStyle.Fill };
            _aiChart.ChartAreas.Add(new ChartArea("MainArea"));
            _aiChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            _aiChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            _aiChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            _aiChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            _aiChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            _aiChart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            var title = new Title("Tổng lượt yêu cầu xử lý AI (7 ngày qua)", Docking.Top, new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold), Color.FromArgb(44, 62, 80));
            _aiChart.Titles.Add(title);

            _pnlChart.Controls.Add(_aiChart);
            pnlContent.Controls.Add(_pnlChart);
            _pnlChart.BringToFront();
        }

        private void CreateStatCards()
        {
            _dashboardCards.Clear();
            pnlCards.Controls.Clear();

            _dashboardCards.Add(BuildSunnyCard("Tổng số Tài khoản", "0", "👥", Color.FromArgb(41, 128, 185), "Đang tải dữ liệu..."));
            _dashboardCards.Add(BuildSunnyCard("Ngân hàng Câu hỏi", "0", "📝", Color.FromArgb(192, 57, 43), "Đang tải dữ liệu..."));
            _dashboardCards.Add(BuildSunnyCard("Tổng số Đề thi", "0", "📚", Color.FromArgb(39, 174, 96), "Đang tải dữ liệu..."));
            _dashboardCards.Add(BuildSunnyCard("Lượt xử lý AI", "0", "🤖", Color.FromArgb(142, 68, 173), "Đang tải dữ liệu..."));

            foreach (var card in _dashboardCards)
            {
                pnlCards.Controls.Add(card);
            }
        }

        private UIPanel BuildSunnyCard(string title, string initialValue, string iconText, Color themeColor, string subText)
        {
            var card = new UIPanel
            {
                Height = 115,
                Radius = 10,
                FillColor = Color.White,
                RectColor = Color.FromArgb(225, 228, 232),
                RectSize = 1,
                Style = UIStyle.Custom
            };

            var lblTitle = new UILabel
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 110, 120),
                Location = new System.Drawing.Point(16, 14),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblTitle);

            var valueLabel = new UILabel
            {
                Text = initialValue,
                Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new System.Drawing.Point(12, 38),
                AutoSize = true,
                BackColor = Color.Transparent,
                Name = "ValueLabel"
            };
            card.Controls.Add(valueLabel);

            var iconPanel = new UIPanel
            {
                Width = 46,
                Height = 46,
                Radius = 23,
                FillColor = Color.FromArgb(25, themeColor.R, themeColor.G, themeColor.B),
                RectColor = Color.Transparent,
                Style = UIStyle.Custom,
                Name = "IconPanel"
            };

            var lblIcon = new UILabel
            {
                Text = iconText,
                Font = new Font("Segoe UI Emoji", 16F),
                ForeColor = themeColor,
                AutoSize = true,
                Location = new System.Drawing.Point(9, 9),
                BackColor = Color.Transparent
            };
            iconPanel.Controls.Add(lblIcon);
            card.Controls.Add(iconPanel);

            var lblTrend = new UILabel
            {
                Text = subText,
                Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new System.Drawing.Point(16, 84),
                AutoSize = true,
                BackColor = Color.Transparent,
                Name = "SubTextLabel"
            };
            card.Controls.Add(lblTrend);

            return card;
        }

        private async void UC_AdminDashboard_Load(object sender, EventArgs e)
        {
            await LoadStatisticsAsync();
            await LoadChartDataAsync();
            LoadSystemLogs();
            AdjustLayout();
        }

        private async Task LoadStatisticsAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var db = new ExamBankDbContext())
                    {
                        // 1. TÀI KHOẢN: Đếm tổng số người dùng
                        var users = _userService.GetAllUsers() ?? new List<UserModel>();
                        int totalUsers = users.Count;
                        int teachers = users.Count(u => u.Role == "Teacher" || u.Role == "Giáo viên");
                        int admins = totalUsers - teachers;

                        // 2. NGÂN HÀNG CÂU HỎI: Đếm trên toàn hệ thống
                        int totalQuestions = db.Questions.Count();
                        int aiQuestions = db.Questions.Count(q => q.IsAIGenerated == true); // Đếm số câu do AI tạo

                        // 3. TỔNG SỐ ĐỀ THI: Đếm trên toàn hệ thống (Sửa lỗi hiển thị số 0)
                        int totalExams = db.Exams.Count();

                        // 4. LƯỢT XỬ LÝ AI
                        int totalAIRequests = db.SystemLogs.Count(l => l.Action.Contains("AI"));
                        int successAIRequests = db.SystemLogs.Count(l => l.Action.Contains("AI") && l.Status == "Thành công");
                        int aiSuccessRate = totalAIRequests > 0 ? (successAIRequests * 100 / totalAIRequests) : 100;
                        int totalActiveExams = db.Exams.Count(e => e.IsShared == true);
                        int totalDeletedExams = db.Exams.Count(e => e.IsShared == false);

                        // 5. Cập nhật dữ liệu thật lên giao diện
                        this.Invoke((MethodInvoker)delegate
                        {
                            UpdateCardInfo(0, totalUsers.ToString(), $"Bao gồm {teachers} Giáo viên & {admins} Quản trị", Color.FromArgb(41, 128, 185));
                            UpdateCardInfo(1, totalQuestions.ToString(), $"Khoảng {aiQuestions} câu hỏi do AI tạo", Color.FromArgb(192, 57, 43));
                           UpdateCardInfo(2, totalActiveExams.ToString(), $"Và {totalDeletedExams} đề thi không được duyệt", Color.FromArgb(39, 174, 96));
                            UpdateCardInfo(3, totalAIRequests.ToString(), $"Tỷ lệ AI xử lý thành công: {aiSuccessRate}%", Color.FromArgb(142, 68, 173));
                        });
                    }
                });
            }
            catch (Exception)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < 4; i++)
                        UpdateCardInfo(i, "0", "Lỗi tải dữ liệu", Color.FromArgb(192, 57, 43));
                });
            }
        }

        private void UpdateCardInfo(int cardIndex, string mainValue, string subText, Color subTextColor)
        {
            if (_dashboardCards.Count > cardIndex)
            {
                var valLbl = _dashboardCards[cardIndex].Controls.OfType<UILabel>().FirstOrDefault(c => c.Name == "ValueLabel");
                var subLbl = _dashboardCards[cardIndex].Controls.OfType<UILabel>().FirstOrDefault(c => c.Name == "SubTextLabel");

                if (valLbl != null) valLbl.Text = mainValue;
                if (subLbl != null)
                {
                    subLbl.Text = subText;
                    subLbl.ForeColor = subTextColor;
                }
            }
        }

        private async Task LoadChartDataAsync()
        {
            try
            {
                var startDate = DateTime.Now.Date.AddDays(-6);

                await Task.Run(() =>
                {
                    using (var db = new ExamBankDbContext())
                    {
                        var logs = db.SystemLogs
                            .Where(l => l.LogTime >= startDate && l.Action.Contains("AI"))
                            .Select(l => new { l.LogTime })
                            .ToList();

                        var grouped = logs
                            .GroupBy(l => l.LogTime.Date)
                            .ToDictionary(g => g.Key, g => g.Count());

                        this.Invoke((MethodInvoker)delegate
                        {
                            _aiChart.Series.Clear();
                            Series series = new Series("Lượt xử lý AI")
                            {
                                ChartType = SeriesChartType.Column,
                                Color = Color.FromArgb(30, 115, 190),
                                IsValueShownAsLabel = true,
                                IsXValueIndexed = true,
                                LabelFormat = "N0",
                                Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
                            };
                            series["PointWidth"] = "0.4";

                            for (int i = 0; i <= 6; i++)
                            {
                                DateTime currentDate = startDate.AddDays(i);
                                int count = grouped.ContainsKey(currentDate) ? grouped[currentDate] : 0;
                                series.Points.AddXY(currentDate.ToString("dd/MM"), count);
                            }

                            _aiChart.Series.Add(series);

                            _aiChart.ChartAreas[0].AxisY.Minimum = 0;
                            int maxVal = grouped.Count > 0 ? grouped.Values.Max() : 0;
                            if (maxVal < 5)
                            {
                                _aiChart.ChartAreas[0].AxisY.Maximum = 5;
                            }
                            _aiChart.ChartAreas[0].AxisY.Interval = 1;
                        });
                    }
                });
            }
            catch
            {
            }
        }

        private void LoadSystemLogs()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var logs = db.SystemLogs
                        .OrderByDescending(l => l.LogTime)
                        .Select(l => new
                        {
                            Time = l.LogTime.ToString("dd-MM-yyyy HH:mm"),
                            Account = l.Username,
                            Action = l.Action,
                            Status = l.Status
                        })
                        .ToList();

                    dgvSystemLogs.DataSource = logs;
                }
            }
            catch
            {
                dgvSystemLogs.DataSource = null;
            }

            FormatLogsGrid();
            ToggleEmptyState();
        }

        private void FormatLogsGrid()
        {
            if (dgvSystemLogs.Columns.Count == 0) return;

            dgvSystemLogs.Columns[0].HeaderText = "Thời gian";
            dgvSystemLogs.Columns[1].HeaderText = "Tài khoản";
            dgvSystemLogs.Columns[2].HeaderText = "Hành động";
            dgvSystemLogs.Columns[3].HeaderText = "Trạng thái";

            dgvSystemLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSystemLogs.EnableHeadersVisualStyles = false;
            dgvSystemLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(246, 248, 250);
            dgvSystemLogs.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvSystemLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 100);

            dgvSystemLogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvSystemLogs.ColumnHeadersDefaultCellStyle.BackColor;
            dgvSystemLogs.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvSystemLogs.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvSystemLogs.ColumnHeaderMouseClick -= DgvSystemLogs_ColumnHeaderMouseClick;
            dgvSystemLogs.ColumnHeaderMouseClick += DgvSystemLogs_ColumnHeaderMouseClick;

            dgvSystemLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 253, 255);
            dgvSystemLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 255);
            dgvSystemLogs.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSystemLogs.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            foreach (DataGridViewRow row in dgvSystemLogs.Rows)
            {
                var status = row.Cells["Status"]?.Value?.ToString() ?? row.Cells[3]?.Value?.ToString() ?? "";
                if (status.Contains("Thất") || status.Contains("khóa") || status.Contains("lỗi"))
                {
                    row.Cells[3].Style.ForeColor = Color.FromArgb(192, 57, 43);
                    row.Cells[3].Style.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                }
                else
                {
                    row.Cells[3].Style.ForeColor = Color.FromArgb(39, 174, 96);
                    row.Cells[3].Style.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                }
            }

            dgvSystemLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSystemLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSystemLogs.GridColor = Color.FromArgb(235, 238, 242);
            dgvSystemLogs.RowTemplate.Height = 42;
            dgvSystemLogs.AllowUserToResizeRows = false;
            dgvSystemLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSystemLogs.RowHeadersVisible = false;
        }

        private void ToggleEmptyState()
        {
            bool empty = dgvSystemLogs.Rows.Count == 0;
            pnlEmpty.Visible = empty;
            dgvSystemLogs.Visible = !empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSystemLogs();
        }

        private void AdjustLayout()
        {
            pnlCards.Padding = new Padding(20, 10, 20, 10);
            pnlContent.Padding = new Padding(20, 10, 20, 20);

            int spacing = 18;
            int totalCardSpacing = spacing * 3;
            int availableWidth = pnlCards.Width - pnlCards.Padding.Left - pnlCards.Padding.Right;
            int cardWidth = (availableWidth - totalCardSpacing) / 4;

            int x = pnlCards.Padding.Left;
            int y = pnlCards.Padding.Top;

            foreach (var card in _dashboardCards)
            {
                card.Width = cardWidth;
                card.Location = new System.Drawing.Point(x, y);

                var iconPanel = card.Controls.OfType<UIPanel>().FirstOrDefault(c => c.Name == "IconPanel");
                if (iconPanel != null)
                {
                    iconPanel.Location = new System.Drawing.Point(card.Width - iconPanel.Width - 15, 18);
                }

                x += card.Width + spacing;
            }

            if (_pnlChart != null && pnlContent.Controls.Contains(_pnlChart))
            {
                _pnlChart.Dock = DockStyle.None;
                _pnlChart.Location = new System.Drawing.Point(pnlContent.Padding.Left, pnlContent.Padding.Top);
                _pnlChart.Width = pnlContent.Width - pnlContent.Padding.Left - pnlContent.Padding.Right;

                int currentY = _pnlChart.Bottom + 20;

                Control btnRefresh = null;
                Control lblTitle = null;

                foreach (Control ctrl in pnlContent.Controls)
                {
                    if (ctrl.Name != null && ctrl.Name.Equals("btnRefresh", StringComparison.OrdinalIgnoreCase))
                    {
                        btnRefresh = ctrl;
                    }
                    else if (ctrl.Text != null && ctrl.Text.IndexOf("hoạt động", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        lblTitle = ctrl;
                    }
                }

                if (btnRefresh == null) btnRefresh = FindControlDeep(this, "btnRefresh");
                if (lblTitle == null) lblTitle = FindLabelDeep(this, "hoạt động");

                int headerBottom = currentY;

                if (btnRefresh != null)
                {
                    btnRefresh.Parent = pnlContent;
                    btnRefresh.Dock = DockStyle.None;
                    btnRefresh.Location = new System.Drawing.Point(pnlContent.Width - pnlContent.Padding.Right - btnRefresh.Width, currentY);
                    btnRefresh.BringToFront();
                    btnRefresh.Visible = true;
                    headerBottom = Math.Max(headerBottom, btnRefresh.Bottom);
                }

                if (lblTitle != null)
                {
                    lblTitle.Parent = pnlContent;
                    lblTitle.Dock = DockStyle.None;
                    lblTitle.Location = new System.Drawing.Point(pnlContent.Padding.Left, currentY + 5);
                    lblTitle.BringToFront();
                    lblTitle.Visible = true;
                    headerBottom = Math.Max(headerBottom, lblTitle.Bottom);
                }

                int gridY = headerBottom + 15;
                int gridWidth = pnlContent.Width - pnlContent.Padding.Left - pnlContent.Padding.Right;
                int gridHeight = pnlContent.Height - gridY - pnlContent.Padding.Bottom;

                if (gridHeight > 0)
                {
                    dgvSystemLogs.Parent = pnlContent;
                    dgvSystemLogs.Dock = DockStyle.None;
                    dgvSystemLogs.Location = new System.Drawing.Point(pnlContent.Padding.Left, gridY);
                    dgvSystemLogs.Size = new System.Drawing.Size(gridWidth, gridHeight);
                    dgvSystemLogs.BringToFront();
                    dgvSystemLogs.Visible = true;

                    if (pnlEmpty != null)
                    {
                        pnlEmpty.Parent = pnlContent;
                        pnlEmpty.Dock = DockStyle.None;
                        pnlEmpty.Location = dgvSystemLogs.Location;
                        pnlEmpty.Size = dgvSystemLogs.Size;
                        pnlEmpty.BringToFront();
                    }
                }
            }
        }

        private Control FindControlDeep(Control root, string name)
        {
            if (root.Name != null && root.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return root;
            foreach (Control c in root.Controls)
            {
                var found = FindControlDeep(c, name);
                if (found != null) return found;
            }
            return null;
        }

        private Control FindLabelDeep(Control root, string textContent)
        {
            if ((root is Label || root.GetType().Name.Contains("Label")) && root.Text != null && root.Text.IndexOf(textContent, StringComparison.OrdinalIgnoreCase) >= 0) return root;
            foreach (Control c in root.Controls)
            {
                var found = FindLabelDeep(c, textContent);
                if (found != null) return found;
            }
            return null;
        }

        private void DgvSystemLogs_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSystemLogs.ClearSelection();
            if (dgvSystemLogs.CurrentCell != null)
                dgvSystemLogs.CurrentCell = null;
        }
    }
}