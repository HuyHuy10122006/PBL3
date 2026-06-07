using exambank.data;
using exambank.data.Models;
using System;
using System.Linq;

namespace exambank.logic.Service
{
    public enum LoginStatus
    {
        Success,
        Locked,
        Invalid
    }

    public class LoginService
    {
        // Trả về (LoginStatus, UserModel) để UI có thể phân biệt tài khoản bị khóa
        public (LoginStatus Status, UserModel? User) CheckLogin(string username, string password)
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

                if (string.IsNullOrEmpty(user.Password) || !LoginService.VerifyPassword(password, user.Password))
                {
                    return (LoginStatus.Invalid, null);
                }

                // Cập nhật LastLogin
                user.LastLogin = DateTime.Now;
                db.SaveChanges();

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

        //Hàm lấy danh sách email của các tài khoản Admin để hiển thị ở form Quên mật khẩu
        public string[] GetAdminEmails()
        {
            using (var db = new ExamBankDbContext())
            {
                return db.Users
                    .Where(u => u.Role.Contains("Admin") && u.IsActive)
                    .Select(u => u.Email)
                    .ToArray();
            }
        }

        // Hàm băm mật khẩu khi người dùng Đăng ký
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 11);
        }

        /// <param name="password">Mật khẩu thô do user nhập ở form Login</param>
        /// <param name="storedHash">Chuỗi Hash đã lưu trong Database từ trước</param>
        // Hàm kiểm tra mật khẩu khi người dùng Đăng nhập
        public static bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}