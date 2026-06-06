using exambank.data.Models;
using exambank.ui.Base;
using exambank.logic.Service;
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
    public partial class DoiMatKhau : UIEditForm
    {
        private readonly UserModel _currentUser;
        private readonly UserService _userService = new UserService();

        public DoiMatKhau(UserModel user)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        protected override bool CheckData()
        {
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) ||
                string.IsNullOrEmpty(newPass) ||
                string.IsNullOrEmpty(confirm))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (newPass.Length < 6)
            {
                UIMessageBox.ShowWarning2("Mật khẩu mới phải có ít nhất 6 ký tự.");
                return false;
            }

            if (newPass != confirm)
            {
                UIMessageBox.ShowWarning2("Mật khẩu xác nhận không khớp.");
                return false;
            }

            if (oldPass == newPass)
            {
                UIMessageBox.ShowWarning2("Mật khẩu mới không được trùng với mật khẩu cũ.");
                return false;
            }

            try
            {
                _userService.ChangePassword(_currentUser.Id, oldPass, newPass);
                UIMessageBox.ShowSuccess2("Đổi mật khẩu thành công.");
                return true;
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2($"Không thể đổi mật khẩu: {ex.Message}");
                return false;
            }
        }

        private void txtOldPass_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtOldPass);
        }

        private void txtNewPass_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtNewPass);
        }

        private void txtConfirmPass_ButtonClick(object sender, EventArgs e)
        {
            UIHelper.TogglePassword(txtConfirmPass);
        }
    }
}
