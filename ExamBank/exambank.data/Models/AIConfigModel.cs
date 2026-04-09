using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    /// <summary>
    /// Bảng lưu trữ cấu hình AI (Ollama/LLMs)
    /// Cho phép Admin điều chỉnh thông số trực tiếp từ giao diện Web (UC006)
    /// </summary>
    [Table("AI_Configs")]
    public class AIConfigModel
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        // ========== THÔNG SỐ KẾT NỐI ==========
        public string OllamaUrl { get; set; } = "http://localhost:11434/api/generate";

        /// <summary>
        /// Tên model đang sử dụng (VD: gemma3:4b, llama3, qwen)
        /// </summary>
        public string Model { get; set; } = "gemma3:4b";

        public int TimeoutSeconds { get; set; } = 60;

        // ========== THÔNG SỐ TINH CHỈNH AI ==========

        /// <summary>
        /// Độ sáng tạo của AI (0.0 - 1.0). Khuyên dùng: 0.7
        /// </summary>
        public double Temperature { get; set; } = 0.7;

        public double TopP { get; set; } = 0.9;
        public int TopK { get; set; } = 40;

        /// <summary>
        /// Số câu hỏi tạo ra trong mỗi một lần gọi API
        /// </summary>
        public int QuestionsPerGeneration { get; set; } = 3;

        // ========== CẤU HÌNH LỖI (RETRY) ==========
        public bool EnableRetry { get; set; } = true;
        public int MaxRetries { get; set; } = 3;
        public int RetryDelayMs { get; set; } = 1000;

        // ========== NỘI DUNG PROMPT ==========

        /// <summary>
        /// Câu lệnh định hướng chuyên môn cho AI
        /// </summary>
        public string SystemPrompt { get; set; } =
            "Bạn là chuyên gia giáo dục. Hãy tạo câu hỏi trắc nghiệm chất lượng cao dựa trên nội dung được cung cấp. Trả về kết quả dưới dạng JSON array.";

        public string OutputFormat { get; set; } = "json";

        // ========== QUẢN LÝ TRẠNG THÁI ==========

        /// <summary>
        /// Xác định cấu hình nào đang được hệ thống sử dụng chính thức
        /// </summary>
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}