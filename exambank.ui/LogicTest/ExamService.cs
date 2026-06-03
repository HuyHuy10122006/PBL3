using exambank.data;
using exambank.data.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace exambank.ui.LogicTest
{
    public class ExamService
    {
        // Tạo Repository mới mỗi lần gọi để tránh dữ liệu cache cũ
        private IDatabaseRepository CreateRepository() => new DatabaseRepository(new ExamBankDbContext());
        private readonly LogService _logService = new LogService();

        /// <summary>
        /// Lấy giá trị Distinct để hiển thị lên ComboBox
        /// </summary>
        public List<string> GetCboValues(List<ExamModel> exams, Func<ExamModel, string> selector)
        {
            if (exams == null) return new List<string>();

            return exams
                .Select(selector)
                .Where(val => !string.IsNullOrEmpty(val))
                .Distinct()
                .OrderBy(val => val)
                .ToList();
        }

        /// <summary>
        /// Tạo đề thi ngẫu nhiên dựa trên ma trận môn học, khối, độ khó
        /// </summary>
        public async Task<bool> CreateExamByMatrixAsync(ExamModel examInfo)
        {
            if (examInfo == null) return false;

            try
            {
                var allQuestions = await CreateRepository().GetAllQuestionsAsync();
                var query = allQuestions.Where(q => q.CreatedByUserId == examInfo.CreatedByUserId && q.IsActive && q.Subject == examInfo.Subject);
                var pool = query.ToList();

                if (pool.Count < examInfo.TotalQuestions)
                {
                    throw new Exception($"Ngân hàng chỉ có {pool.Count} câu phù hợp, không đủ tạo đề {examInfo.TotalQuestions} câu.");
                }

                var selectedQs = pool.OrderBy(x => Guid.NewGuid())
                                     .Take(examInfo.TotalQuestions)
                                     .ToList();

                examInfo.ExamQuestions.Clear();
                for (int i = 0; i < selectedQs.Count; i++)
                {
                    examInfo.ExamQuestions.Add(new ExamQuestionModel
                    {
                        QuestionId = selectedQs[i].Id,
                        QuestionOrder = i + 1,
                        CreatedAt = DateTime.Now
                    });
                }

                await CreateRepository().AddExamAsync(examInfo);

                _logService.Add($"User:{examInfo.CreatedByUserId}", $"Tạo đề bằng ma trận (ExamId pending)", "Thành công");
                return true;
            }
            catch (Exception ex)
            {
                _logService.Add($"User:{examInfo?.CreatedByUserId}", "Tạo đề bằng ma trận", $"Thất bại - {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Xóa hàng loạt đề thi
        /// </summary>
        public async Task<bool> DeleteExamsAsync(List<int> examIds)
        {
            if (examIds == null || examIds.Count == 0) return false;

            try
            {
                // Tận dụng hàm DeleteExamAsync(id) trong Repo. 
                // Theo ghi chú ở Repo: Hàm này xóa cứng Exam và DB đã cấu hình Cascade Delete nên tự xóa sạch ExamQuestions liên quan.
                foreach (var id in examIds)
                {
                    await CreateRepository().DeleteExamAsync(id);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi khi xóa danh sách đề thi: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Tạo đề thi mới từ danh sách ID câu hỏi đã có sẵn
        /// </summary>
        public async Task<bool> CreateExamAsync(ExamModel exam, List<int> questionIds)
        {
            if (exam == null || questionIds == null || questionIds.Count == 0) return false;

            try
            {
                exam.ExamQuestions.Clear();
                for (int i = 0; i < questionIds.Count; i++)
                {
                    exam.ExamQuestions.Add(new ExamQuestionModel
                    {
                        QuestionId = questionIds[i],
                        QuestionOrder = i + 1,
                        CreatedAt = DateTime.Now
                    });
                }

                await CreateRepository().AddExamAsync(exam);

                _logService.Add($"User:{exam.CreatedByUserId}", $"Tạo đề (IDs)", "Thành công");
                return true;
            }
            catch (Exception ex)
            {
                _logService.Add($"User:{exam?.CreatedByUserId}", "Tạo đề (IDs)", $"Thất bại - {ex.Message}");
                Debug.WriteLine("Lỗi khi tạo đề thi: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Tạo đề thi mới bao gồm cả câu hỏi chưa có ID (câu hỏi sinh từ AI)
        /// </summary>
        public async Task<bool> CreateExamAsync(ExamModel exam, List<QuestionModel> questions)
        {
            if (exam == null || questions == null || questions.Count == 0) return false;

            try
            {
                // 1. Phân tách câu hỏi: Lọc ra danh sách câu hỏi mới từ AI (Id == 0) để thêm vào DB trước
                var newQuestions = questions.Where(q => q.Id == 0).ToList();
                if (newQuestions.Count > 0)
                {
                    // Tận dụng hàm thêm hàng loạt của Repo
                    await CreateRepository().AddQuestionsAsync(newQuestions);
                    // Sau lệnh này, Entity Framework sẽ tự động nạp lại Id thực tế từ DB vào thuộc tính `.Id` của từng phần tử trong `newQuestions` và `questions`
                }

                // 2. Tạo mối liên kết bảng trung gian dựa trên danh sách câu hỏi (bấy giờ toàn bộ đã có Id hợp lệ)
                exam.ExamQuestions.Clear();
                for (int i = 0; i < questions.Count; i++)
                {
                    exam.ExamQuestions.Add(new ExamQuestionModel
                    {
                        QuestionId = questions[i].Id,
                        QuestionOrder = i + 1,
                        CreatedAt = DateTime.Now
                    });
                }

                // 3. Lưu đề thi cùng tập hợp bảng trung gian thông qua Repo
                await CreateRepository().AddExamAsync(exam);

                _logService.Add($"User:{exam.CreatedByUserId}", $"Tạo đề (kèm AI)", "Thành công");
                return true;
            }
            catch (Exception ex)
            {
                _logService.Add($"User:{exam?.CreatedByUserId}", "Tạo đề (kèm AI)", $"Thất bại - {ex.Message}");
                Debug.WriteLine("Lỗi khi tạo đề kèm câu hỏi AI: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Lấy danh sách đề thi của Giáo viên
        /// </summary>
        public async Task<List<ExamModel>> GetExamsAsync(int userId)
        {
            // Tận dụng hàm đã viết sẵn trong Repo chuyên biệt cho việc lọc theo UserId
            return await CreateRepository().GetExamsByUserAsync(userId);
        }

        /// <summary>
        /// Lấy danh sách câu hỏi của một đề thi
        /// </summary>
        public async Task<List<QuestionModel>> GetQuestionsByExamIdAsync(int examId)
        {
            // Tận dụng hàm GetExamWithQuestionsAsync từ Repo để lấy thông tin Đề thi kèm danh sách câu hỏi đi qua bảng trung gian
            var examWithQuestions = await CreateRepository().GetExamWithQuestionsAsync(examId);

            if (examWithQuestions == null) return new List<QuestionModel>();

            return examWithQuestions.ExamQuestions
                .OrderBy(eq => eq.QuestionOrder)
                .Select(eq => eq.Question)
                .Where(q => q != null) // Loại bỏ phần tử null an toàn
                .ToList();
        }

        /// <summary>
        /// Tải danh sách cấu trúc trung gian ExamQuestionModel
        /// </summary>
        public async Task<List<ExamQuestionModel>> LoadExamQuestionsAsync(int examId)
        {
            // Tận dụng hàm Repo có sẵn trả về chính xác cấu trúc này kèm lệnh `.Include(eq => eq.Question)`
            return await CreateRepository().GetExamQuestionsAsync(examId);
        }

        /// <summary>
        /// Cập nhật thông tin đề thi và đồng bộ danh sách câu hỏi
        /// </summary>
        public async Task<bool> UpdateExamAsync(ExamModel exam)
        {
            if (exam == null) return false;

            try
            {
                // Tận dụng hàm cập nhật đề thi của Repo
                await CreateRepository().UpdateExamAsync(exam);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Database: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

        //Hàm lấy danh sách 10 đề thi gần đây nhất của giáo viên để hiển thị lên Trang chủ
        public async Task<List<ExamModel>> GetRecentExamsAsync(int userId)
        {
            // Tận dụng hàm Repo đã viết sẵn để lấy danh sách đề thi của giáo viên, sau đó sắp xếp và lấy 10 đề gần nhất
            var exams = await CreateRepository().GetExamsByUserAsync(userId);
            return exams.OrderByDescending(e => e.CreatedAt).Take(10).ToList();
        }

        //Hàm lấy đề thi Public
        public async Task<List<ExamModel>> GetPublicExamsAsync()
        {
            return await CreateRepository().GetSharedExamsAsync();
        }

        //Hàm cập nhật trạng thái Chia sẻ (đặt thành Pending chờ Admin duyệt)
        public async Task<bool> ToggleShareExamAsync(int examId)
        {
            var repo = CreateRepository();
            var exam = await repo.GetExamByIdAsync(examId);
            if (exam == null) return false;

            if (!exam.IsShared)
            {
                // Chia sẻ: đặt thành Pending chờ Admin duyệt
                exam.IsShared = true;
                exam.ApprovalStatus = ApprovalStatus.Pending;
                exam.AdminNote = null;
            }
            else
            {
                // Hủy chia sẻ: trả về trạng thái ban đầu
                exam.IsShared = false;
                exam.ApprovalStatus = ApprovalStatus.None;
                exam.AdminNote = null;
            }

            await repo.UpdateExamAsync(exam);
            return exam.IsShared;
        }

        //Hàm lấy toàn bộ đề thi (Test)
        public async Task<List<ExamModel>> GetAllExamsAsync()
        {
            return await CreateRepository().GetAllExamsAsync();
        }

        // ========== ADMIN APPROVAL METHODS ==========

        /// <summary>
        /// Lấy danh sách đề thi đang chờ duyệt
        /// </summary>
        public async Task<List<ExamModel>> GetPendingExamsAsync()
        {
            return await CreateRepository().GetPendingExamsAsync();
        }

        /// <summary>
        /// Lấy tất cả đề thi đã chia sẻ (mọi trạng thái) cho Admin quản lý
        /// </summary>
        public async Task<List<ExamModel>> GetSharedExamsAllStatusAsync()
        {
            return await CreateRepository().GetSharedExamsAllStatusAsync();
        }

        /// <summary>
        /// Admin duyệt đề thi
        /// </summary>
        public async Task<bool> ApproveExamAsync(int examId)
        {
            var repo = CreateRepository();
            var exam = await repo.GetExamByIdAsync(examId);
            if (exam == null) return false;

            exam.ApprovalStatus = ApprovalStatus.Approved;
            exam.AdminNote = null;
            await repo.UpdateExamAsync(exam);

            _logService.Add("Admin", $"Duyệt đề thi ID={examId}", "Thành công");
            return true;
        }

        /// <summary>
        /// Admin từ chối đề thi
        /// </summary>
        public async Task<bool> RejectExamAsync(int examId, string? reason = null)
        {
            var repo = CreateRepository();
            var exam = await repo.GetExamByIdAsync(examId);
            if (exam == null) return false;

            exam.ApprovalStatus = ApprovalStatus.Rejected;
            exam.AdminNote = reason;
            await repo.UpdateExamAsync(exam);

            _logService.Add("Admin", $"Từ chối đề thi ID={examId}", $"Lý do: {reason ?? "Không rõ"}");
            return true;
        }

        /// <summary>
        /// Helper: Chuyển ApprovalStatus sang text tiếng Việt
        /// </summary>
        public static string GetApprovalStatusText(ApprovalStatus status)
        {
            return status switch
            {
                ApprovalStatus.None => "Chưa chia sẻ",
                ApprovalStatus.Pending => "Chờ duyệt",
                ApprovalStatus.Approved => "Đã duyệt",
                ApprovalStatus.Rejected => "Từ chối",
                _ => "Không rõ"
            };
        }
    }
}