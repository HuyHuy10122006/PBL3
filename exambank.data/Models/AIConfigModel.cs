using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    /// <summary>
    /// Bảng lưu trữ cấu hình AI (Ollama/LLMs/Gemini)
    /// Đã được bổ sung Data Annotations để Validate dữ liệu chặt chẽ.
    /// </summary>
    [Table("AI_Configs")]
    public class AIConfigModel
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        // ========== THÔNG SỐ KẾT NỐI ==========

        [Required(ErrorMessage = "Vui lòng nhập URL kết nối")]
        [StringLength(256, ErrorMessage = "URL không được vượt quá 256 ký tự")]
        public string OllamaUrl { get; set; } = "http://localhost:11434/api/generate";

        [Required(ErrorMessage = "Vui lòng nhập tên Model")]
        [StringLength(100, ErrorMessage = "Tên Model không được vượt quá 100 ký tự")]
        public string Model { get; set; } = "gemma3:4b";

        [Range(1, int.MaxValue, ErrorMessage = "Thời gian Timeout phải lớn hơn 0")]
        public int TimeoutSeconds { get; set; } = 60;

        // ========== THÔNG SỐ TINH CHỈNH AI ==========

        [Range(0.0, 1.0, ErrorMessage = "Temperature chỉ được phép từ 0.0 đến 1.0")]
        public double Temperature { get; set; } = 0.7;

        [Range(0.0, 1.0, ErrorMessage = "TopP chỉ được phép từ 0.0 đến 1.0")]
        public double TopP { get; set; } = 0.9;

        [Range(1, int.MaxValue, ErrorMessage = "TopK phải lớn hơn 0")]
        public int TopK { get; set; } = 40;

        [Range(1, 100, ErrorMessage = "Số lượng câu hỏi mỗi lần tạo chỉ từ 1 đến 100")]
        public int QuestionsPerGeneration { get; set; } = 3;

        // ========== CẤU HÌNH LỖI (RETRY) ==========

        public bool EnableRetry { get; set; } = true;

        [Range(1, 10, ErrorMessage = "Chỉ nên thử lại từ 1 đến tối đa 10 lần")]
        public int MaxRetries { get; set; } = 3;

        [Range(100, 60000, ErrorMessage = "Thời gian chờ Retry phải từ 100ms đến 60000ms (1 phút)")]
        public int RetryDelayMs { get; set; } = 1000;

        // ========== NỘI DUNG PROMPT ==========

        [Required(ErrorMessage = "System Prompt không được để trống")]
        [StringLength(5000, ErrorMessage = "System Prompt quá dài, tối đa 5000 ký tự")]
        public string SystemPrompt { get; set; } =
            "Bạn là chuyên gia giáo dục. Hãy tạo câu hỏi trắc nghiệm chất lượng cao dựa trên nội dung được cung cấp. Trả về kết quả dưới dạng JSON array.";

        [Required(ErrorMessage = "Vui lòng chọn định dạng Output")]
        [RegularExpression("^(json|text)$", ErrorMessage = "OutputFormat chỉ chấp nhận 'json' hoặc 'text'")]
        public string OutputFormat { get; set; } = "json";

        // ========== QUẢN LÝ TRẠNG THÁI ==========

        public bool IsActive { get; set; } = true;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}