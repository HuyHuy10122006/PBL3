using exambank.data;
using exambank.data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace exambank.ui.LogicTest
{
    public class QuestionService
    {
        public List<QuestionModel> GetAllQuestions()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    return db.Questions.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách câu hỏi: " + ex.Message);
                return new List<QuestionModel>();
            }
        }

        public bool AddQuestion(QuestionModel q)
        {
            // Kiểm tra logic nghiệp vụ cơ bản
            if (string.IsNullOrEmpty(q.Question) || string.IsNullOrEmpty(q.Answer))
                return false;

            try
            {
                using (var db = new ExamBankDbContext())
                {
                    db.Questions.Add(q);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lưu: " + ex.Message);
                return false;
            }
        }

        public bool DeleteQuestion(int id)
        {
            using (var db = new ExamBankDbContext())
            {
                var q = db.Questions.Find(id);
                if (q == null) return false;
                q.IsActive = false; // Xóa mềm
                return db.SaveChanges() > 0;
            }
        }

        public bool SaveQuestions(List<QuestionModel> questions)
        {
            using (var db = new ExamBankDbContext())
            {
                db.Questions.AddRange(questions);
                return db.SaveChanges() > 0;
            }
        }

        public List<QuestionModel> GetQuestions(string keyword, string mon, string khoi, string doKho)
        {
            using (var db = new ExamBankDbContext())
            {
                var query = db.Questions.Where(q => q.IsActive);

                if (!string.IsNullOrEmpty(keyword))
                    query = query.Where(q => q.Question.Contains(keyword));
                if (!string.IsNullOrEmpty(mon))
                    query = query.Where(q => q.Subject == mon);
                if (!string.IsNullOrEmpty(doKho))
                    query = query.Where(q => q.Difficulty == doKho);
                if (!string.IsNullOrEmpty(khoi))
                    query = query.Where(q => q.Grade == khoi);

                return query.OrderByDescending(q => q.CreatedAt).ToList();
            }
        }

        public bool DeleteMultiple(List<int> ids)
        {
            using (var db = new ExamBankDbContext())
            {
                var targets = db.Questions.Where(q => ids.Contains(q.Id)).ToList();
                foreach (var t in targets) t.IsActive = false;
                return db.SaveChanges() > 0;
            }
        }

        public async Task<List<string>> GetUniqueValuesAsync(Func<QuestionModel, string> selector)
        {
            using (var db = new ExamBankDbContext())
            {
                return await Task.Run(() => db.Questions
                    .AsNoTracking()
                    .AsEnumerable() // Chuyển về IEnumerable để dùng Func selector
                    .Select(selector)
                    .Where(val => !string.IsNullOrEmpty(val))
                    .Distinct()
                    .OrderBy(val => val)
                    .ToList());
            }
        }

        public bool UpdateQuestion(QuestionModel updatedData)
        {
            if (updatedData == null || updatedData.Id <= 0) return false; 

        try
            {
                using (var db = new ExamBankDbContext())
                {
                    // 1. Tìm câu hỏi gốc trong Database dựa vào ID
                    var existingQuestion = db.Questions.FirstOrDefault(q => q.Id == updatedData.Id);

                    if (existingQuestion != null)
                    {
                        // 2. Cập nhật các thuộc tính nội dung
                        existingQuestion.Question = updatedData.Question; 
                    existingQuestion.OptionA = updatedData.OptionA; 
                    existingQuestion.OptionB = updatedData.OptionB; 
                    existingQuestion.OptionC = updatedData.OptionC; 
                    existingQuestion.OptionD = updatedData.OptionD; 
                    existingQuestion.Answer = updatedData.Answer; 

                    // 3. Cập nhật các Metadata nếu cần thiết
                    existingQuestion.Subject = updatedData.Subject; 
                    existingQuestion.Difficulty = updatedData.Difficulty;
                    existingQuestion.IsActive = updatedData.IsActive;
                    
                    // Không cập nhật CreatedAt và CreatedByUserId để giữ nguyên lịch sử

                    // 4. Lưu thay đổi xuống SQL Server
                    return db.SaveChanges() > 0;
                }
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây
                throw new Exception("Lỗi khi cập nhật câu hỏi: " + ex.Message);
            }
        }
    }
}
