namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class ConsoleLogger : ILogger
    {
        public readonly ConsoleConfiguration Configuration;

        public ConsoleLogger(ConsoleConfiguration configuration) =>
            Configuration = configuration ?? new ConsoleConfiguration();

        public void Write<TClass>(string message, Level level) where TClass : class =>
            ToConsole<TClass>(level, message);

        public void Write(string message, Level level) =>
            ToConsole(level, message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            ToConsole<TClass>(level, exception: exception);

        public void Write(Exception exception, Level logLevel) =>
            ToConsole(logLevel, exception: exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            ToConsole<TClass>(level, message, exception);

        public void Write(string message, Exception exception, Level level) =>
            ToConsole(level, message, exception);

        private void ToConsole<TClass>(Level level, string message = default(string), Exception exception = null)
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

        private void ToConsole(Level level, string message = default(string), Exception exception = null)
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