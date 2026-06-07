using exambank.data;
using exambank.data.Models;
using exambank.ui.Base;
using exambank.logic.Service;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormDangNhap : UIForm
    {
        private readonly LoginService _loginService;
        private readonly NavigationService _nav;
        private UC_DangKy _registerUC;
        private UC_QuenMatKhau _forgotPasswordUC;
        private UC_DangNhap _loginUC;

        public FormDangNhap()
        {
            InitializeComponent();
            UIStyles.CultureInfo = CultureInfos.en_US;
            this.StartPosition = FormStartPosition.CenterScreen;

            _loginService = new LoginService();
            _nav = new NavigationService(pnlLoginCard);
            InitUserControls();
        }

        private void InitUserControls()
        {
            // Khởi tạo UC
            _loginUC = new UC_DangNhap(_loginService);
            // Lắng nghe tín hiệu từ UC
            _loginUC.OnNavigate = HandleNavigation;

            _nav.Display(_loginUC);
        }

        private void HandleNavigation(NavigationTarget target, object? data)
        {
            switch (target)
            {
                case NavigationTarget.Login:
                    _nav.Display(_loginUC);
                    break;
                case NavigationTarget.Register:
                    if (_registerUC == null)
                    {
                        _registerUC = new UC_DangKy(_loginService);
                        _registerUC.OnNavigate = HandleNavigation;
                    }
                    _nav.Display(_registerUC);
                    break;
                case NavigationTarget.ForgotPassword:
                    if (_forgotPasswordUC == null)
                    {
                        _forgotPasswordUC = new UC_QuenMatKhau(_loginService);
                        _forgotPasswordUC.OnNavigate = HandleNavigation;
                    }
                    _nav.Display(_forgotPasswordUC);
                    break;
                case NavigationTarget.Home:
                    OpenMainApp(data as UserModel);
                    break;
            }
        }

        private void OpenMainApp(UserModel? authenticatedUser)
        {
            if (authenticatedUser == null) { return; }

            this.Hide();
            if (authenticatedUser.Role == "Admin" || authenticatedUser.Role == "SuperAdmin")
            {
                FormAdmin adminForm = new FormAdmin(authenticatedUser);
                adminForm.FormClosed += ShowMeAgain;
                adminForm.ShowDialog();
            }
            else if (authenticatedUser.Role == "Teacher")
            {
                FormGiaoVien teacherForm = new FormGiaoVien(authenticatedUser);
                teacherForm.FormClosed += ShowMeAgain;
                teacherForm.ShowDialog();
            }
        }

        private void ShowMeAgain(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormDangNhap_Resize(object sender, EventArgs e)
        {
            CenterLoginCard();
        }

        private void CenterLoginCard()
        {
            if (pnlLoginCard != null)
            {
                pnlLoginCard.Left = (this.ClientSize.Width - pnlLoginCard.Width) / 2;
                pnlLoginCard.Top = (this.ClientSize.Height - pnlLoginCard.Height) / 2;
            }
        }
    }
}