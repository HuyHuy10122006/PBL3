using exambank.data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AIServiceTest
{
    /// <summary>
    /// Thay vì gọi AI, hàm này trả về danh sách câu hỏi mẫu cố định.
    /// </summary>
    /// <param name="input">Không sử dụng trong bản mock</param>
    /// <param name="isFilePath">Không sử dụng trong bản mock</param>
    public async Task<List<QuestionModel>> GenerateQuestionsAsync(string input, string subject, string difficulty, int count, bool isFilePath)
    {
        // Khởi tạo danh sách 5 câu hỏi mẫu
        var mockQuestions = new List<QuestionModel>
        {
            new QuestionModel {
                Question = "Thành phần nào sau đây là 'bộ não' của máy tính?",
                OptionA = "RAM",
                OptionB = "CPU",
                OptionC = "Ổ cứng",
                OptionD = "Card đồ họa",
                Answer = "B",
                Explanation = "CPU (Central Processing Unit) là đơn vị xử lý trung tâm, đảm nhận mọi tính toán cốt lõi."
            },
            new QuestionModel {
                Question = "Giao thức nào được sử dụng để truyền tải trang web?",
                OptionA = "FTP",
                OptionB = "SMTP",
                OptionC = "HTTP",
                OptionD = "SSH",
                Answer = "C",
                Explanation = "HTTP (Hypertext Transfer Protocol) là giao thức chuẩn để truyền tải dữ liệu giữa trình duyệt và server."
            },
            new QuestionModel {
                Question = "Trong lập trình C#, từ khóa nào dùng để khai báo một hằng số?",
                OptionA = "static",
                OptionB = "readonly",
                OptionC = "var",
                OptionD = "const",
                Answer = "D",
                Explanation = "Từ khóa 'const' dùng để khai báo các giá trị không đổi trong suốt quá trình thực thi chương trình."
            },
            new QuestionModel {
                Question = "Hệ điều hành nào sau đây là mã nguồn mở?",
                OptionA = "Windows",
                OptionB = "macOS",
                OptionC = "Linux",
                OptionD = "iOS",
                Answer = "C",
                Explanation = "Linux là hệ điều hành mã nguồn mở nổi tiếng nhất, cho phép người dùng tự do chỉnh sửa."
            },
            new QuestionModel {
                Question = "Đơn vị đo dung lượng lưu trữ nhỏ nhất trong các lựa chọn sau là gì?",
                OptionA = "Megabyte (MB)",
                OptionB = "Gigabyte (GB)",
                OptionC = "Terabyte (TB)",
                OptionD = "Kilobyte (KB)",
                Answer = "D",
                Explanation = "Theo thứ tự tăng dần: KB < MB < GB < TB."
            }
        };

        // Gán các thông tin metadata (môn học, độ khó, thời gian)
        foreach (var q in mockQuestions)
        {
            q.Subject = subject;
            q.Difficulty = difficulty;
            q.CreatedAt = DateTime.Now;
            q.IsActive = true;
        }

        return mockQuestions;
    }
}