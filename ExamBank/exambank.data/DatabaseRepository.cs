using System.Collections.Generic;

namespace exambank.data
{
    public class DatabaseRepository
    {
        public void SaveQuestions(List<QuestionModel> questions)
        {
            // Viết code Entity Framework Core hoặc ADO.NET (SqlCommand) ở đây
            // Ví dụ:
            // foreach(var q in questions) { _dbContext.Questions.Add(q); }
            // _dbContext.SaveChanges();
        }
    }
}