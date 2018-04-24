namespace Bit.Logger.Loggers
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal class ConsoleLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public ConsoleLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();

        public void Trace<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            ToConsole(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            ToConsole(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            ToConsole(Level.Trace, message, exception);
        
        public void Debug<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            ToConsole(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            ToConsole(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            ToConsole(Level.Debug, message, exception);
            
        public void Verbose<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            ToConsole(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            ToConsole(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            ToConsole(Level.Verbose, message, exception);

        public void Information<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Information, message);

        public void Information(string message) =>
            ToConsole(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            ToConsole(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            ToConsole(Level.Information, message, exception);

        public void Warning<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            ToConsole(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            ToConsole(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            ToConsole(Level.Warning, message, exception);

        public void Error<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Error, message);

        public void Error(string message) =>
            ToConsole(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            ToConsole(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            ToConsole(Level.Error, message, exception);
            
        public void Critical<TClass>(string message) where TClass : class =>
            ToConsole<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            ToConsole(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            ToConsole(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            ToConsole<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            ToConsole(Level.Critical, message, exception);

        private void ToConsole<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level <= level)
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
            if (Configuration.Level <= level)
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