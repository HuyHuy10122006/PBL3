using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

using Sunny.UI;
using exambank.data.Models;
using System;

namespace exambank.ui
{
    public partial class FormTaoDe_MaTran : UIEditForm
    {
        public string ExamTitle => txtExamName.Text.Trim();
        public string ExamCode => txtExamCode.Text.Trim();
        public int Duration => (int)udtxtTime.IntValue;
        public int QuestionCount => (int)udtxtCountQuestion.IntValue;
        public string SelectedSubject => cbMonHoc.Text;

        public FormTaoDe_MaTran()
        {
            InitializeComponent();
            var now = DateTime.Now;
            txtExamCode.Text = now.ToString("yyyyMMddHHmmss");
            cbMonHoc.Items.AddRange(Base.Constants.List_MonHoc);
            cbMonHoc.SelectedIndex = 0;
            txtExamName.Text = $"{cbMonHoc.Text} - {txtExamCode.Text}";
            udtxtCountQuestion.Text = "10";
            udtxtTime.Text = "10";
        }

        // Hàm kiểm tra dữ liệu trước khi đóng Form
        protected override bool CheckData()
        {
            // 1. Kiểm tra Tên đề thi (Bắt buộc, Max 200)
            if (string.IsNullOrWhiteSpace(txtExamName.Text))
                return ShowValidationError(txtExamName, "Tên đề thi không được để trống.");
            if (txtExamName.Text.Length > 200)
                return ShowValidationError(txtExamName, "Tên đề thi quá dài (tối đa 200 ký tự).");

            // 2. Kiểm tra Mã đề thi (Bắt buộc, Max 20)
            if (string.IsNullOrWhiteSpace(txtExamCode.Text))
                return ShowValidationError(txtExamCode, "Mã đề thi không được để trống.");
            if (txtExamCode.Text.Length > 20)
                return ShowValidationError(txtExamCode, "Mã đề quá dài (tối đa 20 ký tự).");

            // 3. Kiểm tra Thời gian (Phải > 0)
            if (udtxtTime.IntValue <= 0)
                return ShowValidationError(udtxtTime, "Thời gian làm bài phải lớn hơn 0 phút.");

            // 4. Kiểm tra Số lượng câu hỏi (Phải > 0)
            if (udtxtCountQuestion.IntValue <= 0)
                return ShowValidationError(udtxtCountQuestion, "Số lượng câu hỏi phải lớn hơn 0.");

            //5. Kiểm tra Môn học
            if (string.IsNullOrWhiteSpace(cbMonHoc.Text))
                return ShowValidationError(cbMonHoc, "Vui lòng chọn môn học.");

            return true; // Tất cả đều hợp lệ
        }

        private bool ShowValidationError(Control c, string msg)
        {
            UIMessageBox.ShowError2(msg);
            c.Focus();
            return false;
        }

        
    }
}