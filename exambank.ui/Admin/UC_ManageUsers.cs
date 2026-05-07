using exambank.data.Models;
using exambank.ui.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_ManageUsers : BaseUserControl
    {
        private UserModel _loginUser;
        public UC_ManageUsers(UserModel user)
        {
            InitializeComponent();
            this._loginUser = user;
        }
    }
}
