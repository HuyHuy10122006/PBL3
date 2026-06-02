using System;
using System.ComponentModel.DataAnnotations;

namespace exambank.data.Models
{
    public class DocumentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FileName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string DocumentType { get; set; } = string.Empty;

        public int UserId { get; set; } 

        public DateTime UploadedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}