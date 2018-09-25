namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.DateFormatter;

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
                    Date = GetDateFormatFrom(Configuration),
                    Class = logArguments.ClassName,
                    Method = logArguments.MethodName,
                    Exception = logArguments.Exception?.ToString() ?? null
                };
                
                context.Logs.Add(log);
            }
        }
    }
}