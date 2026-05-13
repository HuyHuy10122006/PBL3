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
        private QuestionModel _currentQuestion;

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

        public void SetData(QuestionModel question, string Header)
        {
            _currentQuestion = question;
            txtContentDisplay.MouseWheel -= RedirectWheel;
            txtContentDisplay.MouseWheel += RedirectWheel;
            // 1. Gán dữ liệu văn bản trước
            lblNumber.Text = Header;
            txtContentDisplay.Text = question.Question;

            // Cập nhật danh sách đáp án (Chỉ gán text, chưa tính size)
            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            string[] options = { question.OptionA, question.OptionB, question.OptionC, question.OptionD };
            char prefix = 'A';
            
            SwapEditMode(); // Tạm đảo chế độ để kích hoạt sự kiện Click
            for (int i = 0; i < answerBoxes.Length; i++)
            {
                if (i < options.Length && !string.IsNullOrEmpty(options[i]))
                {
                    answerBoxes[i].Visible = true;
                    answerBoxes[i].Text = $"{prefix}. {options[i]}";

                    

                    // Đăng ký sự kiện nếu chưa có
                    answerBoxes[i].Click -= Answer_Click;
                    answerBoxes[i].Click += Answer_Click;
                    answerBoxes[i].MouseWheel -= RedirectWheel;
                    answerBoxes[i].MouseWheel += RedirectWheel;
                }
                else
                {
                    answerBoxes[i].Visible = false;
                }
                prefix++;
            }

            // 2. Gọi hàm tính toán lại toàn bộ kích thước dựa trên chiều rộng hiện tại
            RecalculateLayout();

            // 3. Highlight đáp án đúng
            HighlightCorrectAnswer(question.Answer);

            SwapEditMode(); // Đặt lại chế độ chỉnh sửa về mặc định
        }

        // --- HÀM TÍNH TOÁN LẠI TOÀN BỘ KÍCH THƯỚC (QUAN TRỌNG) ---
        private void RecalculateLayout()
        {
            // Tạm dừng vẽ để mượt hình
            this.SuspendLayout();
            flpOptions.SuspendLayout();

            // A. Tính chiều cao cho câu hỏi
            // Trừ 30px cho padding và scrollbar nếu có
            int contentWidth = txtContentDisplay.Width - 30;
            txtContentDisplay.Height = GetPerfectHeight(txtContentDisplay, txtContentDisplay.Text, contentWidth);

            // B. Tính chiều cao cho từng đáp án
            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            foreach (var txt in answerBoxes)
            {
                if (txt.Visible)
                {
                    // Ép chiều rộng TextBox theo FlowLayoutPanel
                    txt.Width = flpOptions.Width - 10;
                    int txtWidth = txt.Width - 30;
                    txt.Height = GetPerfectHeight(txt, txt.Text, txtWidth);
                }
            }

            // C. Sắp xếp lại vị trí các thành phần và tổng chiều cao UC
            UpdateComponentLayout();

            flpOptions.ResumeLayout(true);
            this.ResumeLayout(true);
        }

        // --- GHI ĐÈ SỰ KIỆN RESIZE CỦA USER CONTROL ---
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Khi chiều rộng thay đổi (kéo giãn Form), tự động tính lại layout
            if (!string.IsNullOrEmpty(txtContentDisplay.Text))
            {
                RecalculateLayout();
            }
        }

        // --- HÀM TÔ MÀU ĐÁP ÁN ---
        private void HighlightCorrectAnswer(string answer)
        {
            if (string.IsNullOrEmpty(answer)) return;

            switch (answer.ToUpper())
            {
                case "A": Answer_Click(txtAnsA, EventArgs.Empty); break;
                case "B": Answer_Click(txtAnsB, EventArgs.Empty); break;
                case "C": Answer_Click(txtAnsC, EventArgs.Empty); break;
                case "D": Answer_Click(txtAnsD, EventArgs.Empty); break;
            }
        }

        // --- HÀM TÔ MÀU KHI CHỌN ---
        private void Answer_Click(object sender, EventArgs e)
        {
            if (txtAnsA.ReadOnly) return; // Nếu đang ở chế độ xem, không cho phép chọn
            UITextBox selected = (UITextBox)sender;
            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };

            foreach (var txt in answerBoxes)
            {
                txt.FillColor = txt.FillReadOnlyColor = colorNormal;
                txt.RectSides = ToolStripStatusLabelBorderSides.None;
            }
            selected.FillColor = selected.FillReadOnlyColor = colorSelected;
            selected.RectColor = selected.RectReadOnlyColor = colorBorderSelected;
            selected.RectSides = ToolStripStatusLabelBorderSides.All;
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

        private void flpOptions_SizeChanged(object sender, EventArgs e)
        {
            // Tạm dừng vẽ để tránh bị nháy màn hình
            flpOptions.SuspendLayout();

            foreach (Control ctrl in flpOptions.Controls)
            {
                ctrl.Width = flpOptions.ClientSize.Width - flpOptions.Padding.Horizontal - 5;
            }

            flpOptions.ResumeLayout();
        }

        // --- HÀM LẤY DỮ LIỆU ĐÃ CHỈNH SỬA ---
        public QuestionModel GetData()
        {
            if (_currentQuestion == null) return null;

            try
            {
                // 1. Cập nhật nội dung câu hỏi
                _currentQuestion.Question = txtContentDisplay.Text.Trim();

                // 2. Cập nhật các đáp án (Loại bỏ tiền tố "A. ", "B. " nếu có)
                _currentQuestion.OptionA = CleanOptionText(txtAnsA.Text, 'A'); 
                _currentQuestion.OptionB = CleanOptionText(txtAnsB.Text, 'B'); 
                _currentQuestion.OptionC = CleanOptionText(txtAnsC.Text, 'C'); 
                _currentQuestion.OptionD = CleanOptionText(txtAnsD.Text, 'D'); 

                // 3. Xác định đáp án đúng dựa trên màu sắc được chọn (FillColor)
                var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
                char[] prefixes = { 'A', 'B', 'C', 'D' };

                for (int i = 0; i < answerBoxes.Length; i++)
                {
                    if (answerBoxes[i].FillColor == colorSelected)
                    {
                        _currentQuestion.Answer = prefixes[i].ToString();
                break;
                    }
                }

                return _currentQuestion;
    }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thu thập dữ liệu: " + ex.Message);
                return null;
            }
        }

        // Hàm phụ trợ để xóa bỏ các tiền tố "A. ", "B. " do hàm SetData tự thêm vào trước đó
        private string CleanOptionText(string text, char prefix)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;

            string startMatch = prefix + ". ";
            if (text.StartsWith(startMatch, StringComparison.OrdinalIgnoreCase))
            {
                return text.Substring(3).Trim();
    }
            return text.Trim();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SwapEditMode();
        }

        public void SwapEditMode()
        {
            var List_txt = new[] { txtContentDisplay, txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            for (int i = 0; i < List_txt.Length; i++)
            {
                var txt = List_txt[i];
                txt.ReadOnly = !txt.ReadOnly;
            }
            txtContentDisplay.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _currentQuestion.IsActive = false;
            this.Dispose();
        }
    }
}