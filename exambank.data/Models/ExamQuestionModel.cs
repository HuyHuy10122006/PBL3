using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    public class ExamQuestionModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ExamId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        public int QuestionOrder { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("ExamId")]
        public virtual ExamModel? Exam { get; set; }

        [ForeignKey("QuestionId")]
        public virtual QuestionModel? Question { get; set; }
    }
}