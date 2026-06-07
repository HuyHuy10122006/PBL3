using exambank.data.Models;
using exambank.ui.Base;
using exambank.ui.Common;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class FormGiaoVien : UIForm
    {
        private UserModel _loginUser;
        private NavigationService _nav;

        // Khai báo thêm biến cho Trang chủ
        private UC_TrangChu _ucTrangChu;
        private UC_AICreate _ucAICreate;
        private UC_ManageQuestions _ucManageQuestions;
        private UC_ManageExams _ucManageExams;
        private UC_ViewExamBank _ucViewExamBank;
        private List<UIButton> menuButtons;
        private List<QuestionModel> _currentQuestions = new List<QuestionModel>();
        private List<ExamModel> _currentExams = new List<ExamModel>();

        public FormGiaoVien(UserModel user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            menuButtons = new List<UIButton> { btnHome, btnCreateQuestion, btnManageQuestions, btnManageExams, btnViewExamBank };
            _loginUser = user;
            _nav = new NavigationService(pnlBody);
            if (_loginUser != null)
            {
                // 1. Cập nhật Tên và Vai trò
                lblSidebarName.Text = _loginUser.FullName ?? _loginUser.Username;
                lblSidebarRole.Text = _loginUser.Role == "1" ? "Quản trị viên" : "Giáo viên";

                // 2. Tự động trích xuất chữ cái đầu của Tên để làm ảnh Avatar (VD: "Nguyễn Huy" -> "H")
                string displayName = lblSidebarName.Text.Trim();
                int lastSpaceIndex = displayName.LastIndexOf(' ');

                if (lastSpaceIndex >= 0 && lastSpaceIndex < displayName.Length - 1)
                {
                    // Lấy chữ cái đầu tiên của từ cuối cùng
                    avtUser.Text = displayName.Substring(lastSpaceIndex + 1, 1).ToUpper();
                }
                else if (displayName.Length > 0)
                {
                    avtUser.Text = displayName.Substring(0, 1).ToUpper();
                }
            }

            // Mở Trang chủ làm màn hình mặc định khi Form vừa load xong
            btnHome_Click(null, null);
        }

        // Sự kiện Click cho nút Trang chủ
        private void btnHome_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnHome, menuButtons);

            // Nếu chưa khởi tạo thì tạo mới, có rồi thì gọi ra để tiết kiệm RAM
            if (_ucTrangChu == null)
            {
                _ucTrangChu = new UC_TrangChu(_loginUser);
                _ucTrangChu.Dock = DockStyle.Fill;
            }
            _nav.Display(_ucTrangChu);
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnCreateQuestion, menuButtons);
            if (_ucAICreate == null)
            {
                _ucAICreate = new UC_AICreate(_loginUser);
            }
            _nav.Display(_ucAICreate);
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageQuestions, menuButtons);
            if (_ucManageQuestions == null)
            {
                _ucManageQuestions = new UC_ManageQuestions(_loginUser, _currentQuestions);
            }
            _nav.Display(_ucManageQuestions);
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnManageExams, menuButtons);
            if (_ucManageExams == null)
            {
                _ucManageExams = new UC_ManageExams(_loginUser, _currentExams);
            }
            _nav.Display(_ucManageExams);
        }

        private void btnViewExamBank_Click(object sender, EventArgs e)
        {
            UIHelper.SetActiveMenu(btnViewExamBank, menuButtons);
            if (_ucViewExamBank == null)
            {
                _ucViewExamBank = new UC_ViewExamBank(_loginUser);
            }
            _nav.Display(_ucViewExamBank);
        }

    
        private void FormGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu DialogResult KHÔNG PHẢI là OK, nghĩa là người dùng bấm X hoặc Alt+F4
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit(); // Thoát toàn bộ ứng dụng, không cho quay lại Form Login
            }
        }

       

        // TÍNH NĂNG MỚI: Click vào Avatar để mở trang Profile
        private void avtUser_Click(object sender, EventArgs e)
        {
          
            UC_ProfileSettings ucProfile = new UC_ProfileSettings(_loginUser);

            // Tận dụng luôn biến _nav có sẵn của bạn để hiển thị giao diện cực mượt
            _nav.Display(ucProfile);

            // (Tùy chọn) Nếu muốn xóa hiệu ứng "đang chọn" của các nút menu bên trái khi mở Profile
            UIHelper.SetActiveMenu(null, menuButtons);
        }
    }
}