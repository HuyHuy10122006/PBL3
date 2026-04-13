using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_Question : UserControl
    {
        public UC_Question()
        {
            InitializeComponent();
        }
        public void SetData(int number, string content, string[] options)
        {
            lblNumber.Text = number.ToString("D2");
            lblContent.Text = content;
            flpOptions.Controls.Clear();

            foreach (var opt in options)
            {
                var rb = new Sunny.UI.UIRadioButton { Text = opt, AutoSize = true };
                rb.Visible = true;
                flpOptions.Controls.Add(rb);
            }
        }
    }
}
