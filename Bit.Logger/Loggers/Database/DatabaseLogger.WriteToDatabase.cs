namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using Config;
    using Models;
    using System.Collections.Generic;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        private void WriteToDatabase(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(logArguments.ToDatabaseLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriteToDatabaseAsync, kv => kv.Value)
                .Clear();
        }

        private async void BulkWriteToDatabaseAsync(IEnumerable<Log> logs)
        {
            using (var context = new LoggingContext())
                await context.Logs.AddRangeAsync(logs);
        }
    }
}