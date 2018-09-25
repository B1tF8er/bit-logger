namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.FormatProviders.FormatterStrategy.Constants;

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
                    Date = GetDate(),
                    Class = logArguments.ClassName,
                    Method = logArguments.MethodName,
                    Exception = logArguments.Exception?.ToString() ?? null
                };
                
                context.Logs.Add(log);
            }
        }

        private string GetDate()
        {
            if (Configuration.ShowDate && Configuration.ShowTime)
                return DateTime.Now.ToString(DateTimeFormat);
            else if (Configuration.ShowDate)
                return DateTime.Now.ToString(DateFormat);
            else if (Configuration.ShowTime)
                return DateTime.Now.ToString(TimeFormat);
            else
                return null;
        }
    }
}