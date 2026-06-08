using exambank.data.Models;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace exambank.ui.Common
{
    public class FormEditProfile : UIForm
    {
        private UserModel _user;
        private UserService _userService = new UserService();
        
        private UITextBox txtFullName;
        private UITextBox txtEmail;
        private UITextBox txtPhone;
        private UITextBox txtUniversity;
        private UIComboBox cbSubjects;
        private UIComboBox cbAiDifficulty;
        private UIButton btnSave;
        private UIButton btnCancel;

        public FormEditProfile(UserModel user)
        {
            _user = user;
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.Text = "Cập nhật thông tin cá nhân";
            this.Size = new Size(500, 550);
            this.StartPosition = FormStartPosition.CenterParent;

            int yPos = 50;
            int spacing = 60;
            
            // FullName (Không cho phép sửa)
            this.Controls.Add(new UILabel { Text = "Họ và tên:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            txtFullName = new UITextBox { Location = new Point(160, yPos), Size = new Size(300, 35), ReadOnly = true, FillColor = Color.FromArgb(240, 240, 240) };
            this.Controls.Add(txtFullName);
            yPos += spacing;

            // Email (Không cho phép sửa)
            this.Controls.Add(new UILabel { Text = "Email:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            txtEmail = new UITextBox { Location = new Point(160, yPos), Size = new Size(300, 35), ReadOnly = true, FillColor = Color.FromArgb(240, 240, 240) };
            this.Controls.Add(txtEmail);
            yPos += spacing;

            // Phone
            this.Controls.Add(new UILabel { Text = "Điện thoại:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            txtPhone = new UITextBox { Location = new Point(160, yPos), Size = new Size(300, 35) };
            this.Controls.Add(txtPhone);
            yPos += spacing;

            // University
            this.Controls.Add(new UILabel { Text = "Đơn vị:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            txtUniversity = new UITextBox { Location = new Point(160, yPos), Size = new Size(300, 35) };
            this.Controls.Add(txtUniversity);
            yPos += spacing;

            // Subjects
            this.Controls.Add(new UILabel { Text = "Bộ môn:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            cbSubjects = new UIComboBox { Location = new Point(160, yPos), Size = new Size(300, 35) };
            cbSubjects.Items.AddRange(exambank.ui.Base.Constants.List_MonHoc);
            this.Controls.Add(cbSubjects);
            yPos += spacing;

            // AiDifficulty
            this.Controls.Add(new UILabel { Text = "Mức độ ưu tiên:", Location = new Point(30, yPos), Size = new Size(120, 30) });
            cbAiDifficulty = new UIComboBox { Location = new Point(160, yPos), Size = new Size(300, 35) };
            cbAiDifficulty.Items.AddRange(exambank.ui.Base.Constants.List_DoKho);
            this.Controls.Add(cbAiDifficulty);
            yPos += spacing + 20;

            // Buttons
            btnSave = new UIButton { Text = "Lưu thay đổi", Location = new Point(160, yPos), Size = new Size(140, 40) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnCancel = new UIButton { Text = "Hủy", Location = new Point(320, yPos), Size = new Size(140, 40), FillColor = Color.Gray };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            this.Controls.Add(btnCancel);
        }

        private void LoadData()
        {
            txtFullName.Text = _user.FullName;
            txtEmail.Text = _user.Email;
            txtPhone.Text = _user.Phone;
            txtUniversity.Text = _user.University;
            cbSubjects.Text = _user.Subjects;
            cbAiDifficulty.Text = _user.AiDifficulty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _user.Phone = txtPhone.Text;
            _user.University = txtUniversity.Text;
            _user.Subjects = cbSubjects.Text;
            _user.AiDifficulty = cbAiDifficulty.Text;

            try
            {
                _userService.UpdateProfile(_user);
                UIMessageTip.ShowOk("Cập nhật thông tin thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
