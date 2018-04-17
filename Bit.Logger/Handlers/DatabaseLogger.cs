namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class DatabaseLogger : ILogger
    {
        public Configuration Configuration { get; }

        public DatabaseLogger(DatabaseConfiguration configuration) =>
            Configuration = configuration ?? new DatabaseConfiguration();

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
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        typeof(TClass).FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
            }
        }

        private void ToDatabase(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level >= level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        GetClass().FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
            }
        }
    }
}