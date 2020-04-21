namespace Bit.Logger.Models
{
    using Helpers;
    using Microsoft.EntityFrameworkCore;

    public class LoggingContext : DbContext
    {
        private readonly IDatabaseLogPathResolver databaseLogPathResolver;

        public DbSet<Log> Logs { get; set; }

        public LoggingContext(IDatabaseLogPathResolver databaseLogPathResolver) =>
            this.databaseLogPathResolver = databaseLogPathResolver;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite(databaseLogPathResolver.GetConnectionString());
    }
}
