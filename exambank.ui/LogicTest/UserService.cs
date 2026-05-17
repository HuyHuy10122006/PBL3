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

        //Khóa hoặc mở khóa người dùng
        public void ToggleUserStatus(int userId)
        {
            using (var db = new ExamBankDbContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.IsActive = !user.IsActive; // Đảo ngược trạng thái
                    db.SaveChanges();
                }
            }
        }
    }
}