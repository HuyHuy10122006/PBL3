using exambank.data.Models;
using Microsoft.EntityFrameworkCore;

namespace exambank.data
{
    public class ExamBankDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ExamModel> Exams { get; set; }
        public DbSet<ExamQuestionModel> ExamQuestions { get; set; }
        public DbSet<AIConfigModel> AIConfigs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EduGenAI_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ========== UserModel ==========
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // ========== QuestionModel ==========
            modelBuilder.Entity<QuestionModel>()
                .Property(q => q.Answer)
                .HasMaxLength(1);

            modelBuilder.Entity<QuestionModel>()
                .HasOne(q => q.Category)
                .WithMany(c => c.Questions)
                .HasForeignKey(q => q.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<QuestionModel>()
                .HasOne(q => q.Author)
                .WithMany(u => u.CreatedQuestions)
                .HasForeignKey(q => q.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ========== ExamModel ==========
            modelBuilder.Entity<ExamModel>()
                .HasOne(e => e.Author)
                .WithMany(u => u.CreatedExams)
                .HasForeignKey(e => e.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ========== ExamQuestionModel ==========
            modelBuilder.Entity<ExamQuestionModel>()
                .HasOne(eq => eq.Exam)
                .WithMany(e => e.ExamQuestions)
                .HasForeignKey(eq => eq.ExamId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExamQuestionModel>()
                .HasOne(eq => eq.Question)
                .WithMany(q => q.ExamQuestions)
                .HasForeignKey(eq => eq.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique constraint: Không được thêm cùng 1 câu hỏi 2 lần vào 1 bài thi
            modelBuilder.Entity<ExamQuestionModel>()
                .HasIndex(eq => new { eq.ExamId, eq.QuestionId })
                .IsUnique();
        }
    }
}