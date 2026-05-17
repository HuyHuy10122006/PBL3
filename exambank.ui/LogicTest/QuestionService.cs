using exambank.data;
using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exambank.ui.LogicTest
{
    public class QuestionService
    {
        // Khởi tạo Repository bằng cách truyền DbContext vào
        private readonly IDatabaseRepository _repository = new DatabaseRepository(new ExamBankDbContext());

        public async Task<bool> AddQuestionAsync(QuestionModel q)
        {
            // Tối ưu logic: Kiểm tra null và validate dữ liệu cơ bản gọn hơn
            if (q == null || string.IsNullOrWhiteSpace(q.Question) || string.IsNullOrWhiteSpace(q.Answer))
            {
                return false;
            }

            try
            {
                // Sử dụng AddQuestionsAsync có sẵn của Repository
                await _repository.AddQuestionsAsync(new List<QuestionModel> { q });
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi khi lưu: " + ex.Message);
                return false;
            }
        }

        public async Task<List<QuestionModel>> GetQuestionsAsync(int userId)
        {
            // Tối ưu: Lấy toàn bộ câu hỏi Active thông qua Repo, sau đó lọc theo UserId ở bộ nhớ
            var allQuestions = await _repository.GetAllQuestionsAsync();

            return allQuestions
                .Where(q => q.CreatedByUserId == userId)
                .ToList(); // GetAllQuestionsAsync đã có sẵn OrderByDescending(CreatedAt) trong Repo
        }

        public async Task<bool> DeleteMultipleAsync(List<int> ids)
        {
            if (ids == null || ids.Count == 0) return false;

            try
            {
                foreach (var id in ids)
                {
                    // Tận dụng hàm DeleteQuestionAsync (Xóa mềm bằng cách set IsActive = false) đã viết ở Repo
                    await _repository.DeleteQuestionAsync(id);
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
                // 1. Lấy câu hỏi gốc từ DB thông qua Repo (đã check IsActive)
                var existingQuestion = await _repository.GetQuestionByIdAsync(updatedData.Id);

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
                    await _repository.UpdateQuestionAsync(existingQuestion);
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