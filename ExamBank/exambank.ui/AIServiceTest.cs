using exambank.data.Models;
using Mscc.GenerativeAI;
using Mscc.GenerativeAI.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

public class AIServiceTest
{
    private readonly string _apiKey = "AIzaSyBVLaUvcVt_Ac7CD3MHbtbPzlS4LMI_Ykg";

    /// <summary>
    /// Sinh câu hỏi từ File hoặc Văn bản trực tiếp
    /// </summary>
    /// <param name="input">Đường dẫn file hoặc nội dung văn bản</param>
    /// <param name="isFilePath">True nếu input là đường dẫn file, False nếu là văn bản thô</param>
    public async Task<List<QuestionModel>> GenerateQuestionsAsync(string input, string subject, string difficulty, int count, bool isFilePath)
    {
        var googleAI = new GoogleAI(_apiKey);
        var model = googleAI.GenerativeModel(Model.Gemini25Flash);

        string prompt = $@"
        Bạn là một chuyên gia giáo dục. Dựa trên nội dung tài liệu được cung cấp, hãy tạo đúng {count} câu hỏi trắc nghiệm môn {subject} ở mức độ {difficulty}.
        
        YÊU CẦU ĐỊNH DẠNG TRẢ VỀ:
        Trả về DUY NHẤT một mã JSON array (không bao gồm markdown ```json). Mỗi phần tử phải có cấu trúc:
        {{
            ""Question"": ""Nội dung câu hỏi"",
            ""OptionA"": ""Đáp án A"",
            ""OptionB"": ""Đáp án B"",
            ""OptionC"": ""Đáp án C"",
            ""OptionD"": ""Đáp án D"",
            ""Answer"": ""Chữ cái A/B/C/D"",
            ""Explanation"": ""Giải thích lý do chọn""
        }}";

        GenerateContentResponse response;

        if (isFilePath)
        {
            // TRƯỜNG HỢP 1: ĐỌC TỪ FILE
            string ext = Path.GetExtension(input).ToLower();

            if (ext == ".pdf")
            {
                // Gửi file PDF trực tiếp (Gemini tự OCR)
                byte[] fileBytes = File.ReadAllBytes(input);
                string base64File = Convert.ToBase64String(fileBytes);

                var request = new GenerateContentRequest(prompt);
                request.Contents[0].Parts.Add(new InlineData { MimeType = "application/pdf", Data = base64File });
                response = await model.GenerateContent(request);
            }
            else
            {
                // Đối với .txt hoặc các file văn bản khác
                string fileContent = File.ReadAllText(input);
                response = await model.GenerateContent($"{prompt}\n\nNỘI DUNG TÀI LIỆU:\n{fileContent}");
            }
        }
        else
        {
            // TRƯỜNG HỢP 2: VĂN BẢN TRỰC TIẾP TỪ TEXTBOX
            response = await model.GenerateContent($"{prompt}\n\nNỘI DUNG VĂN BẢN:\n{input}");
        }

        return ParseResponse(response.Text, subject, difficulty);
    }

    private List<QuestionModel> ParseResponse(string rawJson, string subject, string difficulty)
    {
        try
        {
            // Làm sạch chuỗi phản hồi từ AI (loại bỏ các thẻ markdown nếu có)
            string cleanJson = rawJson.Replace("```json", "").Replace("```", "").Trim();

            var questions = JsonConvert.DeserializeObject<List<QuestionModel>>(cleanJson);

            // Gán thông tin bổ sung cho các đối tượng QuestionModel
            foreach (var q in questions)
            {
                q.Subject = subject;
                q.Difficulty = difficulty;
                q.CreatedAt = DateTime.Now;
                q.IsActive = true;
            }

            return questions;
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi phân tích dữ liệu AI: " + ex.Message + "\nNội dung thô: " + rawJson);
        }
    }
}