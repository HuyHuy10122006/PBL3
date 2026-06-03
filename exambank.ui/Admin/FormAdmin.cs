using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.Common;
using exambank.ui.Admin;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormAdmin : UIForm
    {
        private UserModel _loginUser;
        private NavigationService _nav;

        private UC_AdminDashboard _ucAdminDashboard;
        private UC_ManageUsers _ucManageUsers;
        private UC_ExamBank _ucExamBank;
        private UC_AIConfig _aiConfig;
        private List<UIButton> menuButtons;

        public FormAdmin(UserModel user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            menuButtons = new List<UIButton> { btnHome, btnManageAccount, btnManageExamBank, btnConfigAI };
            _loginUser = user;
            _nav = new NavigationService(pnlBody);

            // Mở Trang chủ làm màn hình mặc định
            btnHome_Click(null, null);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnHome, menuButtons);
            if (_ucAdminDashboard == null)
            {
                _ucAdminDashboard = new UC_AdminDashboard(_loginUser);
            }
            _nav.Display(_ucAdminDashboard);
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageAccount, menuButtons);
            if (_ucManageUsers == null)
            {
                _ucManageUsers = new UC_ManageUsers(_loginUser);
            }
            _nav.Display(_ucManageUsers);
        }

        private void btnManageExamBank_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageExamBank, menuButtons);
            if (_ucExamBank == null)
            {
                _ucExamBank = new UC_ExamBank(_loginUser);
            }
            _nav.Display(_ucExamBank);
        }

        private void btnConfigAI_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnConfigAI, menuButtons);
            if (_aiConfig == null)
            {
                _aiConfig = new UC_AIConfig();
            }
            _nav.Display(_aiConfig);
        }

        // Sự kiện click vào Avatar để mở ProfileSettings
        private void avtUser_Click(object sender, EventArgs e)
        {
            UC_ProfileSettings ucProfile = new UC_ProfileSettings(_loginUser);
            _nav.Display(ucProfile);
            UIHelper.SetActiveMenu(null, menuButtons); // Bỏ chọn các nút menu khác
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}