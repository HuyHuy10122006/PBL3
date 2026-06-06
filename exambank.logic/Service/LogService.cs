using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xceed.Document.NET;

namespace exambank.logic.Service
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

        //Hàm lưu nhật ký tạo câu hỏi của người dùng bằng AI
        public void SaveCreateQuestion(DateTime now, int totalQuestion, string username, int userId)
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    // Tạo một bản ghi nhật ký mới
                    var aiLog = new SystemLog
                    {
                        LogTime = now,
                        Username = username ?? "User:" + userId, // Lưu người dùng nào vừa gọi AI
                        Action = "Sử dụng AI tạo câu hỏi", // Chữ "AI" này sẽ giúp Admin nhận diện được
                        Status = (totalQuestion > 0) ? "Thành công" : "Thất bại" // Ghi nhận trạng thái để tính Tỷ lệ %
                    };

                    db.SystemLogs.Add(aiLog);
                    db.SaveChanges(); // Lưu vào sổ nhật ký
                }
            }
            catch (Exception exLog)
            {
                Debug.WriteLine("Lỗi không ghi được Log AI: " + exLog.Message);
            }
        }

        //Lưu file tài liệu nguồn
        public void SaveSourceDocument(int userId, string filePath)
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    string tenFile = System.IO.Path.GetFileName(filePath);

                    var tonTai = db.Documents.FirstOrDefault(d => d.FileName == tenFile && d.UserId == userId);

                    if (tonTai == null)
                    {
                        string loaiFile = System.IO.Path.GetExtension(filePath);
                        var taiLieuMoi = new DocumentModel
                        {
                            FileName = tenFile,
                            DocumentType = loaiFile,
                            UserId = userId,
                            UploadedAt = DateTime.Now,
                            IsActive = true,
                            FilePath = filePath
                        };

                        db.Documents.Add(taiLieuMoi);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
