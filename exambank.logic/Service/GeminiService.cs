using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using exambank.data;
using exambank.data.Models;

namespace exambank.logic.Service
{
    public class GeminiService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey;
        private readonly string _model;
        private readonly string _geminiUrl;
        private readonly string _systemPrompt;
        private readonly double _temperature;

        /// <summary>
        /// Constructor mặc định: Tự động đọc cấu hình từ Database → File → Env
        /// </summary>
        public GeminiService()
        {
            // Ưu tiên đọc từ Database
            var config = LoadConfigFromDatabase();
            if (config != null && !string.IsNullOrWhiteSpace(config.ApiKey))
            {
                _apiKey = config.ApiKey;
                _model = config.Model ?? "gemini-flash-lite-latest";
                _systemPrompt = config.SystemPrompt ?? "Bạn là chuyên gia giáo dục. Hãy tạo câu hỏi trắc nghiệm chất lượng cao dựa trên nội dung được cung cấp. Trả về kết quả dưới dạng JSON array.";
                _temperature = config.Temperature;
            }
            else
            {
                _apiKey = GetApiKeyFromFile();
                _model = "gemini-flash-lite-latest";
                _systemPrompt = "Bạn là chuyên gia giáo dục. Hãy tạo câu hỏi trắc nghiệm chất lượng cao dựa trên nội dung được cung cấp. Trả về kết quả dưới dạng JSON array.";
                _temperature = 0.7;
            }
            _geminiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent?key={_apiKey}";
        }

        /// <summary>
        /// Constructor dùng cho Admin test kết nối với API key và model tùy chỉnh
        /// </summary>
        public GeminiService(string apiKey, string model, string systemPrompt = null, double temperature = 0.7)
        {
            _apiKey = apiKey;
            _model = string.IsNullOrWhiteSpace(model) ? "gemini-flash-lite-latest" : model;
            _systemPrompt = systemPrompt ?? "Bạn là chuyên gia giáo dục. Hãy tạo câu hỏi trắc nghiệm chất lượng cao.";
            _temperature = temperature;
            _geminiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent?key={_apiKey}";
        }

        /// <summary>
        /// Đọc cấu hình AI từ Database (bảng AI_Configs)
        /// </summary>
        private AIConfigModel LoadConfigFromDatabase()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    return db.AIConfigs.FirstOrDefault(c => c.IsActive);
                }
            }
            catch
            {
                return null; // Nếu DB lỗi thì fallback
            }
        }

        private string GetApiKeyFromFile()
        {
            // Cách 1: Đọc API Key từ file api_key.txt
            string path = AppDomain.CurrentDomain.BaseDirectory;
            while (path != null)
            {
                string filePath = System.IO.Path.Combine(path, "api_key.txt");
                if (System.IO.File.Exists(filePath))
                {
                    return System.IO.File.ReadAllText(filePath).Trim();
                }
                path = System.IO.Directory.GetParent(path)?.FullName;
            }

            // Cách 2: Lấy từ biến môi trường
            var envKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            if (!string.IsNullOrEmpty(envKey)) 
            {
                return envKey.Trim();
            }

            throw new Exception("Không tìm thấy API Key!\n\nVui lòng cấu hình API Key trong phần 'Cấu hình tham số AI' (Admin) hoặc tạo file 'api_key.txt' ở thư mục gốc dự án.\n(Hoặc thiết lập biến môi trường GEMINI_API_KEY)");
        }

        /// <summary>
        /// Kiểm tra kết nối tới API Gemini (Admin dùng để test)
        /// </summary>
        public async Task<string> TestConnectionAsync()
        {
            try
            {
                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new { text = "Trả lời ngắn gọn: 1 + 1 = ?" }
                            }
                        }
                    }
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(_geminiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return $"❌ Lỗi {(int)response.StatusCode}: {responseString}";
                }

                return "✅ Kết nối thành công! API Key hợp lệ.";
            }
            catch (Exception ex)
            {
                return $"❌ Lỗi kết nối: {ex.Message}";
            }
        }

        /// <summary>
        /// Chạy thử Prompt với nội dung mẫu (Admin dùng để preview output)
        /// </summary>
        public async Task<string> TestPromptAsync(string systemPrompt, double temperature = 0.7, string inputContent = "", int numberOfQuestions = 2)
        {
            try
            {
                string testContent = string.IsNullOrWhiteSpace(inputContent) ? "Thủ đô của Việt Nam là Hà Nội. Việt Nam có 63 tỉnh thành." : inputContent;
                string prompt = $"{systemPrompt}\n\nNội dung: {testContent}\n\nHãy tạo {numberOfQuestions} câu hỏi trắc nghiệm mẫu.";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new { text = prompt }
                            }
                        }
                    },
                    generationConfig = new
                    {
                        temperature = temperature
                    }
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(_geminiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return $"❌ Lỗi {(int)response.StatusCode}: {responseString}";
                }

                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {
                    JsonElement root = doc.RootElement;
                    if (root.TryGetProperty("candidates", out JsonElement candidates) && candidates.GetArrayLength() > 0)
                    {
                        JsonElement firstCandidate = candidates[0];
                        if (firstCandidate.TryGetProperty("content", out JsonElement contentElement) &&
                            contentElement.TryGetProperty("parts", out JsonElement parts) && parts.GetArrayLength() > 0)
                        {
                            return parts[0].GetProperty("text").GetString() ?? "Không có kết quả.";
                        }
                    }
                }

                return "Không parse được kết quả từ AI.";
            }
            catch (Exception ex)
            {
                return $"❌ Lỗi: {ex.Message}";
            }
        }
        public async IAsyncEnumerable<string> GenerateQuestionsStreamAsync(string textChunk, int countMC = 10, int countTF = 0, int countSA = 0, string subject = "", string grade = "")
        {
            int batchSize = 10;
            var requests = new List<(int mc, int tf, int sa)>();

            int remainMC = countMC;
            int remainTF = countTF;
            int remainSA = countSA;

            while (remainMC > 0 || remainTF > 0 || remainSA > 0)
            {
                int takeMC = Math.Min(remainMC, batchSize);
                int takeTF = Math.Min(remainTF, batchSize - takeMC);
                int takeSA = Math.Min(remainSA, batchSize - takeMC - takeTF);

                requests.Add((takeMC, takeTF, takeSA));

                remainMC -= takeMC;
                remainTF -= takeTF;
                remainSA -= takeSA;
            }

            for (int i = 0; i < requests.Count; i++)
            {
                var req = requests[i];
                string res = await GenerateBatchAsync(textChunk, req.mc, req.tf, req.sa, i, subject, grade);

                if (!string.IsNullOrWhiteSpace(res))
                {
                    yield return res;
                }

                if (i < requests.Count - 1)
                {
                    await Task.Delay(5000); 
                }
            }
        }

        public async Task<string> AnalyzeDocumentAsync(string textChunk)
        {
            string prompt = @"Bạn là chuyên gia giáo dục. Hãy phân tích đoạn tài liệu sau và cho biết nó có phải là tài liệu thuộc chương trình phổ thông (như Sách Giáo Khoa, đề thi chuẩn, bài giảng) hay không.
Hãy trả về một JSON object duy nhất, không có markdown (không dùng ```json), gồm các trường sau:
{
    ""IsSGK"": true hoặc false (true nếu là tài liệu học đường/SGK, false nếu là tài liệu không liên quan),
    ""Grade"": ""Tên khối lớp"",
    ""Subject"": ""Tên môn học""
}
Lưu ý:
- Grade CHỈ được chọn một trong các giá trị sau (hoặc để rỗng nếu không xác định được): Lớp 1, Lớp 2, Lớp 3, Lớp 4, Lớp 5, Lớp 6, Lớp 7, Lớp 8, Lớp 9, Lớp 10, Lớp 11, Lớp 12.
- Subject CHỈ được chọn một trong các giá trị sau (hoặc để rỗng nếu không xác định được): Toán học, Vật lý, Hóa học, Sinh học, Ngữ văn, Lịch sử, Địa lý, Tiếng Anh, Tin học, GDCD.

Nội dung tài liệu:
" + (textChunk.Length > 3000 ? textChunk.Substring(0, 3000) : textChunk);

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                },
                generationConfig = new
                {
                    responseMimeType = "application/json",
                    temperature = 0.1
                }
            };

            string jsonBody = JsonSerializer.Serialize(requestBody);

            try
            {
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(_geminiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseString))
                    {
                        JsonElement root = doc.RootElement;
                        if (root.TryGetProperty("candidates", out JsonElement candidates) && candidates.GetArrayLength() > 0)
                        {
                            var parts = candidates[0].GetProperty("content").GetProperty("parts");
                            if (parts.GetArrayLength() > 0)
                            {
                                string text = parts[0].GetProperty("text").GetString();
                                if (text.StartsWith("```json")) text = text.Substring(7);
                                else if (text.StartsWith("```")) text = text.Substring(3);
                                if (text.EndsWith("```")) text = text.Substring(0, text.Length - 3);
                                return text.Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnalyzeDocumentAsync Error: " + ex.Message);
            }

            return null;
        }

        public async Task<string> GenerateQuestionsAsync(string textChunk, int countMC = 10, int countTF = 0, int countSA = 0, string subject = "", string grade = "")
        {
            int batchSize = 10; // Giảm batch size
            var requests = new List<(int mc, int tf, int sa)>();

            int remainMC = countMC;
            int remainTF = countTF;
            int remainSA = countSA;

            while (remainMC > 0 || remainTF > 0 || remainSA > 0)
            {
                int takeMC = Math.Min(remainMC, batchSize);
                int takeTF = Math.Min(remainTF, batchSize - takeMC);
                int takeSA = Math.Min(remainSA, batchSize - takeMC - takeTF);

                requests.Add((takeMC, takeTF, takeSA));

                remainMC -= takeMC;
                remainTF -= takeTF;
                remainSA -= takeSA;
            }

            if (requests.Count == 0) return "[]";

            var results = new List<string>();

            for (int i = 0; i < requests.Count; i++)
            {
                var req = requests[i];
                string res = await GenerateBatchAsync(textChunk, req.mc, req.tf, req.sa, i, subject, grade);
                results.Add(res);

                // Tránh lỗi quá tải của API (Rate Limit) khoản 15 RPM
                if (i < requests.Count - 1)
                {
                    await Task.Delay(5000); // Đợi 5 giây giữa các request
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            bool isFirst = true;

            foreach (var res in results)
            {
                if (string.IsNullOrWhiteSpace(res) || res.StartsWith("Error")) continue;

                string clean = res.Trim();
                if (clean.StartsWith("[")) clean = clean.Substring(1);
                if (clean.EndsWith("]")) clean = clean.Substring(0, clean.Length - 1);
                clean = clean.Trim();

                if (string.IsNullOrEmpty(clean)) continue;

                if (!isFirst) sb.Append(",");
                sb.Append(clean);
                isFirst = false;
            }

            sb.Append("]");
            return sb.ToString();
        }

        private async Task<string> GenerateBatchAsync(string textChunk, int countMC, int countTF, int countSA, int batchIndex, string subject = "", string grade = "")
        {
            string contextInfo = string.IsNullOrWhiteSpace(subject) ? "" : $"thuộc môn {subject} {(string.IsNullOrWhiteSpace(grade) ? "" : grade)}";
            string prompt = $"Bạn là chuyên gia giáo dục. Dựa vào nội dung tài liệu {contextInfo} sau đây (Phần {batchIndex + 1}), hãy tạo các câu hỏi dưới dạng một mảng JSON (mỗi object gồm đúng các key: Question, OptionA, OptionB, OptionC, OptionD, Answer).\n";
            prompt += $"Tổng cộng {countMC + countTF + countSA} câu hỏi, bao gồm:\n";
            if (countMC > 0)
            {
                prompt += $"- {countMC} câu trắc nghiệm 4 đáp án (A, B, C, D).\n";
            }
            if (countTF > 0)
            {
                prompt += $"- {countTF} câu trắc nghiệm Đúng/Sai. Thiết lập OptionA là 'Đúng', OptionB là 'Sai', OptionC và OptionD để là chuỗi rỗng '', và Answer là 'A' hoặc 'B'.\n";
            }
            if (countSA > 0)
            {
                prompt += $"- {countSA} câu trả lời ngắn. Hãy ghi đáp án chính xác và ngắn gọn nhất vào OptionA, để OptionB, OptionC, OptionD là chuỗi rỗng '', và Answer bắt buộc là 'A'.\n";
            }
            prompt += $"Chỉ trả về duy nhất 1 mảng JSON chuẩn xác, không có markdown (không dùng ```json), không có chữ thừa ở đầu và cuối. Hãy bỏ qua phần giới thiệu, mục lục, và TẬP TRUNG vào kiến thức trọng tâm. Nội dung: {textChunk}";

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                },
                generationConfig = new
                {
                    responseMimeType = "application/json"
                }
            };

            string jsonBody = JsonSerializer.Serialize(requestBody);

            // Tích hợp cơ chế Retry-Backoff để an toàn tuyệt đối
            int maxRetries = 5; // Tăng số lượng retry
            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _httpClient.PostAsync(_geminiUrl, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        // Nếu là lỗi Service Unavailable hoặc Too Many Requests thì thử lại
                        if ((int)response.StatusCode == 503 || (int)response.StatusCode == 429)
                        {
                            if (i == maxRetries - 1)
                            {
                                return $"Error: Hệ thống AI đang quá tải (TooManyRequests sau {maxRetries} lần thử). Vui lòng thử lại sau.";
                            }

                            // Google Gemeni Free tier có hard limit RPM (Request Per Minute) là 15 
                            // -> Nếu gặp rate limit, phải đợi ít nhất 10 - 30 giây
                            int waitTime = 10000 + (i * 10000); 
                            Console.WriteLine($"Gặp lỗi {(int)response.StatusCode}. Thử lại sau {waitTime / 1000} giây (lần thử {i + 1}/{maxRetries - 1})...");
                            await Task.Delay(waitTime); 
                            continue;
                        }

                        return $"Error: {response.StatusCode} - {responseString}";
                    }

                    using (JsonDocument doc = JsonDocument.Parse(responseString))
                    {
                        JsonElement root = doc.RootElement;
                        // Nếu trả về lỗi block
                        if (root.TryGetProperty("promptFeedback", out JsonElement feedback))
                        {
                            if (feedback.TryGetProperty("blockReason", out JsonElement blockReason))
                            {
                                return $"Error: API blocked request because {blockReason.GetString()}";
                            }
                        }

                        if (root.TryGetProperty("candidates", out JsonElement candidates) && candidates.GetArrayLength() > 0)
                        {
                            JsonElement firstCandidate = candidates[0];

                            // Có trường blockReason trong nội dung trả về
                            if (firstCandidate.TryGetProperty("finishReason", out JsonElement finishReason))
                            {
                                string finish = finishReason.GetString();
                                if (finish != "STOP" && finish != "MAX_TOKENS")
                                {
                                    return $"Error: Generation stopped with finishReason: {finish}";
                                }
                            }

                            if (firstCandidate.TryGetProperty("content", out JsonElement contentElement) &&
                                contentElement.TryGetProperty("parts", out JsonElement parts) && parts.GetArrayLength() > 0)
                            {
                                string generatedText = parts[0].GetProperty("text").GetString() ?? "";

                                // Remove markdown code blocks if any
                                generatedText = generatedText.Trim();
                                if (generatedText.StartsWith("```json", StringComparison.OrdinalIgnoreCase))
                                {
                                    generatedText = generatedText.Substring(7);
                                }
                                else if (generatedText.StartsWith("```", StringComparison.OrdinalIgnoreCase))
                                {
                                    generatedText = generatedText.Substring(3);
                                }

                                if (generatedText.EndsWith("```"))
                                {
                                    generatedText = generatedText.Substring(0, generatedText.Length - 3);
                                }

                                return generatedText.Trim();
                            }
                        }

                        return $"Error: Cannot parse candidates. Raw JSON: {responseString}";
                    }
                }
                catch (Exception ex)
                {
                    // Nếu là lần thử cuối cùng thì ném lỗi
                    if (i == maxRetries - 1)
                    {
                        Console.WriteLine($"Gemini API Error: {ex.Message}");
                        return $"Error: {ex.Message}";
                    }

                    // Nếu lỗi (như timeout mạng), đợi một chút rồi thử lại
                    await Task.Delay(4000 * (i + 1));
                }
            }

            return "Error: API call failed after all retries.";
        }
    }
}