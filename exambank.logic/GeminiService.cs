using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exambank.logic
{
    public class GeminiService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey = "AIzaSyDJYcxvRMQW73lH87WntqIO7KYBVNCyzk0";
        private readonly string _geminiUrl;

        public GeminiService()
        {
            _geminiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-flash-lite-latest:generateContent?key={_apiKey}";
        }

        public async IAsyncEnumerable<string> GenerateQuestionsStreamAsync(string textChunk, int numbOfQuestions = 10)
        {
            int batchSize = 20; // Xử lý 20 câu mỗi mẻ để an toàn nhất
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

                // Chờ đủ thời gian để hệ thống AI không báo lỗi
                if (i < numBatches - 1)
                {
                    await Task.Delay(4000); 
                }
            }
        }

        public async Task<string> GenerateQuestionsAsync(string textChunk, int numbOfQuestions = 10)
        {
            int batchSize = 20; // Xử lý 20 câu mỗi luồng tạo tốc độ cao nhất
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

                // Tránh lỗi quá tải của API (Rate Limit)
                if (i < numBatches - 1)
                {
                    await Task.Delay(4000); // Đợi 4 giây giữa các request
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
            string prompt = $"Bạn là chuyên gia giáo dục. Dựa vào nội dung sau, hãy tạo {numbOfQuestions} câu hỏi trắc nghiệm dưới dạng JSON array (mỗi object gồm: Question, OptionA, OptionB, OptionC, OptionD, Answer). Chỉ trả về mảng JSON, không markdown. Hãy tạo các câu hỏi đa dạng (Phần {batchIndex + 1}). Nội dung: {textChunk}";

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
            int maxRetries = 3; 
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

                            // Đợi theo hàm số mũ cơ bản để nhường API
                            int waitTime = 4000 + (i * 3000); 
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