using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace exambank.ui.LogicTest
{
    public class UserService
    {
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
                // Giả định: Trên giao diện là chữ "Hoạt động"/"Bị khóa", trong DB IsActive lưu kiểu bool (true/false)
                targetUser.IsActive = !targetUser.IsActive;
                db.SaveChanges();
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
                    throw new Exception("Không tìm thấy thông tin người dùng trên hệ thống.");

                // 1. Kiểm tra an toàn tối cao: Chỉ duy nhất SuperAdmin mới có quyền nâng/hạ
                if (currentUser.Role != "SuperAdmin")
                    throw new Exception("Chỉ tài khoản SuperAdmin tối cao mới có quyền thay đổi vai trò Admin.");

                // 2. Không cho phép tự hạ quyền chính mình (SuperAdmin không được tự hạ xuống Admin/Teacher)
                if (userId == currentUserId)
                    throw new Exception("Bạn không thể tự thay đổi vai trò của chính mình.");

                // 3. Quy tắc Business: Tài khoản phải đang HOẠT ĐỘNG thì mới được nâng/hạ quyền
                if (!targetUser.IsActive) // Tương đương với trạng thái "Bị khóa" ở UI
                    throw new Exception("Tài khoản đang bị khóa, vui lòng mở khóa trước khi thay đổi vai trò.");

                // Thực hiện đổi quyền và lưu
                targetUser.Role = role;
                db.SaveChanges();
            }
        }
    }
}