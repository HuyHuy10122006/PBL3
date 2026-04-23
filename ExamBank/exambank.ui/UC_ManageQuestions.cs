using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using exambank.ui.Properties;

namespace exambank.ui
{
    public partial class UC_ManageQuestions : UserControl
    {
        public UC_ManageQuestions()
        {
            InitializeComponent();
            foreach (DataGridViewRow row in dgvQuestions.Rows)
            {
                row.Cells["colEdit"].Value = Properties.Resources.icon_edit; // Tên ảnh trong Resource
                row.Cells["colDelete"].Value = Properties.Resources.icon_trash; // 
            }
        }
    }
}
