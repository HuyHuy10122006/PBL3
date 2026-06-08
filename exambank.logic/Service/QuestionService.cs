using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exambank.logic.Service
{
    public class QuestionService
    {
        // Tạo Repository mới mỗi lần gọi để tránh dữ liệu cache cũ
        private IDatabaseRepository CreateRepository() => new DatabaseRepository(new ExamBankDbContext());

        public async Task<bool> AddQuestionAsync(QuestionModel q)
        {
            // Tối ưu logic: Kiểm tra null và validate dữ liệu cơ bản gọn hơn
            if (q == null || string.IsNullOrWhiteSpace(q.Question) || string.IsNullOrWhiteSpace(q.Answer))
            {
                return false;
            }

            try
            {
                // Sử dụng 1 DbContext duy nhất cho toàn bộ thao tác để tránh lỗi cross-context tracking
                using (var db = new ExamBankDbContext())
                {
                    // Kiểm tra và tạo Category mặc định nếu chưa có
                    if (!db.Categories.Any(c => c.Id == q.CategoryId))
                    {
                        var defaultCat = db.Categories.FirstOrDefault();
                        if (defaultCat == null)
                        {
                            defaultCat = new CategoryModel
                            {
                                Name = "Danh mục mặc định",
                                Description = "Tạo tự động",
                                IsActive = true
                            };
                            db.Categories.Add(defaultCat);
                            await db.SaveChangesAsync();
                        }
                        q.CategoryId = defaultCat.Id;
                    }

                    // Tạo entity MỚI hoàn toàn để tránh lỗi IDENTITY_INSERT
                    var newQuestion = new QuestionModel
                    {
                        // KHÔNG gán Id - để SQL Server tự tăng
                        Question = q.Question,
                        OptionA = q.OptionA,
                        OptionB = q.OptionB,
                        OptionC = q.OptionC,
                        OptionD = q.OptionD,
                        Answer = q.Answer,
                        Explanation = q.Explanation ?? string.Empty,
                        Subject = q.Subject,
                        Grade = q.Grade,
                        Difficulty = q.Difficulty,
                        CategoryId = q.CategoryId,
                        CreatedByUserId = q.CreatedByUserId,
                        CreatedAt = q.CreatedAt,
                        IsActive = q.IsActive,
                        IsAIGenerated = q.IsAIGenerated
                    };

                    db.Questions.Add(newQuestion);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi khi lưu: " + ex.Message);
                throw;
            }
        }

        public async Task<List<QuestionModel>> GetQuestionsAsync(int userId)
        {
            var repo = CreateRepository();
            return await repo.GetQuestionsByUserAsync(userId);
        }

        public async Task<bool> DeleteMultipleAsync(List<int> ids)
        {
            if (ids == null || ids.Count == 0) return false;

            try
            {
                var repo = CreateRepository();
                foreach (var id in ids)
                {
                    // Tận dụng hàm DeleteQuestionAsync (Xóa mềm bằng cách set IsActive = false) đã viết ở Repo
                    await repo.DeleteQuestionAsync(id);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi khi xóa hàng loạt: " + ex.Message);
                return false;
            }
        }


        public List<string> GetCboValuesAsync(List<QuestionModel> questions, Func<QuestionModel, string> selector)
        {
            if (questions == null) return new List<string>();

            return questions
                .Select(selector)
                .Where(val => !string.IsNullOrEmpty(val))
                .Distinct()
                .OrderBy(val => val)
                .ToList();
        }

        public async Task<bool> UpdateQuestionAsync(QuestionModel updatedData)
        {
            if (updatedData == null || updatedData.Id < 0) return false;
            if (updatedData.Id == 0) return await AddQuestionAsync(updatedData);

            try
            {
                var repo = CreateRepository();
                // 1. Lấy câu hỏi gốc từ DB thông qua Repo (đã check IsActive)
                var existingQuestion = await repo.GetQuestionByIdAsync(updatedData.Id);

                if (existingQuestion != null)
                {
                    // 2. Cập nhật các thuộc tính nội dung
                    existingQuestion.Question = updatedData.Question;
                    existingQuestion.OptionA = updatedData.OptionA;
                    existingQuestion.OptionB = updatedData.OptionB;
                    existingQuestion.OptionC = updatedData.OptionC;
                    existingQuestion.OptionD = updatedData.OptionD;
                    existingQuestion.Answer = updatedData.Answer;

                    // 3. Cập nhật các Metadata
                    existingQuestion.Subject = updatedData.Subject;
                    existingQuestion.Difficulty = updatedData.Difficulty;
                    existingQuestion.IsActive = updatedData.IsActive;
                    existingQuestion.CategoryId = updatedData.CategoryId;

                    // 4. Gọi hàm Update của Repo
                    await repo.UpdateQuestionAsync(existingQuestion);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi khi cập nhật câu hỏi: " + ex.Message);
                return false;
            }
        }

        //Hàm đếm tổng môn học của 1 user, dùng để hiển thị số liệu trên trang chủ
        public async Task<List<string>> GetUserSubjectsAsync(int userId)
        {
            var questions = await GetQuestionsAsync(userId);
            return GetCboValuesAsync(questions, q => q.Subject);
        }
    }
}