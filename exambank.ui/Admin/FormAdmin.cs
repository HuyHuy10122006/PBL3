using exambank.data.Models;
using exambank.ui.Base;
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
    public partial class FormAdmin : UIForm
    {
        private UserModel _loginUser;
        private NavigationService _nav;
        private UC_ManageUsers _ucManageUsers;
        private UC_ExamBank _ucExamBank;
        private UC_AIConfig _aiConfig;
        private List<UIButton> menuButtons;
        public FormAdmin(UserModel user)
        {
            InitializeComponent();
            menuButtons = new List<UIButton> { btnHome, btnManageUsers, btnExamBank, btnAIConfig };

            this._loginUser = user;
            _nav = new NavigationService(pnlBody);
            _ucManageUsers = new UC_ManageUsers(_loginUser);
            _nav.Display(_ucManageUsers);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnHome, menuButtons);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageUsers, menuButtons);
            if (_ucManageUsers == null)
            {
                _ucManageUsers = new UC_ManageUsers(_loginUser);
            }
            _nav.Display(_ucManageUsers);
        }

        private void btnExamBank_Click(object sender, EventArgs e)
        {
           UIHelper.SetActiveMenu(btnExamBank, menuButtons);
            if (_ucExamBank == null) {
                _ucExamBank = new UC_ExamBank();
            }
            _nav.Display(_ucExamBank);
        }

        private void btnAIConfig_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnAIConfig, menuButtons);
            if (_aiConfig == null)
            {
                _aiConfig = new UC_AIConfig();
            }
            _nav.Display(_aiConfig);
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

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu DialogResult KHÔNG PHẢI là OK, nghĩa là người dùng bấm X hoặc Alt+F4
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit(); // Thoát toàn bộ ứng dụng, không cho quay lại Form Login
            }
        }
    }
}
