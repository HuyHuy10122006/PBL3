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
    }
}
