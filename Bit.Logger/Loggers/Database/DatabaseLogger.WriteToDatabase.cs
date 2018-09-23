namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Arguments;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        private void WriteToDatabase<TClass>(Level level, string message = default(string), Exception exception = default(Exception)) where TClass : class
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = typeof(TClass).FullName,
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );
            
        private void WriteToDatabase(Level level, string message = default(string), Exception exception = default(Exception))
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = GetClassName(),
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );

        private void Write(LogArguments logArguments)
        {
            if (Configuration.Level <= logArguments.Level)
            {
                using (var context = new LoggingContext())
                {
                    context.Logs.Add(new Log
                    {
                        Id = $"{Guid.NewGuid()}",
                        Level = Configuration.ShowLevel ? logArguments.Level.ToString() : null,
                        Message = logArguments.Message,
                        Date = GetDate(),
                        Class = logArguments.ClassName,
                        Method = logArguments.MethodName,
                        Exception = logArguments.Exception?.ToString() ?? null
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