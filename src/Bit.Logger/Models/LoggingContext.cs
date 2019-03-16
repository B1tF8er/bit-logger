namespace Bit.Logger.Models
{
    using Microsoft.EntityFrameworkCore;
    using static Helpers.Constants.Sqlite;
    
    public class LoggingContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite(ConnectionString);
    }
}
