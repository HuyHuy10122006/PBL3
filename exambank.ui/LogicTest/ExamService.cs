using exambank.data;
using exambank.data.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace exambank.ui.LogicTest
{
    public class ExamService
    {
        public bool DeleteExams(List<int> examIds)
        {
            using (var db = new ExamBankDbContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Xóa liên kết câu hỏi trong đề trước[cite: 14]
                        var links = db.ExamQuestions.Where(eq => examIds.Contains(eq.ExamId));
                        db.ExamQuestions.RemoveRange(links);

                        // 2. Xóa đề thi[cite: 13]
                        var exams = db.Exams.Where(e => examIds.Contains(e.Id));
                        db.Exams.RemoveRange(exams);

                        db.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool UpdateQuestions(List<QuestionModel> updatedQuestions)
        {
            if (updatedQuestions == null || !updatedQuestions.Any())
            {
                return false; 
            }

            using (var db = new ExamBankDbContext())
            {
                // Sử dụng Transaction để đảm bảo tính toàn vẹn dữ liệu
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var q in updatedQuestions)
                        {
                            // Tìm câu hỏi gốc trong database
                            var existingQuestion = db.Questions.Find(q.Id);

                            if (existingQuestion != null)
                            {
                                // Cập nhật các thuộc tính dựa trên QuestionModel_2.cs[cite: 1]
                                existingQuestion.Question = q.Question;
                                existingQuestion.OptionA = q.OptionA;
                                existingQuestion.OptionB = q.OptionB;
                                existingQuestion.OptionC = q.OptionC;
                                existingQuestion.OptionD = q.OptionD;
                                existingQuestion.Answer = q.Answer;
                                existingQuestion.Explanation = q.Explanation;
                                existingQuestion.Subject = q.Subject;
                                existingQuestion.Grade = q.Grade;
                                existingQuestion.Difficulty = q.Difficulty;

                                // Đánh dấu thực thể đã thay đổi
                                db.Entry(existingQuestion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        UIMessageBox.ShowError($"Cập nhật câu hỏi thất bại: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool CreateExam(ExamModel exam, List<int> selectedQuestionIds)
        {
            using (var db = new ExamBankDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Lưu thông tin đề thi trước
                        exam.CreatedAt = DateTime.Now;
                        db.Exams.Add(exam);
                        db.SaveChanges(); // Lưu để lấy ID của đề thi vừa tạo

                        // 2. Lưu danh sách câu hỏi vào bảng trung gian
                        for (int i = 0; i < selectedQuestionIds.Count; i++)
                        {
                            var examQuestion = new ExamQuestionModel
                            {
                                ExamId = exam.Id,
                                QuestionId = selectedQuestionIds[i],
                                QuestionOrder = i + 1, // Thứ tự câu hỏi trong đề[cite: 14]
                                CreatedAt = DateTime.Now
                            };
                            db.ExamQuestions.Add(examQuestion);
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Log lỗi tại đây (ex.Message)
                        return false;
                    }
                }
            }
        }

        // Lấy danh sách đề thi dựa trên Title, Subject và Grade
        public List<ExamModel> GetExams(string keyword, string subject, string grade)
        {
            using (var db = new ExamBankDbContext())
            {
                // Model mới không có IsActive, sử dụng CreatedAt để sắp xếp
                var query = db.Exams.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                    query = query.Where(e => e.Title.Contains(keyword) || e.ExamCode.Contains(keyword));

                if (!string.IsNullOrEmpty(subject) && subject != "Chọn môn")
                    query = query.Where(e => e.Subject == subject);

                // Lưu ý: Grade hiện nằm ở QuestionModel, nếu muốn lọc Exam theo Grade 
                // cần thông qua bảng trung gian ExamQuestions[cite: 9, 14]

                return query.OrderByDescending(e => e.CreatedAt).ToList();
            }
        }

        // Lấy danh sách câu hỏi của một đề thi thông qua bảng trung gian ExamQuestionModel
        public List<QuestionModel> GetQuestionsByExamId(int examId)
        {
            using (var db = new ExamBankDbContext())
            {
                return db.ExamQuestions
                         .Where(eq => eq.ExamId == examId)
                         .OrderBy(eq => eq.QuestionOrder) // Sắp xếp theo thứ tự câu hỏi[cite: 14]
                         .Select(eq => eq.Question)
                         .ToList();
            }
        }
    }
}
