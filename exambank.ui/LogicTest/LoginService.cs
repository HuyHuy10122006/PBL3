using exambank.data;
using exambank.data.Models;
using System;
using System.Linq;

namespace exambank.ui.LogicTest
{
    public enum LoginStatus
    {
        Success,
        Locked,
        Invalid
    }

    public class LoginService
    {
        public (LoginStatus Status, UserModel User) CheckLogin(string username, string password)
        {
            using (var db = new ExamBankDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username || u.Email == username);

                if (user == null)
                {
                    return (LoginStatus.Invalid, null);
                }

                if (!user.IsActive)
                {
                    return (LoginStatus.Locked, null);
                }

                if (string.IsNullOrEmpty(user.Password) || !Base.UIHelper.VerifyPassword(password, user.Password))
                {
                    return (LoginStatus.Invalid, null);
                }

                return (LoginStatus.Success, user);
            }
        }

        public bool RegisterUser(string fullName, string email, string username, string password, out string mess)
        {
            using (var db = new ExamBankDbContext())
            {
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
                if (isSent)
                {
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

        private bool SendRecoveryEmail(string email, string fullName)
        {
            return true;
        }
    }
}