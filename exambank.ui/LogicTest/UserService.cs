using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace exambank.ui.LogicTest
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

        // Khóa hoặc mở khóa người dùng
        // Thêm optional parameter actorUsername để biết ai thực hiện (mặc định "System")
        public void ToggleUserStatus(int userId, string actorUsername = "System")
        {
            using (var db = new ExamBankDbContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.IsActive = !user.IsActive; // Đảo ngược trạng thái
                    db.SaveChanges();

                    string action = user.IsActive ? "Mở khóa tài khoản" : "Khóa tài khoản";
                    _logService.Add(actorUsername, $"{action} (UserId:{userId}, Username:{user.Username})", "Thành công");
                }
            }
        }
    }
}