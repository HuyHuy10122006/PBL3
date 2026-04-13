using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace exambank.ui
{
    public static class UIHelper
    {
        public static void TogglePassword(UITextBox txt)
        {
            txt.PasswordChar = (txt.PasswordChar == '*') ? '\0' : '*';
            txt.ButtonSymbol = (txt.PasswordChar == '*') ? 61552 : 61550;
        }
    }
}
