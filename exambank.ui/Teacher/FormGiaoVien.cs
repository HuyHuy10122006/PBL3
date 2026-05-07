using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.LogicTest;
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
        private NavigationService _nav;
        private UC_AICreate _ucAICreate;
        private UC_ManageQuestions _ucManageQuestions;
        private UC_ManageExams _ucManageExams;
        private UC_ViewExamBank _ucViewExamBank;
        private List<UIButton> menuButtons;

        public FormGiaoVien(UserModel user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            menuButtons = new List<UIButton> { btnHome, btnCreateQuestion, btnManageQuestions, btnManageExams, btnViewExamBank };
            _loginUser = user;
            _nav = new NavigationService(pnlBody);
            _ucAICreate = new UC_AICreate(_loginUser);
            _nav.Display(_ucAICreate);
            btnCreateQuestion_Click(null, null);
            
        }

        // Sự kiện Click cho từng nút
        private void btnHome_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnHome, menuButtons);
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnCreateQuestion, menuButtons);
            _nav.Display(_ucAICreate);
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageQuestions, menuButtons);
            if (_ucManageQuestions == null)
            {
                _ucManageQuestions = new UC_ManageQuestions(_loginUser);
            }
            _nav.Display(_ucManageQuestions);
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageExams, menuButtons);
            if (_ucManageExams == null)
            {
                _ucManageExams = new UC_ManageExams();
            }
            _nav.Display(_ucManageExams);
        }

        private void btnViewExamBank_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnViewExamBank, menuButtons);
            if (_ucViewExamBank == null)
            {
                _ucViewExamBank = new UC_ViewExamBank();
            }
            _nav.Display(_ucViewExamBank);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var result = UIMessageBox.ShowAsk2("Bạn có chắc chắn muốn đăng xuất không?");
            if (result)
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
