using exambank.data.Models;
using Microsoft.EntityFrameworkCore;

namespace exambank.data
{
    public class ExamBankDbContext : DbContext
    {
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ExamModel> Exams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EduGenAI_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}