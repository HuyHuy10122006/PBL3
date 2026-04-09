using System.ComponentModel.DataAnnotations;

namespace exambank.data.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        public bool IsActive { get; set; } = true; 

        public virtual ICollection<QuestionModel> Questions { get; set; } = new List<QuestionModel>();
    }
}