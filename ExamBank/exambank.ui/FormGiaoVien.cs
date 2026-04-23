using exambank.data.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormGiaoVien : UIForm
    {
        private UserModel _loginUser;
        public FormGiaoVien(UserModel user)
        {
            InitializeComponent();
            this._loginUser = user;
            this.WindowState = FormWindowState.Maximized;
            btnCreateQuestion_Click(null, null);
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
            pnlBody.Controls.Clear();
            UC_AICreate uc = new UC_AICreate();
            uc.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(uc);
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnManageQuestions);
            pnlBody.Controls.Clear();
            UC_ManageQuestions uc = new UC_ManageQuestions();
            uc.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(uc);
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnManageExams);
            pnlBody.Controls.Clear();
            UC_ManageExams uc = new UC_ManageExams();
            uc.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(uc);
        }

        private void btnViewExamBank_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnViewExamBank);
            pnlBody.Controls.Clear();
            UC_ViewExamBank uc = new UC_ViewExamBank();
            uc.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(uc);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu DialogResult KHÔNG PHẢI là OK, nghĩa là người dùng bấm X hoặc Alt+F4
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit(); // Thoát toàn bộ ứng dụng, không cho quay lại Form Login
            }
        }
    }
}
