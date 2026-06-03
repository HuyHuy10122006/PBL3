namespace exambank.ui
{
    partial class UC_TrangChu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblWelcome = new Sunny.UI.UILabel();
            lblDate = new Sunny.UI.UILabel();
            tlpCards = new TableLayoutPanel();
            pnlCard1 = new Sunny.UI.UIPanel();
            lblCard1Title = new Sunny.UI.UILabel();
            lblCard1Value = new Sunny.UI.UILabel();
            pnlCard2 = new Sunny.UI.UIPanel();
            lblCard2Title = new Sunny.UI.UILabel();
            lblCard2Value = new Sunny.UI.UILabel();
            pnlCard3 = new Sunny.UI.UIPanel();
            lblCard3Title = new Sunny.UI.UILabel();
            lblCard3Value = new Sunny.UI.UILabel();
            pnlCard4 = new Sunny.UI.UIPanel();
            lblCard4Title = new Sunny.UI.UILabel();
            lblCard4Value = new Sunny.UI.UILabel();
            tlpBottomSection = new TableLayoutPanel();
            pnlChart = new Sunny.UI.UIPanel();
            barChartAI = new Sunny.UI.UIBarChart();
            lblChartTitle = new Sunny.UI.UILabel();
            pnlTable = new Sunny.UI.UIPanel();
            lblTableTitle = new Sunny.UI.UILabel();
            dgvRecentActivities = new Sunny.UI.UIDataGridView();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            tlpBottomSection.SuspendLayout();
            pnlChart.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(tlpCards, 0, 1);
            tlpMain.Controls.Add(tlpBottomSection, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1120, 675);
            tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1120, 84);
            pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(48, 48, 48);
            lblWelcome.Location = new Point(28, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(700, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xin chào, Giáo viên. Chúc bạn một ngày làm việc hiệu quả!";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(28, 52);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(309, 32);
            lblDate.TabIndex = 1;
            lblDate.Text = "Ngày là:";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlCard1, 0, 0);
            tlpCards.Controls.Add(pnlCard2, 1, 0);
            tlpCards.Controls.Add(pnlCard3, 2, 0);
            tlpCards.Controls.Add(pnlCard4, 3, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 84);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1120, 169);
            tlpCards.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.Controls.Add(lblCard1Title);
            pnlCard1.Controls.Add(lblCard1Value);
            pnlCard1.Dock = DockStyle.Fill;
            pnlCard1.FillColor = Color.FromArgb(232, 244, 253);
            pnlCard1.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCard1.Location = new Point(13, 9);
            pnlCard1.Margin = new Padding(13, 9, 9, 9);
            pnlCard1.MinimumSize = new Size(1, 1);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Radius = 10;
            pnlCard1.RectColor = Color.FromArgb(232, 244, 253);
            pnlCard1.Size = new Size(258, 151);
            pnlCard1.TabIndex = 0;
            pnlCard1.Text = null;
            pnlCard1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCard1Title
            // 
            lblCard1Title.BackColor = Color.Transparent;
            lblCard1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard1Title.ForeColor = Color.FromArgb(21, 101, 192);
            lblCard1Title.Location = new Point(15, 15);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(200, 45);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "Tổng Câu hỏi\r\n(Cá nhân)";
            // 
            // lblCard1Value
            // 
            lblCard1Value.BackColor = Color.Transparent;
            lblCard1Value.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblCard1Value.ForeColor = Color.FromArgb(21, 101, 192);
            lblCard1Value.Location = new Point(15, 55);
            lblCard1Value.Name = "lblCard1Value";
            lblCard1Value.Size = new Size(200, 50);
            lblCard1Value.TabIndex = 1;
            lblCard1Value.Text = "1,250";
            // 
            // pnlCard2
            // 
            pnlCard2.Controls.Add(lblCard2Title);
            pnlCard2.Controls.Add(lblCard2Value);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.FillColor = Color.FromArgb(255, 243, 224);
            pnlCard2.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCard2.Location = new Point(289, 9);
            pnlCard2.Margin = new Padding(9);
            pnlCard2.MinimumSize = new Size(1, 1);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Radius = 10;
            pnlCard2.RectColor = Color.FromArgb(255, 243, 224);
            pnlCard2.Size = new Size(262, 151);
            pnlCard2.TabIndex = 1;
            pnlCard2.Text = null;
            pnlCard2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCard2Title
            // 
            lblCard2Title.BackColor = Color.Transparent;
            lblCard2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard2Title.ForeColor = Color.FromArgb(230, 81, 0);
            lblCard2Title.Location = new Point(15, 15);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(200, 45);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "Câu hỏi do AI tạo\r\n(Tháng)";
            // 
            // lblCard2Value
            // 
            lblCard2Value.BackColor = Color.Transparent;
            lblCard2Value.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblCard2Value.ForeColor = Color.FromArgb(230, 81, 0);
            lblCard2Value.Location = new Point(15, 55);
            lblCard2Value.Name = "lblCard2Value";
            lblCard2Value.Size = new Size(200, 50);
            lblCard2Value.TabIndex = 1;
            lblCard2Value.Text = "320";
            // 
            // pnlCard3
            // 
            pnlCard3.Controls.Add(lblCard3Title);
            pnlCard3.Controls.Add(lblCard3Value);
            pnlCard3.Dock = DockStyle.Fill;
            pnlCard3.FillColor = Color.FromArgb(232, 245, 233);
            pnlCard3.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCard3.Location = new Point(569, 9);
            pnlCard3.Margin = new Padding(9);
            pnlCard3.MinimumSize = new Size(1, 1);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Radius = 10;
            pnlCard3.RectColor = Color.FromArgb(232, 245, 233);
            pnlCard3.Size = new Size(262, 151);
            pnlCard3.TabIndex = 2;
            pnlCard3.Text = null;
            pnlCard3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCard3Title
            // 
            lblCard3Title.BackColor = Color.Transparent;
            lblCard3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard3Title.ForeColor = Color.FromArgb(46, 125, 50);
            lblCard3Title.Location = new Point(15, 15);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(200, 25);
            lblCard3Title.TabIndex = 0;
            lblCard3Title.Text = "Số Đề thi";
            // 
            // lblCard3Value
            // 
            lblCard3Value.BackColor = Color.Transparent;
            lblCard3Value.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblCard3Value.ForeColor = Color.FromArgb(46, 125, 50);
            lblCard3Value.Location = new Point(15, 55);
            lblCard3Value.Name = "lblCard3Value";
            lblCard3Value.Size = new Size(200, 50);
            lblCard3Value.TabIndex = 1;
            lblCard3Value.Text = "45";
            // 
            // pnlCard4
            // 
            pnlCard4.Controls.Add(lblCard4Title);
            pnlCard4.Controls.Add(lblCard4Value);
            pnlCard4.Dock = DockStyle.Fill;
            pnlCard4.FillColor = Color.FromArgb(243, 229, 245);
            pnlCard4.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCard4.Location = new Point(849, 9);
            pnlCard4.Margin = new Padding(9, 9, 13, 9);
            pnlCard4.MinimumSize = new Size(1, 1);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Radius = 10;
            pnlCard4.RectColor = Color.FromArgb(243, 229, 245);
            pnlCard4.Size = new Size(258, 151);
            pnlCard4.TabIndex = 3;
            pnlCard4.Text = null;
            pnlCard4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCard4Title
            // 
            lblCard4Title.BackColor = Color.Transparent;
            lblCard4Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard4Title.ForeColor = Color.FromArgb(106, 27, 154);
            lblCard4Title.Location = new Point(15, 15);
            lblCard4Title.Name = "lblCard4Title";
            lblCard4Title.Size = new Size(200, 45);
            lblCard4Title.TabIndex = 0;
            lblCard4Title.Text = "Tài liệu nguồn đã\r\ntải";
            // 
            // lblCard4Value
            // 
            lblCard4Value.BackColor = Color.Transparent;
            lblCard4Value.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblCard4Value.ForeColor = Color.FromArgb(106, 27, 154);
            lblCard4Value.Location = new Point(15, 55);
            lblCard4Value.Name = "lblCard4Value";
            lblCard4Value.Size = new Size(200, 50);
            lblCard4Value.TabIndex = 1;
            lblCard4Value.Text = "18";
            // 
            // tlpBottomSection
            // 
            tlpBottomSection.ColumnCount = 2;
            tlpBottomSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBottomSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpBottomSection.Controls.Add(pnlChart, 0, 0);
            tlpBottomSection.Controls.Add(pnlTable, 1, 0);
            tlpBottomSection.Dock = DockStyle.Fill;
            tlpBottomSection.Location = new Point(0, 253);
            tlpBottomSection.Margin = new Padding(0);
            tlpBottomSection.Name = "tlpBottomSection";
            tlpBottomSection.RowCount = 1;
            tlpBottomSection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottomSection.Size = new Size(1120, 422);
            tlpBottomSection.TabIndex = 2;
            // 
            // pnlChart
            // 
            pnlChart.Controls.Add(barChartAI);
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Dock = DockStyle.Fill;
            pnlChart.FillColor = Color.White;
            pnlChart.Font = new Font("Microsoft Sans Serif", 12F);
            pnlChart.Location = new Point(13, 9);
            pnlChart.Margin = new Padding(13, 9, 9, 14);
            pnlChart.MinimumSize = new Size(1, 1);
            pnlChart.Name = "pnlChart";
            pnlChart.Radius = 15;
            pnlChart.RectColor = Color.FromArgb(220, 220, 220);
            pnlChart.Size = new Size(426, 399);
            pnlChart.TabIndex = 0;
            pnlChart.Text = null;
            pnlChart.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // barChartAI
            // 
            barChartAI.Font = new Font("Microsoft Sans Serif", 12F);
            barChartAI.LegendFont = new Font("Microsoft Sans Serif", 9F);
            barChartAI.Location = new Point(0, 48);
            barChartAI.MinimumSize = new Size(1, 1);
            barChartAI.Name = "barChartAI";
            barChartAI.Size = new Size(426, 348);
            barChartAI.SubFont = new Font("Microsoft Sans Serif", 9F);
            barChartAI.TabIndex = 10;
            barChartAI.Text = "barChartAI";
            // 
            // lblChartTitle
            // 
            lblChartTitle.BackColor = Color.Transparent;
            lblChartTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblChartTitle.Location = new Point(15, 15);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(300, 30);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Lượt sử dụng AI hàng tuần";
            // 
            // pnlTable
            // 
            pnlTable.Controls.Add(lblTableTitle);
            pnlTable.Controls.Add(dgvRecentActivities);
            pnlTable.Dock = DockStyle.Fill;
            pnlTable.FillColor = Color.White;
            pnlTable.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTable.Location = new Point(457, 9);
            pnlTable.Margin = new Padding(9, 9, 13, 14);
            pnlTable.MinimumSize = new Size(1, 1);
            pnlTable.Name = "pnlTable";
            pnlTable.Radius = 15;
            pnlTable.RectColor = Color.FromArgb(220, 220, 220);
            pnlTable.Size = new Size(650, 399);
            pnlTable.TabIndex = 1;
            pnlTable.Text = null;
            pnlTable.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTableTitle
            // 
            lblTableTitle.BackColor = Color.Transparent;
            lblTableTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTableTitle.Location = new Point(15, 15);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(300, 30);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Hoạt động gần đây";
            // 
            // dgvRecentActivities
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvRecentActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentActivities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentActivities.BackgroundColor = Color.White;
            dgvRecentActivities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 90, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 90, 180);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRecentActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentActivities.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRecentActivities.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecentActivities.EnableHeadersVisualStyles = false;
            dgvRecentActivities.Font = new Font("Segoe UI", 11F);
            dgvRecentActivities.GridColor = Color.LightGray;
            dgvRecentActivities.Location = new Point(15, 55);
            dgvRecentActivities.Name = "dgvRecentActivities";
            dgvRecentActivities.RectColor = Color.LightGray;
            dgvRecentActivities.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRecentActivities.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecentActivities.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvRecentActivities.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRecentActivities.RowTemplate.Height = 40;
            dgvRecentActivities.SelectedIndex = -1;
            dgvRecentActivities.Size = new Size(620, 329);
            dgvRecentActivities.StripeOddColor = Color.FromArgb(248, 250, 252);
            dgvRecentActivities.TabIndex = 1;
            // 
            // UC_TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(tlpMain);
            Name = "UC_TrangChu";
            Size = new Size(1120, 675);
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            tlpCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlCard3.ResumeLayout(false);
            pnlCard4.ResumeLayout(false);
            tlpBottomSection.ResumeLayout(false);
            pnlChart.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private Sunny.UI.UILabel lblWelcome;
        private Sunny.UI.UILabel lblDate;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private Sunny.UI.UIPanel pnlCard1;
        private Sunny.UI.UILabel lblCard1Title;
        private Sunny.UI.UILabel lblCard1Value;
        private Sunny.UI.UIPanel pnlCard2;
        private Sunny.UI.UILabel lblCard2Title;
        private Sunny.UI.UILabel lblCard2Value;
        private Sunny.UI.UIPanel pnlCard3;
        private Sunny.UI.UILabel lblCard3Title;
        private Sunny.UI.UILabel lblCard3Value;
        private Sunny.UI.UIPanel pnlCard4;
        private Sunny.UI.UILabel lblCard4Title;
        private Sunny.UI.UILabel lblCard4Value;
        private System.Windows.Forms.TableLayoutPanel tlpBottomSection;
        private Sunny.UI.UIPanel pnlChart;
        private Sunny.UI.UILabel lblChartTitle;
        private Sunny.UI.UIPanel pnlTable;
        private Sunny.UI.UILabel lblTableTitle;
        private Sunny.UI.UIDataGridView dgvRecentActivities;
        private Sunny.UI.UIBarChart barChartAI;
    }
}