using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum ApprovalStatus
{
    None = 0,       // Chưa chia sẻ
    Pending = 1,    // Đang chờ Admin duyệt
    Approved = 2,   // Đã được duyệt
    Rejected = 3    // Bị từ chối
}

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

        [Required] 
        public int TotalQuestions { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Grade { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string? Note { get; set; }

        [Required]
        public int CreatedByUserId { get; set; }

        public bool IsShared { get; set; } = false;

        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.None;

        [MaxLength(500)]
        public string? AdminNote { get; set; }

        /// <summary>
        /// ID đề thi gốc nếu đề này được clone từ ngân hàng chung.
        /// Nếu != null → không cho phép chia sẻ lại.
        /// </summary>
        public int? OriginalExamId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public virtual UserModel? Author { get; set; }

        // 🆕 Navigation Properties
        public virtual ICollection<ExamQuestionModel> ExamQuestions { get; set; } = new List<ExamQuestionModel>();
    }
}   