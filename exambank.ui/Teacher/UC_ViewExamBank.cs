using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.LogicTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_ViewExamBank : BaseUserControl
    {
        private readonly UserModel _loginUser;
        private readonly ExamService _examService = new ExamService();
        public UC_ViewExamBank(UserModel loginUser)
        {
            InitializeComponent();
            _loginUser = loginUser;
        }
    }
}
