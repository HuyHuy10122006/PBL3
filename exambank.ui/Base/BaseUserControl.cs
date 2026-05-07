using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using exambank.data.Models;

namespace exambank.ui.Base
{
    public enum NavigationTarget
    {
        Login,
        Register,
        ForgotPassword,
        Home,
        AICreate,
        ManageQuestions,
        ManageExams,
        ViewExamBank,
    }

    public partial class BaseUserControl : UserControl
    {
        [Browsable(false)] // Không hiển thị trong bảng Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // Không tự sinh code trong Designer.cs
        public Action<NavigationTarget, object?> OnNavigate { get; set; }
    }
}
