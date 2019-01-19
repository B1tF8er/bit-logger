namespace Bit.Logger.Writers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    internal static class DatabaseBulkWriter
    {
        internal static async void ToDatabaseAsync(IEnumerable<Log> logs)
        {
            using (var context = new LoggingContext())
                await context.Logs.AddRangeAsync(logs);
        }
    }
}
