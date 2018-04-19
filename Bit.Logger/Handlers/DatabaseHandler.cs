namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class DatabaseHandler : IHandler
    {
        public Configuration Configuration { get; }

        public DatabaseHandler(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();

        public void Write<TClass>(string message, Level level) where TClass : class =>
            ToDatabase<TClass>(level, message);

        public void Write(string message, Level level) =>
            ToDatabase(level, message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            ToDatabase<TClass>(level, exception: exception);

        public void Write(Exception exception, Level level) =>
            ToDatabase(level, exception: exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            ToDatabase<TClass>(level, message, exception);

        public void Write(string message, Exception exception, Level level) =>
            ToDatabase(level, message, exception);

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