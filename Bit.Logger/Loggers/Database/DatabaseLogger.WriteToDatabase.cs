namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        private void WriteToDatabase<TClass>(Level level, string message = default(string), Exception exception = default(Exception))
            where TClass : class
        {
            if (Configuration.Level <= level)
            {
                using (var context = new LoggingContext())
                {
                    context.Logs.Add(new Log
                    {
                        Id = $"{Guid.NewGuid()}",
                        Level = Configuration.ShowLevel ? level.ToString() : null,
                        Message = message,
                        Date = GetDate(),
                        Class = typeof(TClass).FullName,
                        Method = GetMethodName(),
                        Exception = exception?.ToString() ?? null
                    });
                }
            }
        }

        private void WriteToDatabase(Level level, string message = default(string), Exception exception = default(Exception))
        {
            if (Configuration.Level <= level)
            {
                using (var context = new LoggingContext())
                {
                    context.Logs.Add(new Log
                    {
                        Id = $"{Guid.NewGuid()}",
                        Level = Configuration.ShowLevel ? level.ToString() : null,
                        Message = message,
                        Date = GetDate(),
                        Class = GetClass().FullName,
                        Method = GetMethodName(),
                        Exception = exception?.ToString() ?? null
                    });
                }
            }
        }

        private string GetDate()
        {
            if (Configuration.ShowDate && Configuration.ShowTime)
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            else if (Configuration.ShowDate)
                return DateTime.Now.ToString("yyyy-MM-dd");
            else if (Configuration.ShowTime)
                return DateTime.Now.ToString("HH:mm:ss");
            else
                return null;
        }
    }
}