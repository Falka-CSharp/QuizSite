using Microsoft.EntityFrameworkCore;
using QuizSite.Models;

namespace QuizSite.Data
{
    public class QuizSiteDbContext : DbContext
    {
        public QuizSiteDbContext(DbContextOptions<QuizSiteDbContext> options) : base(options) { }
        public DbSet<QuizQuestion>? Questions { get; set; }
        public DbSet<QuizSite.Models.Quiz> Quiz { get; set; }
    }
}
