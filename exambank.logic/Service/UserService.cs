using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace exambank.logic.Service
{
    public class UserService
    {
        private readonly LogService _logService = new LogService();

        // Lấy toàn bộ danh sách người dùng
        public List<UserModel> GetAllUsers()
        {
            using (var db = new ExamBankDbContext())
            {
                return db.Users.ToList();
            }
        }

        // Thay đổi trạng thái tài khoản (Khóa/Mở khóa)
        public void ToggleUserStatus(int userId, int currentUserId)
        {
            using (var db = new ExamBankDbContext())
            {
                var currentUser = db.Users.Find(currentUserId);
                var targetUser = db.Users.Find(userId);

                if (currentUser == null || targetUser == null)
                    throw new Exception("Không tìm thấy thông tin người dùng trên hệ thống.");

                // 1. Kiểm tra an toàn: Không cho tự khóa chính mình
                if (userId == currentUserId)
                    throw new Exception("Bạn không thể tự khóa tài khoản của chính mình.");

                // 2. Kiểm tra an toàn: Không cho phép sờ vào SuperAdmin
                if (targetUser.Role == "SuperAdmin")
                    throw new Exception("Không thể thay đổi trạng thái của tài khoản SuperAdmin.");

                // 3. Phân quyền: Admin thường không được khóa Admin khác
                if (currentUser.Role == "Admin" && targetUser.Role == "Admin")
                    throw new Exception("Admin không có quyền khóa tài khoản Admin khác.");

                // Nếu vượt qua tất cả các bộ chặn -> Thực hiện đảo trạng thái
                targetUser.IsActive = !targetUser.IsActive;
                db.SaveChanges();

                string action = targetUser.IsActive ? "Mở khóa tài khoản" : "Khóa tài khoản";
                _logService.Add(currentUser.Username, $"{action} (UserId:{userId}, Username:{targetUser.Username})", "Thành công");
            }
        }

        // Thay đổi vai trò người dùng (Admin / Teacher)
        public void SetUserRole(int userId, string role, int currentUserId)
        {
            using (var db = new ExamBankDbContext())
            {
                var currentUser = db.Users.Find(currentUserId);
                var targetUser = db.Users.Find(userId);

                if (currentUser == null || targetUser == null)
                    throw new Exception("Không tìm thấy người dùng.");

                if (currentUser.Role != "SuperAdmin")
                    throw new Exception("Bạn không có quyền thay đổi vai trò.");

                if (userId == currentUserId)
                    throw new Exception("Không thể tự thay đổi vai trò của chính mình.");

                role = role?.Trim();

                if (role != "Admin" && role != "Teacher")
                    throw new Exception("Vai trò không hợp lệ.");

                if (targetUser.Role == "SuperAdmin")
                    throw new Exception("Không được thay đổi tài khoản SuperAdmin.");

                if (!targetUser.IsActive)
                    throw new Exception("Tài khoản đang bị khóa.");

                if (targetUser.Role == role)
                    return;

                targetUser.Role = role;
                db.SaveChanges();

                _logService.Add(currentUser.Username, $"Thay đổi vai trò (UserId:{userId}, Username:{targetUser.Username}, Role:{role})", "Thành công");
            }
        }

        // Đổi mật khẩu (dành cho user thay đổi mật khẩu của chính họ)
        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            using (var db = new ExamBankDbContext())
            {
                var user = db.Users.Find(userId);
                if (user == null)
                    throw new Exception("Không tìm thấy người dùng.");

                if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
                    throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự.");

                // Kiểm tra mật khẩu cũ
                if (!LoginService.VerifyPassword(oldPassword, user.Password))
                    throw new Exception("Mật khẩu cũ không đúng.");

                // Nếu mật khẩu mới giống mật khẩu cũ (sau khi băm) thì vẫn cho là không được
                if (LoginService.VerifyPassword(newPassword, user.Password))
                    throw new Exception("Mật khẩu mới không được trùng với mật khẩu hiện tại.");

                // Lưu mật khẩu mới (băm trước khi lưu)
                user.Password = LoginService.HashPassword(newPassword);
                db.SaveChanges();
            }
        }

        // Reset mật khẩu (dành cho Admin/SuperAdmin reset mật khẩu cho user khác)
        public void ResetPassword(int userId, string newPassword, int currentUserId)
        {
            using (var db = new ExamBankDbContext())
            {
                var currentUser = db.Users.Find(currentUserId);
                var targetUser = db.Users.Find(userId);

                if (currentUser == null || targetUser == null)
                    throw new Exception("Không tìm thấy người dùng.");

                // Chỉ Admin hoặc SuperAdmin được reset mật khẩu
                if (currentUser.Role != "Admin" && currentUser.Role != "SuperAdmin")
                {
                    throw new Exception("Bạn không có quyền reset mật khẩu.");
                }

                // Không cho phép reset tài khoản SuperAdmin
                if (targetUser.Role == "SuperAdmin")
                    throw new Exception("Không thể reset mật khẩu của tài khoản SuperAdmin.");

                // Không reset cho tài khoản bị khóa
                if (!targetUser.IsActive)
                    throw new Exception("Tài khoản đang bị khóa.");

                // Kiểm tra mật khẩu mới
                if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
                    throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự.");

                targetUser.Password = LoginService.HashPassword(newPassword);

                db.SaveChanges();
            }
        }
    }
}