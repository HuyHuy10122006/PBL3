using exambank.data.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace exambank.ui
{
    public partial class UC_Question : UserControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private const int WM_MOUSEWHEEL = 0x020A;

        // Màu sắc đồng nhất với hệ thống
        private readonly Color colorNormal = Color.White;
        private readonly Color colorSelected = Color.FromArgb(230, 247, 235); // Xanh lá cực nhạt
        private readonly Color colorBorderSelected = Color.FromArgb(40, 167, 69); // Viền xanh lá đậm
        private readonly Color colorBorderNormal = Color.White;

        public UC_Question()
        {
            InitializeComponent();
        }

        public void SetData(QuestionModel question, int stt = 1)
        {
            txtContentDisplay.MouseWheel -= RedirectWheel;
            txtContentDisplay.MouseWheel += RedirectWheel;
            lblNumber.Text = $"Câu {stt}";
            txtContentDisplay.Text = question.Question;

            // 1. Cập nhật kích thước TextBox câu hỏi chính
            // Trừ hao khoảng 30px cho Padding nội bộ của TextBox
            int contentWidth = txtContentDisplay.Width - 30;
            txtContentDisplay.Height = GetPerfectHeight(txtContentDisplay, question.Question, contentWidth);

            // 2. Xử lý danh sách đáp án
            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            List<string> options = new List<string>
            {
                question.OptionA,
                question.OptionB,
                question.OptionC,
                question.OptionD
            };
            char prefix = 'A';

            flpOptions.SuspendLayout();

            //Khởi tạo các TextBox đáp án
            for (int i = 0; i < answerBoxes.Length; i++)
            {
                if (i < options.Count)
                {
                    var txt = answerBoxes[i];
                    txt.Visible = true;
                    txt.Text = $"{prefix}. {options[i]}";

                    // --- Cố định chiều rộng theo FlowLayoutPanel ---
                    txt.Width = flpOptions.Width - 25;

                    // --- Tính toán chiều cao sát nút ---
                    int txtWidth = txt.Width - 30;
                    txt.Height = GetPerfectHeight(txt, txt.Text, txtWidth);

                    // Reset trạng thái hiển thị
                    txt.FillColor = colorNormal;
                    txt.Margin = new Padding(0, 0, 0, 10);

                    // Gán sự kiện nếu chưa có (để tránh gán trùng)
                    txt.Click -= Answer_Click;
                    txt.Click += Answer_Click;
                    txt.MouseWheel -= RedirectWheel;
                    txt.MouseWheel += RedirectWheel;
                }
                else { answerBoxes[i].Visible = false; }
                prefix++;
            }

            switch (question.Answer.ToUpper())
            {
                case "A":
                    Answer_Click(txtAnsA, EventArgs.Empty);
                    break;
                case "B":
                    Answer_Click(txtAnsB, EventArgs.Empty);
                    break;
                case "C":
                    Answer_Click(txtAnsC, EventArgs.Empty);
                    break;
                case "D":
                    Answer_Click(txtAnsD, EventArgs.Empty);
                    break;
                default:
                    MessageBox.Show("Dữ liệu đáp án không hợp lệ!");
                    break;
            }
            flpOptions.ResumeLayout(true);

            // 3. Cập nhật vị trí và tổng chiều cao của UserControl
            UpdateComponentLayout();
        }

        // --- HÀM TÔ MÀU KHI CHỌN ---
        private void Answer_Click(object sender, EventArgs e)
        {
            UITextBox selected = (UITextBox)sender;
            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };

            foreach (var txt in answerBoxes)
            {
                txt.FillColor = txt.FillReadOnlyColor = colorNormal;
                txt.RectSides = ToolStripStatusLabelBorderSides.None;
                //txt.Text = "    " + txt.Text.Replace("\u2713 ", "").Trim(); // Xóa dấu tick nếu có
            }
            selected.FillColor = selected.FillReadOnlyColor = colorSelected;
            selected.RectColor = selected.RectReadOnlyColor = colorBorderSelected;
            selected.RectSides = ToolStripStatusLabelBorderSides.All;
            //selected.Text = "\u2713 " + selected.Text.Trim();
        }

        // --- HÀM TÍNH CHIỀU CAO SÁT NỘI DUNG ---
        private int GetPerfectHeight(UITextBox txt, string text, int width)
        {
            if (string.IsNullOrEmpty(text)) return 0;

            // Sử dụng TextRenderer để đo kích thước chữ thực tế
            Size size = TextRenderer.MeasureText(text, txt.Font,
                new Size(width, int.MaxValue), TextFormatFlags.WordBreak);

            // Cộng thêm 10px cho Padding dưới của TextBox
            return size.Height + 10;
        }

        private void UpdateComponentLayout()
        {
            // Đặt FLP nằm dưới nội dung câu hỏi
            flpOptions.Top = txtContentDisplay.Bottom + 5;

            // Tính tổng chiều cao của các đáp án đang hiện
            int totalH = 0;
            foreach (Control c in flpOptions.Controls)
            {
                if (c.Visible) totalH += c.Height + c.Margin.Bottom;
            }
            flpOptions.Height = totalH + 5;

            // Dãn khung pnlCard bao ngoài
            pnlCard.Height = flpOptions.Bottom + 15;
            this.Height = pnlCard.Height + 10;
        }

        private void RedirectWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            if (this.Parent != null)
                SendMessage(this.Parent.Handle, WM_MOUSEWHEEL, (IntPtr)e.Delta << 16, IntPtr.Zero);
        }

        private void UC_Question_Resize(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var List_txt = new[] { txtContentDisplay, txtAnsA, txtAnsB, txtAnsC, txtAnsD};
            for (int i = 0; i < List_txt.Length; i++)
            {
                var txt = List_txt[i];
                txt.ReadOnly = !txt.ReadOnly;
            }
            txtContentDisplay.Focus();
        }
    }
}