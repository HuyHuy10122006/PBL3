using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(700)]
        public string Question { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string OptionA { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string OptionB { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string OptionC { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string OptionD { get; set; } = string.Empty;

        [Required]
        [MaxLength(1)]
        [RegularExpression("^[ABCD]$", ErrorMessage = "Answer phải là A, B, C hoặc D")]
        public string Answer { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Explanation { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Subject { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Grade { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Difficulty { get; set; } = string.Empty;

        // Foreign Key - Danh mục câu hỏi
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual CategoryModel? Category { get; set; }

        // Foreign Key - Người tạo
        [Required]
        public int CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public virtual UserModel? Author { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<ExamQuestionModel> ExamQuestions { get; set; } = new List<ExamQuestionModel>();
    }
}