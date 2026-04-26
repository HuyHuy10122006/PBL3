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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Answer { get; set; } = string.Empty;

        private Sunny.UI.UISymbolButton btnDelete;

        public void SetData(int number, string content, string[] options, string answer = "A")
        {
            lblNumber.Text = number.ToString("D2");
            lblContent.Text = content;
            Answer = answer;
            flpOptions.Controls.Clear();

            foreach (var opt in options)
            {
                var rb = new Sunny.UI.UIRadioButton { Text = opt, AutoSize = true };
                rb.Visible = true;
                flpOptions.Controls.Add(rb);
            }

            if (btnDelete == null)
            {
                btnDelete = new Sunny.UI.UISymbolButton
                {
                    Symbol = 61453, // trash icon usually, or cross
                    Text = "Xóa",
                    Size = new Size(80, 30),
                    Location = new Point(this.Width - 90, 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    FillColor = Color.IndianRed
                };
                btnDelete.Click += (s, e) => this.Parent?.Controls.Remove(this);
                this.Controls.Add(btnDelete);
            }
        }

        public string GetQuestionText() => lblContent.Text;

        public string[] GetOptions()
        {
            var options = new List<string>();
            foreach (Control c in flpOptions.Controls)
            {
                if (c is Sunny.UI.UIRadioButton rb)
                {
                    options.Add(rb.Text);
                }
            }
            return options.ToArray();
        }
    }
}
