using exambank.data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exambank.data
{
    public interface IDatabaseRepository
    {
        // ===== Question Methods =====
        Task<List<QuestionModel>> GetQuestionsByCategoryAsync(int categoryId);
        Task<QuestionModel?> GetQuestionByIdAsync(int id);
        Task<QuestionModel?> GetQuestionByIdWithCategoryAsync(int id);
        Task<List<QuestionModel>> GetRandomQuestionsAsync(int categoryId, int count);
        Task<List<QuestionModel>> GetAllQuestionsAsync();
        Task AddQuestionsAsync(List<QuestionModel> questions);
        Task UpdateQuestionAsync(QuestionModel question);
        Task DeleteQuestionAsync(int id); // Xóa mềm

        // ===== Category Methods =====
        Task<List<CategoryModel>> GetAllCategoriesAsync();
        Task<CategoryModel?> GetCategoryByIdAsync(int id);

        // ===== Exam Methods =====
        Task<ExamModel?> GetExamWithQuestionsAsync(int examId);
        Task<List<ExamModel>> GetAllExamsAsync();
        Task<List<ExamModel>> GetExamsByUserAsync(int userId);
        Task<ExamModel?> GetExamByIdAsync(int examId);
        Task AddExamAsync(ExamModel exam);
        Task UpdateExamAsync(ExamModel exam);
        Task DeleteExamAsync(int id); // Xóa cứng (Vì ExamQuestions phụ thuộc vào Exam)

        // ===== ExamQuestion Methods =====
        Task<List<ExamQuestionModel>> GetExamQuestionsAsync(int examId);
        Task AddExamQuestionsAsync(List<ExamQuestionModel> examQuestions);
    }

    public class DatabaseRepository : IDatabaseRepository
    {
        private readonly ExamBankDbContext _dbContext;

        public DatabaseRepository(ExamBankDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        // ========== QUẢN LÝ CÂU HỎI (QUESTION) ==========

        public async Task<List<QuestionModel>> GetQuestionsByCategoryAsync(int categoryId)
        {
            return await _dbContext.Questions
                .Where(q => q.CategoryId == categoryId && q.IsActive)
                .Include(q => q.Category)
                .OrderByDescending(q => q.CreatedAt)
                .ToListAsync();
        }

        public async Task<QuestionModel?> GetQuestionByIdAsync(int id)
        {
            return await _dbContext.Questions
                .FirstOrDefaultAsync(q => q.Id == id && q.IsActive);
        }

        public async Task<QuestionModel?> GetQuestionByIdWithCategoryAsync(int id)
        {
            return await _dbContext.Questions
                .Include(q => q.Category)
                .FirstOrDefaultAsync(q => q.Id == id && q.IsActive);
        }

        public async Task<List<QuestionModel>> GetRandomQuestionsAsync(int categoryId, int count)
        {
            var query = _dbContext.Questions
                .Where(q => q.CategoryId == categoryId && q.IsActive);

            int totalAvailable = await query.CountAsync();

            if (totalAvailable < count)
                throw new InvalidOperationException($"Không đủ câu hỏi! Kho chỉ còn {totalAvailable} câu nhưng bạn yêu cầu {count} câu.");

            return await query
                .OrderBy(q => Guid.NewGuid()) // Bốc ngẫu nhiên
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<QuestionModel>> GetAllQuestionsAsync()
        {
            return await _dbContext.Questions
                .Where(q => q.IsActive)
                .Include(q => q.Category)
                .OrderByDescending(q => q.CreatedAt)
                .ToListAsync();
        }

        public async Task AddQuestionsAsync(List<QuestionModel> questions)
        {
            if (questions == null || !questions.Any()) return;
            await _dbContext.Questions.AddRangeAsync(questions);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateQuestionAsync(QuestionModel question)
        {
            _dbContext.Questions.Update(question);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteQuestionAsync(int id)
        {
            var question = await _dbContext.Questions.FindAsync(id);
            if (question != null)
            {
                // Thay vì Remove, ta dùng Xóa mềm (Soft Delete)
                question.IsActive = false;
                await _dbContext.SaveChangesAsync();
            }
        }

        // ========== QUẢN LÝ DANH MỤC (CATEGORY) ==========

        public async Task<List<CategoryModel>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories
                .Where(c => c.IsActive)
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<CategoryModel?> GetCategoryByIdAsync(int id)
        {
            return await _dbContext.Categories
                .FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
        }

        // ========== QUẢN LÝ ĐỀ THI (EXAM) ==========

        public async Task<ExamModel?> GetExamWithQuestionsAsync(int examId)
        {
            return await _dbContext.Exams
                .Include(e => e.Author)
                .Include(e => e.ExamQuestions)
                    .ThenInclude(eq => eq.Question)
                .FirstOrDefaultAsync(e => e.Id == examId);
        }

        public async Task<ExamModel?> GetExamByIdAsync(int examId)
        {
            return await _dbContext.Exams.FindAsync(examId);
        }

        public async Task<List<ExamModel>> GetAllExamsAsync()
        {
            return await _dbContext.Exams
                .Include(e => e.Author)
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<ExamModel>> GetExamsByUserAsync(int userId)
        {
            return await _dbContext.Exams
                .Where(e => e.CreatedByUserId == userId)
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync();
        }

        public async Task AddExamAsync(ExamModel exam)
        {
            await _dbContext.Exams.AddAsync(exam);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateExamAsync(ExamModel exam)
        {
            _dbContext.Entry(exam).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteExamAsync(int id)
        {
            var exam = await _dbContext.Exams.FindAsync(id);
            if (exam != null)
            {
                _dbContext.Exams.Remove(exam); // Xóa cứng vì ExamQuestions dùng Cascade Delete
                await _dbContext.SaveChangesAsync();
            }
        }

        // ========== BẢNG TRUNG GIAN (EXAMQUESTION) ==========

        public async Task<List<ExamQuestionModel>> GetExamQuestionsAsync(int examId)
        {
            return await _dbContext.ExamQuestions
                .Where(eq => eq.ExamId == examId)
                .Include(eq => eq.Question)
                .OrderBy(eq => eq.QuestionOrder)
                .ToListAsync();
        }

        public async Task AddExamQuestionsAsync(List<ExamQuestionModel> examQuestions)
        {
            await _dbContext.ExamQuestions.AddRangeAsync(examQuestions);
            await _dbContext.SaveChangesAsync();
        }
    }
}