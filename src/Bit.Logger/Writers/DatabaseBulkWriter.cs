namespace Bit.Logger.Writers
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;

    internal static class DatabaseBulkWriter
    {
        internal static async void ToDatabaseAsync(IEnumerable<Log> logs)
        {
            using (var context = new LoggingContext())
            {
                context.Database.Migrate();
                await context.Logs.AddRangeAsync(logs);
                await context.SaveChangesAsync();
            }
        }
    }
}
