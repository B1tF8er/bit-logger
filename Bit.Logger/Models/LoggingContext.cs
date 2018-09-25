namespace Bit.Logger.Models
{
    using Microsoft.EntityFrameworkCore;
    
    public class LoggingContext : DbContext
    {
        private const string connectionString = "Data Source=logging.db";

        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite(connectionString);
    }
}