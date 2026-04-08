using System.ComponentModel.DataAnnotations;

namespace exambank.data.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(700)]
        public string Question { get; set; } = string.Empty;

        [MaxLength(500)]
        public string OptionA { get; set; } = string.Empty;

        [MaxLength(500)]
        public string OptionB { get; set; } = string.Empty;

        [MaxLength(500)]
        public string OptionC { get; set; } = string.Empty;

        [MaxLength(500)]
        public string OptionD { get; set; } = string.Empty;

        [MaxLength(1)]
        public string Answer { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Explanation { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Subject { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Grade { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Difficulty { get; set; } = string.Empty;
    }
}