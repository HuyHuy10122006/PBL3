using System;
using System.Collections.Generic;
using System.Linq;
using exambank.data;
using exambank.data.Models;

namespace exambank.ui.LogicTest
{
    public class LogService
    {
        public void Add(string username, string action, string status)
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var log = new SystemLog
                    {
                        Username = username ?? "unknown",
                        Action = action ?? string.Empty,
                        Status = status ?? string.Empty,
                        LogTime = DateTime.Now
                    };
                    db.SystemLogs.Add(log);
                    db.SaveChanges();
                }
            }
            catch
            {
                // Không ném lỗi để không ảnh hưởng UI; có thể mở rộng để ghi file log khi cần.
            }
        }

        public List<SystemLog> GetRecent(int take = 200)
        {
            using (var db = new ExamBankDbContext())
            {
                return db.SystemLogs
                         .OrderByDescending(l => l.LogTime)
                         .Take(take)
                         .ToList();
            }
        }
    }
}
