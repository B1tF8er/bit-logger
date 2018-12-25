namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using Config;
    using Models;
    using System;
    using System.Collections.Generic;
    using static Helpers.DateFormatter;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        private void WriteToDatabase(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(CreateLogWith(logArguments))
                .Validate()
                ?.Write(BulkWriteToDatabaseAsync, kv => kv.Value)
                .Clear();
        }

        private Log CreateLogWith(LogArguments logArguments)
        {
            return new Log
            {
                Id = $"{Guid.NewGuid()}",
                Level = Configuration.ShowLevel ? logArguments.Level.ToString() : null,
                Message = logArguments.Message,
                Date = GetFormattedDateFrom(Configuration.DateTypeFormat),
                Class = logArguments.ClassName,
                Method = logArguments.MethodName,
                Exception = logArguments.Exception?.ToString() ?? null
            };
        }

        private async void BulkWriteToDatabaseAsync(IEnumerable<Log> logs)
        {
            using (var context = new LoggingContext())
                await context.Logs.AddRangeAsync(logs);
        }
    }
}