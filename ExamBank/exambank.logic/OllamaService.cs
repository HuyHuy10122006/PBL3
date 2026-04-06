using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exambank.logic
{
    public class OllamaService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _ollamaUrl = "http://localhost:11434/api/generate";

        public async Task<string> GenerateQuestionsAsync(string textChunk)
        {
            // System prompt yêu cầu AI trả về định dạng JSON
            string prompt = $"Bạn là chuyên gia giáo dục. Dựa vào nội dung sau, hãy tạo 3 câu hỏi trắc nghiệm dưới dạng JSON array (mỗi object gồm: Question, OptionA, OptionB, OptionC, OptionD, Answer). Nội dung: {textChunk}";

            var requestBody = new
            {
                model = "gemma3:4b", // Tên model bạn đang dùng
                prompt = prompt,
                stream = false,
                format = "json" // Ép Ollama trả về chuẩn JSON
            };

            string jsonBody = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(_ollamaUrl, content);
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();

                // Trích xuất phần text (JSON) từ response của Ollama
                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {
                    JsonElement root = doc.RootElement;
                    string generatedJson = root.GetProperty("response").GetString();
                    return generatedJson;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}