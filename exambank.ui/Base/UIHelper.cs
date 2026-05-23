using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BCrypt.Net;

namespace exambank.ui.Base
{
    public static class UIHelper
    {
        public static void TogglePassword(UITextBox txt)
        {
            txt.PasswordChar = (txt.PasswordChar == '*') ? '\0' : '*';
            txt.ButtonSymbol = (txt.PasswordChar == '*') ? 61552 : 61550;
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Hàm dùng chung để cập nhật trạng thái menu
        public static void SetActiveMenu(UIButton selectedButton, List<UIButton> menuButtons)
        {
            if (selectedButton == null || menuButtons == null) return;

            foreach (var btn in menuButtons)
            {
                btn.Selected = false;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
            selectedButton.Selected = true;
            selectedButton.Font = new Font(selectedButton.Font, FontStyle.Bold);
        }

        // Hàm băm mật khẩu khi người dùng Đăng ký
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 11);
        }

        /// <param name="password">Mật khẩu thô do user nhập ở form Login</param>
        /// <param name="storedHash">Chuỗi Hash đã lưu trong Database từ trước</param>
        // Hàm kiểm tra mật khẩu khi người dùng Đăng nhập
        public static bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}
