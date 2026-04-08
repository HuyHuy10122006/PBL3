using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    public class ExamModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty; 
        [MaxLength(20)]
        public string ExamCode { get; set; } = string.Empty; 

        [Required]
        public int Duration { get; set; } 
        public int TotalQuestions { get; set; } 

        [MaxLength(100)]
        public string Subject { get; set; } = string.Empty; 

        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        [MaxLength(200)]
        public string? Note { get; set; } 
        [Required]
        public int CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public UserModel? Author { get; set; }
    }
}