namespace Bit.Logger.Models
{
    using Microsoft.EntityFrameworkCore;
    
    public class LoggingContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=logging.db");
        }
    }
}