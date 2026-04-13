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
        public FormGiaoVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pnlBody.Controls.Clear();
            UC_AICreate uc = new UC_AICreate();
            uc.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(uc);
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

        // Sự kiện Click cho từng nút
        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnCreateQuestion);
            // Logic hiển thị Form hoặc UserControl tạo câu hỏi tại đây
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnManageQuestions);
            // Logic quản lý câu hỏi
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
