namespace Bit.Logger.Writers
{
    using Helpers;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;

    internal class DatabaseBulkWriter : IDatabaseBulkWriter
    {
        private readonly IDatabaseLogPathResolver databaseLogPathResolver;

        public DatabaseBulkWriter(IDatabaseLogPathResolver databaseLogPathResolver) =>
            this.databaseLogPathResolver = databaseLogPathResolver;

        public async void ToDatabaseAsync(IEnumerable<Log> logs)
        {
            using var context = new LoggingContext(databaseLogPathResolver);
            
            context.Database.Migrate();
            await context.Logs.AddRangeAsync(logs);
            await context.SaveChangesAsync();
        }
    }
}
