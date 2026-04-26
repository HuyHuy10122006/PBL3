using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace exambank.ui
{
    public partial class FormGiaoVien : UIForm
    {
        private UC_AICreate _ucAiCreate;
        private UC_QuanLyCauHoi _ucQuanLyCauHoi;

        public FormGiaoVien()
        {
            InitializeComponent();
            this.ShowTitle = true;
            this.TitleHeight = 35;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.WindowState = FormWindowState.Maximized;

            _ucAiCreate = new UC_AICreate { Dock = DockStyle.Fill };
            _ucQuanLyCauHoi = new UC_QuanLyCauHoi { Dock = DockStyle.Fill };

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(_ucAiCreate);
            pnlBody.Controls.Add(_ucQuanLyCauHoi);

            SetActiveMenu(btnCreateQuestion);
            ShowControl(_ucAiCreate);
        }

        private void ShowControl(UserControl uc)
        {
            foreach (Control c in pnlBody.Controls)
            {
                c.Visible = (c == uc);
            }
        }

        // Hàm dùng chung để cập nhật trạng thái menu
        private void SetActiveMenu(UIButton selectedButton)
        {
            // Danh sách các nút menu
            var menuButtons = new List<UIButton>
            {
                btnCreateQuestion,
                btnManageQuestions,
                btnManageExams,
                btnViewExamBank
            };

            foreach (var btn in menuButtons)
            {
                // Nếu là nút vừa bấm thì Selected = true, ngược lại = false
                btn.Selected = (btn == selectedButton);
            }
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnCreateQuestion);
            ShowControl(_ucAiCreate);
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnManageQuestions);
            ShowControl(_ucQuanLyCauHoi);
            _ucQuanLyCauHoi.RefreshData(); // Thêm hàm RefreshData() cho UC_QuanLyCauHoi để auto refresh
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnManageExams);
            // Logic quản lý đề thi
        }

        private void btnViewExamBank_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnViewExamBank);
            // Logic xem ngân hàng đề thi
        }
    }
}
