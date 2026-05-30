using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exambank.data.Models
{
    [Table("SystemLogs")]
    public class SystemLog
    {
        public int Id { get; set; }

        public DateTime LogTime { get; set; } = DateTime.Now;

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(255)]
        public string Action { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }
    }
}