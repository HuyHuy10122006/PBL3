using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
                    var repo = new DatabaseRepository(db);
                    return repo.GetActiveAIConfigAsync().GetAwaiter().GetResult();
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

        public async IAsyncEnumerable<string> GenerateQuestionsStreamAsync(string textChunk, int numbOfQuestions = 10)
        {
            int batchSize = 10; // Giảm xuống 10 câu mỗi mẻ để tránh rate limit cứng của Google AI Studio (Free tier khoảng 15 RPM)
            int numBatches = (int)Math.Ceiling((double)numbOfQuestions / batchSize);

            for (int i = 0; i < numBatches; i++)
            {
                int count = (i == numBatches - 1 && numbOfQuestions % batchSize != 0) ? (numbOfQuestions % batchSize) : batchSize;

                // Xử lý tuần tự thay vì song song để đảm bảo ổn định không bị rate limit
                string res = await GenerateBatchAsync(textChunk, count, i);

                if (!string.IsNullOrWhiteSpace(res))
                {
                    yield return res;
                }

                // Chờ đủ thời gian để hệ thống AI không báo lỗi (15 RPM -> chờ khoảng 5 giây mỗi request)
                if (i < numBatches - 1)
                {
                    await Task.Delay(5000); 
                }
            }
        }

        public async Task<string> GenerateQuestionsAsync(string textChunk, int numbOfQuestions = 10)
        {
            int batchSize = 10; // Giảm batch size
            if (numbOfQuestions <= batchSize)
            {
                return await GenerateBatchAsync(textChunk, numbOfQuestions, 0);
            }

            int numBatches = (int)Math.Ceiling((double)numbOfQuestions / batchSize);
            var results = new List<string>();

            for (int i = 0; i < numBatches; i++)
            {
                int count = (i == numBatches - 1 && numbOfQuestions % batchSize != 0) ? (numbOfQuestions % batchSize) : batchSize;
                string res = await GenerateBatchAsync(textChunk, count, i);
                results.Add(res);

                // Tránh lỗi quá tải của API (Rate Limit) khoản 15 RPM
                if (i < numBatches - 1)
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

        private async Task<string> GenerateBatchAsync(string textChunk, int numbOfQuestions, int batchIndex)
        {
            string prompt = $"Bạn là chuyên gia giáo dục. Dựa vào nội dung sau, hãy tạo {numbOfQuestions} câu hỏi trắc nghiệm dưới dạng JSON array (mỗi object gồm: Question, OptionA, OptionB, OptionC, OptionD, Answer). Chỉ trả về duy nhất 1 mảng JSON chuẩn xác, không có markdown, không có chữ thừa ở đầu và cuối. Hãy tạo các câu hỏi đa dạng (Phần {batchIndex + 1}). Nội dung: {textChunk}";

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