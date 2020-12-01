namespace Bit.Logger.Writers
{
    using Helpers;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;

    internal class DatabaseBulkWriter : IBulkWriter<Log>
    {
        private readonly IDatabaseLogPathResolver databaseLogPathResolver;

        public DatabaseBulkWriter(IDatabaseLogPathResolver databaseLogPathResolver) =>
            this.databaseLogPathResolver = databaseLogPathResolver;

        public async void Write(IEnumerable<Log> logs)
        {
            using var context = new LoggingContext(databaseLogPathResolver);

            context.Database.Migrate();
            await context.Logs.AddRangeAsync(logs).ConfigureAwait(false);
            await context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
