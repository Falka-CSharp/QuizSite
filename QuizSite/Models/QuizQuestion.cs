namespace QuizSite.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }

        public virtual List<Quiz>? Quizzes { get; set; }
    }
}
