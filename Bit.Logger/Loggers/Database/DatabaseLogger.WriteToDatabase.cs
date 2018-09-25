namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using Config;
    using Models;
    using System;
    using static Helpers.DateFormatter;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        private void WriteToDatabase(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;
            
            using (var context = new LoggingContext())
            {
                var log = new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = Configuration.ShowLevel ? logArguments.Level.ToString() : null,
                    Message = logArguments.Message,
                    Date = GetFormattedDateFrom(Configuration.DateTypeFormat),
                    Class = logArguments.ClassName,
                    Method = logArguments.MethodName,
                    Exception = logArguments.Exception?.ToString() ?? null
                };
                
                context.Logs.Add(log);
            }
        }
    }
}