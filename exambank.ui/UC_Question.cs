using exambank.data.Models;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_Question : UserControl
    {
        private QuestionModel _currentQuestion;
        private string _selectedAnswerCode = ""; // Lưu đáp án đang chọn (A, B, C, D)
        private bool _isInitializing = false;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int WM_MOUSEWHEEL = 0x020A;

        // Màu sắc đồng nhất với hệ thống
        private readonly Color colorNormal = Color.White;
        private readonly Color colorSelected = Color.FromArgb(230, 247, 235);
        private readonly Color colorBorderSelected = Color.FromArgb(40, 167, 69);

        public UC_Question(QuestionModel question, string header)
        {
            _currentQuestion = question;
            InitializeComponent();

            // Thiết lập ban đầu cho các ComboBox
            cbKhoi.Items.AddRange(Base.Constants.List_Khoi);
            cbDoKho.Items.AddRange(Base.Constants.List_DoKho);
            cbMonHoc.Items.AddRange(Base.Constants.List_MonHoc);

            // Gán dữ liệu vào UC
            SetData(header);
        }

        private void SetData(string header)
        {
            _isInitializing = true; // 1. BẬT CỜ: Báo cho hệ thống biết đang nạp dữ liệu, đừng chặn tô màu

            // Đăng ký sự kiện MouseWheel
            txtContentDisplay.MouseWheel -= RedirectWheel;
            txtContentDisplay.MouseWheel += RedirectWheel;

            lblNumber.Text = header;
            txtContentDisplay.Text = _currentQuestion.Question;

            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            string[] options = { _currentQuestion.OptionA, _currentQuestion.OptionB, _currentQuestion.OptionC, _currentQuestion.OptionD };
            char prefix = 'A';

            // Tắt ReadOnly tạm thời để cài đặt dữ liệu mà không bị chặn bởi Answer_Click
            SetReadOnlyMode(false);

            for (int i = 0; i < answerBoxes.Length; i++)
            {
                if (i < options.Length && !string.IsNullOrEmpty(options[i]))
                {
                    answerBoxes[i].Visible = true;
                    if (string.IsNullOrEmpty(options[1]) && i == 0) // Short Answer condition
                    {
                        answerBoxes[i].Text = $"Đáp án: {options[i]}";
                    }
                    else
                    {
                        answerBoxes[i].Text = $"{prefix}. {options[i]}";
                    }

                    answerBoxes[i].MouseWheel -= RedirectWheel;
                    answerBoxes[i].MouseWheel += RedirectWheel;
                }
                else
                {
                    answerBoxes[i].Visible = false;
                }
                prefix++;
            }

            cbMonHoc.Text = _currentQuestion.Subject;
            cbKhoi.Text = _currentQuestion.Grade;
            cbDoKho.Text = _currentQuestion.Difficulty;

            RecalculateLayout();

            // Highlight đáp án đúng ban đầu
            HighlightCorrectAnswer(_currentQuestion.Answer);

            // Mặc định ban đầu sau khi nạp data là CHỈ XEM (ReadOnly = true)
            SetReadOnlyMode(true);

            _isInitializing = false; // 2. TẮT CỜ: Nạp xong rồi, từ bây giờ ai click vào sẽ bị chặn nếu đang ReadOnly
        }

        private void RecalculateLayout()
        {
            this.SuspendLayout();
            flpOptions.SuspendLayout();

            int contentWidth = txtContentDisplay.Width - 15;
            txtContentDisplay.Height = GetPerfectHeight(txtContentDisplay, txtContentDisplay.Text, contentWidth);

            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            foreach (var txt in answerBoxes)
            {
                if (txt.Visible)
                {
                    txt.Width = flpOptions.Width - 10;
                    int txtWidth = txt.Width - 15;
                    txt.Height = GetPerfectHeight(txt, txt.Text, txtWidth);
                }
            }

            UpdateComponentLayout();

            flpOptions.ResumeLayout(true);
            this.ResumeLayout(true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (txtContentDisplay != null && !string.IsNullOrEmpty(txtContentDisplay.Text))
            {
                RecalculateLayout();
            }
        }

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

        private void Answer_Click(object sender, EventArgs e)
        {
            UITextBox selected = (UITextBox)sender;

            // Nếu đang ở chế độ ReadOnly VÀ đây không phải là lúc nạp data hệ thống -> CHẶN CLICK
            if (selected.ReadOnly && !_isInitializing)
            {
                return;
            }

            var answerBoxes = new[] { txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            string[] codes = { "A", "B", "C", "D" };

            for (int i = 0; i < answerBoxes.Length; i++)
            {
                answerBoxes[i].FillColor = answerBoxes[i].FillReadOnlyColor = colorNormal;
                answerBoxes[i].RectSides = ToolStripStatusLabelBorderSides.None;

                if (answerBoxes[i] == selected)
                {
                    _selectedAnswerCode = codes[i];
                }
            }

            selected.FillColor = selected.FillReadOnlyColor = colorSelected;
            selected.RectColor = selected.RectReadOnlyColor = colorBorderSelected;
            selected.RectSides = ToolStripStatusLabelBorderSides.All;
        }

        private int GetPerfectHeight(UITextBox txt, string text, int width)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            Size size = TextRenderer.MeasureText(text, txt.Font, new Size(width, int.MaxValue), TextFormatFlags.WordBreak);
            return size.Height + 10;
        }

        private void UpdateComponentLayout()
        {
            flpOptions.Top = txtContentDisplay.Bottom + 5;

            int totalH = 0;
            foreach (Control c in flpOptions.Controls)
            {
                if (c.Visible) totalH += c.Height + c.Margin.Bottom;
            }
            flpOptions.Height = totalH + 15;

            int nextTop = flpOptions.Bottom + 20;
            void PositionPair(Control lbl, Control combo)
            {
                if (lbl == null || combo == null || (!lbl.Visible && !combo.Visible)) return;
                lbl.Top = nextTop;
                combo.Top = nextTop;
                int pairHeight = Math.Max(lbl.Height, combo.Height);
                nextTop += pairHeight + 10;
                totalH += pairHeight + 10;
            }
            PositionPair(lblKhoi, cbKhoi);
            PositionPair(lblDoKho, cbDoKho);
            PositionPair(lblMonHoc, cbMonHoc);

            pnlCard.Height = flpOptions.Top + totalH + 40;
            this.Height = pnlCard.Height + 20;
        }

        private void RedirectWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            if (this.Parent != null)
                SendMessage(this.Parent.Handle, WM_MOUSEWHEEL, (IntPtr)e.Delta << 16, IntPtr.Zero);
        }

        // Cho phép chuyển đổi giữa chế độ Chỉ Xem (ReadOnly) và Chỉnh Sửa
        public void SetReadOnlyMode(bool isReadOnly)
        {
            cbDoKho.ReadOnly = isReadOnly;
            cbKhoi.ReadOnly = isReadOnly;
            cbMonHoc.ReadOnly = isReadOnly;

            var listTxt = new[] { txtContentDisplay, txtAnsA, txtAnsB, txtAnsC, txtAnsD };
            foreach (var txt in listTxt)
            {
                txt.ReadOnly = isReadOnly;
            }
            if (!isReadOnly) txtContentDisplay.Focus();
        }

        public QuestionModel GetData()
        {
            if (_currentQuestion == null) return null;

            try
            {
                _currentQuestion.Question = txtContentDisplay.Text.Trim();
                _currentQuestion.OptionA = CleanOptionText(txtAnsA.Text, 'A');
                _currentQuestion.OptionB = CleanOptionText(txtAnsB.Text, 'B');
                _currentQuestion.OptionC = CleanOptionText(txtAnsC.Text, 'C');
                _currentQuestion.OptionD = CleanOptionText(txtAnsD.Text, 'D');

                // Lấy trực tiếp từ biến lưu trữ
                _currentQuestion.Answer = _selectedAnswerCode;

                _currentQuestion.Subject = cbMonHoc.Text;
                _currentQuestion.Grade = cbKhoi.Text;
                _currentQuestion.Difficulty = cbDoKho.Text;

                return _currentQuestion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thu thập dữ liệu: " + ex.Message);
                return null;
            }
        }

        private string CleanOptionText(string text, char prefix)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            string startMatch = prefix + ". ";
            if (text.StartsWith(startMatch, StringComparison.OrdinalIgnoreCase))
            {
                return text.Substring(3).Trim();
            }
            if (text.StartsWith("Đáp án: ", StringComparison.OrdinalIgnoreCase))
            {
                return text.Substring(8).Trim();
            }
            return text.Trim();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Nếu đang khóa (ReadOnly = true) -> Mở khóa (false) và ngược lại.
            bool currentStatus = txtContentDisplay.ReadOnly;
            SetReadOnlyMode(!currentStatus);
        }

        public void isFull(bool isFull)
        {
            cbKhoi.Visible = cbDoKho.Visible = cbMonHoc.Visible = isFull;
            lblKhoi.Visible = lblDoKho.Visible = lblMonHoc.Visible = isFull;
        }

        public void isEdit(bool isEdit)
        {
            btnEdit.Visible = btnDelete.Visible = isEdit;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _currentQuestion.IsActive = false;
            this.Dispose();
        }
    }
}