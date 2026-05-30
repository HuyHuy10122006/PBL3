using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace exambank.ui.Admin
{
    partial class UC_AdminDashboard
    {
        private IContainer components = null;
        internal UIPanel pnlHeader;
        internal UILabel lblTitle;
        internal UILabel lblWelcome;
        internal FlowLayoutPanel pnlCards;
        internal Panel pnlContent;
        internal UIPanel pnlLogsCard;
        internal Panel pnlLogsHeader;
        internal UILabel lblLogsTitle;
        internal UIButton btnRefresh;
        internal DataGridView dgvSystemLogs;
        internal Panel pnlEmpty;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new UIPanel();
            lblTitle = new UILabel();
            lblWelcome = new UILabel();
            pnlCards = new FlowLayoutPanel();
            pnlContent = new Panel();
            pnlLogsCard = new UIPanel();
            dgvSystemLogs = new DataGridView();
            pnlEmpty = new Panel();
            lblEmpty = new Label();
            pnlLogsHeader = new Panel();
            lblLogsTitle = new UILabel();
            btnRefresh = new UIButton();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLogsCard.SuspendLayout();
            ((ISupportInitialize)dgvSystemLogs).BeginInit();
            pnlEmpty.SuspendLayout();
            pnlLogsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.White;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(18);
            pnlHeader.RectColor = Color.FromArgb(230, 230, 230);
            pnlHeader.Size = new Size(1, 84);
            pnlHeader.Style = UIStyle.Custom;
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(28, 50, 80);
            lblTitle.Location = new Point(18, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tổng quan Hệ thống";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.FromArgb(120, 120, 120);
            lblWelcome.Location = new Point(360, 24);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(162, 19);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Chào mừng quản trị viên";
            // 
            // pnlCards
            // 
            pnlCards.AutoScroll = true;
            pnlCards.BackColor = Color.Transparent;
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 84);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(18);
            pnlCards.Size = new Size(0, 140);
            pnlCards.TabIndex = 1;
            pnlCards.WrapContents = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Controls.Add(pnlLogsCard);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 224);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(0, 0);
            pnlContent.TabIndex = 0;
            // 
            // pnlLogsCard
            // 
            pnlLogsCard.Controls.Add(dgvSystemLogs);
            pnlLogsCard.Controls.Add(pnlEmpty);
            pnlLogsCard.Controls.Add(pnlLogsHeader);
            pnlLogsCard.Dock = DockStyle.Fill;
            pnlLogsCard.FillColor = Color.White;
            pnlLogsCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlLogsCard.Location = new Point(20, 20);
            pnlLogsCard.Margin = new Padding(6);
            pnlLogsCard.MinimumSize = new Size(1, 1);
            pnlLogsCard.Name = "pnlLogsCard";
            pnlLogsCard.Padding = new Padding(14);
            pnlLogsCard.Radius = 8;
            pnlLogsCard.RectColor = Color.FromArgb(230, 230, 230);
            pnlLogsCard.Size = new Size(1, 1);
            pnlLogsCard.Style = UIStyle.Custom;
            pnlLogsCard.TabIndex = 0;
            pnlLogsCard.Text = null;
            pnlLogsCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvSystemLogs
            // 
            dgvSystemLogs.AllowUserToAddRows = false;
            dgvSystemLogs.AllowUserToResizeColumns = false;
            dgvSystemLogs.AllowUserToResizeRows = false;
            dgvSystemLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSystemLogs.BackgroundColor = Color.White;
            dgvSystemLogs.BorderStyle = BorderStyle.None;
            dgvSystemLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSystemLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSystemLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSystemLogs.Dock = DockStyle.Fill;
            dgvSystemLogs.EnableHeadersVisualStyles = false;
            dgvSystemLogs.GridColor = Color.FromArgb(230, 230, 230);
            dgvSystemLogs.Location = new Point(14, 54);
            dgvSystemLogs.Margin = new Padding(0);
            dgvSystemLogs.Name = "dgvSystemLogs";
            dgvSystemLogs.ReadOnly = true;
            dgvSystemLogs.RowHeadersVisible = false;
            dgvSystemLogs.RowTemplate.Height = 36;
            dgvSystemLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSystemLogs.Size = new Size(0, 0);
            dgvSystemLogs.TabIndex = 0;
            // 
            // pnlEmpty
            // 
            pnlEmpty.BackColor = Color.White;
            pnlEmpty.Controls.Add(lblEmpty);
            pnlEmpty.Dock = DockStyle.Fill;
            pnlEmpty.Location = new Point(14, 54);
            pnlEmpty.Name = "pnlEmpty";
            pnlEmpty.Size = new Size(0, 0);
            pnlEmpty.TabIndex = 1;
            pnlEmpty.Visible = false;
            // 
            // lblEmpty
            // 
            lblEmpty.Location = new Point(0, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(100, 23);
            lblEmpty.TabIndex = 0;
            // 
            // pnlLogsHeader
            // 
            pnlLogsHeader.BackColor = Color.Transparent;
            pnlLogsHeader.Controls.Add(lblLogsTitle);
            pnlLogsHeader.Controls.Add(btnRefresh);
            pnlLogsHeader.Dock = DockStyle.Top;
            pnlLogsHeader.Location = new Point(14, 14);
            pnlLogsHeader.Name = "pnlLogsHeader";
            pnlLogsHeader.Size = new Size(0, 40);
            pnlLogsHeader.TabIndex = 2;
            // 
            // lblLogsTitle
            // 
            lblLogsTitle.AutoSize = true;
            lblLogsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLogsTitle.ForeColor = Color.FromArgb(70, 70, 70);
            lblLogsTitle.Location = new Point(6, 8);
            lblLogsTitle.Name = "lblLogsTitle";
            lblLogsTitle.Size = new Size(207, 20);
            lblLogsTitle.TabIndex = 0;
            lblLogsTitle.Text = "Nhật ký hoạt động hệ thống";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(980, 6);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UC_AdminDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(pnlContent);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            Name = "UC_AdminDashboard";
            Size = new Size(0, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlLogsCard.ResumeLayout(false);
            ((ISupportInitialize)dgvSystemLogs).EndInit();
            pnlEmpty.ResumeLayout(false);
            pnlLogsHeader.ResumeLayout(false);
            pnlLogsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblEmpty;
    }
}