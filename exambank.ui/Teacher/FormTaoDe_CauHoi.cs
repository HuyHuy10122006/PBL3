using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace exambank.ui
{
    public partial class FormTaoDe_CauHoi : UIEditForm
    {
        public string ExamName => txtExamName.Text.Trim();
        public string ExamCode => txtExamCode.Text.Trim();
        public int Duration => (int)udtxtTG.IntValue;

        public FormTaoDe_CauHoi(int questionCount, string subject = null)
        {
            InitializeComponent();
            var now = DateTime.Now;
            lblInfo.Text = $"Số câu hỏi đã chọn: {questionCount} câu";
            txtExamCode.Text = now.ToString("yyyyMMddHHmmss");
            if (!string.IsNullOrEmpty(subject))
            {
                txtExamName.Text = $"Đề thi {subject} - {now:ddMMyyyyHHmmss}";
            }

        }


        // Validate dữ liệu trước khi đóng Form
        protected override bool CheckData()
        {
            if (string.IsNullOrEmpty(ExamName)) return StringError(txtExamName, "Vui lòng nhập tiêu đề đề thi.");
            if (string.IsNullOrEmpty(ExamCode)) return StringError(txtExamCode, "Vui lòng nhập mã đề thi.");
            if (Duration <= 0) return StringError(udtxtTG, "Thời gian làm bài không hợp lệ.");
            return true;
        }

        private bool StringError(Control control, string message)
        {
            UIMessageBox.ShowError2(message);
            control.Focus();
            if (control is UITextBox txt) txt.SelectAll();
            return false;
        }
    }
}
