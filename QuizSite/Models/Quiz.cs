namespace QuizSite.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? QuizName { get; set; }
        public virtual List<QuizQuestion>? Questions { get; set; }
    }
}
