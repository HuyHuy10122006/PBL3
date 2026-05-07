using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace exambank.ui.LogicTest
{
    public class LoginService
    {
        public UserModel CheckLogin(string username, string password)
        {
            using (var db = new ExamBankDbContext())
            {
                // Lưu ý: Trong thực tế nên dùng BCrypt để Verify password thay vì so sánh chuỗi thuần
                var user = db.Users.FirstOrDefault(u => (u.Username == username || u.Email == username) && u.Password == password);

                if (user != null && user.IsActive)
                {
                    return user;
                }
                return null;
            }
        }

        public bool RegisterUser(string fullName, string email, string username, string password, out string mess)
        {
            using (var db = new ExamBankDbContext())
            {
                // Kiểm tra trùng lặp tài khoản
                if (db.Users.Any(u => u.Username == username))
                {
                    mess = "Tên đăng nhập đã tồn tại!";
                    return false;
                }

                if (db.Users.Any(u => u.Email == email))
                {
                    mess = "Email này đã được sử dụng!";
                    return false;
                }

                // Khởi tạo Model dựa trên UserModel.cs của bạn
                var newUser = new UserModel
                {
                    FullName = fullName,
                    Email = email,
                    Username = username,
                    Password = password,
                    Role = "Teacher",
                    CreatedAt = DateTime.Now,
                    IsActive = true
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                mess = "Đăng ký tài khoản thành công! Bạn có thể đăng nhập ngay bây giờ.";
                return true;
            }
        }
        // Kiểm tra xem email có tồn tại trong cơ sở dữ liệu hay không và gửi yêu cầu khôi phục mật khẩu
        public bool SendPasswordRecoveryRequest(string email, out string mess)
        {
            using (var db = new ExamBankDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    mess = "Email này không tồn tại trong hệ thống!";
                    return false;
                }

                bool isSent = SendRecoveryEmail(email, user.FullName);
                if (isSent) {
                    mess = $"Hướng dẫn khôi phục mật khẩu đã được gửi đến email: {email}.";
                    return true;
                }
                else
                {
                    mess = "Có lỗi xảy ra khi gửi email. Vui lòng thử lại sau!";
                    return false;
                }
            }
        }
        //Hàm mô phỏng gửi email khôi phục mật khẩu.
        private bool SendRecoveryEmail(string email, string fullName)
        {
            // Tạm thời trả về true để mô phỏng thành công
            return true;
        }
    }
}
