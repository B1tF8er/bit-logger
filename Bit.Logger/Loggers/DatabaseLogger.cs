namespace Bit.Logger.Loggers
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class DatabaseLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public DatabaseLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();

        public void Trace<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            ToDatabase(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            ToDatabase(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            ToDatabase(Level.Trace, message, exception);
        
        public void Debug<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            ToDatabase(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            ToDatabase(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            ToDatabase(Level.Debug, message, exception);
            
        public void Verbose<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            ToDatabase(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            ToDatabase(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            ToDatabase(Level.Verbose, message, exception);

        public void Information<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Information, message);

        public void Information(string message) =>
            ToDatabase(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            ToDatabase(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            ToDatabase(Level.Information, message, exception);

        public void Warning<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            ToDatabase(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            ToDatabase(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            ToDatabase(Level.Warning, message, exception);

        public void Error<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Error, message);

        public void Error(string message) =>
            ToDatabase(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            ToDatabase(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            ToDatabase(Level.Error, message, exception);
            
        public void Critical<TClass>(string message) where TClass : class =>
            ToDatabase<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            ToDatabase(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            ToDatabase(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            ToDatabase<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            ToDatabase(Level.Critical, message, exception);

        private void ToDatabase<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level >= level)
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

        private void ToDatabase(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level >= level)
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