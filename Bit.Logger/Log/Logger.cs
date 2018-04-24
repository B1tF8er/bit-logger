namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILoggerFactoty
    {
        public List<ILogger> Loggers { get; }

        public Logger() => Loggers = new List<ILogger>();

        public ILoggerFactoty AddConsoleLogger(Configuration configuration = default(Configuration))
        {
            Loggers.Add(new ConsoleLogger(configuration));

            return this;
        }

        public ILoggerFactoty AddDatabaseLogger(Configuration configuration = default(Configuration))
        {
            Loggers.Add(new DatabaseLogger(configuration));

            return this;
        }

        public ILoggerFactoty AddFileLogger(Configuration configuration = default(Configuration))
        {
            Loggers.Add(new FileLogger(configuration));

            return this;
        }

        public ILoggerFactoty AddLogger(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            Loggers.Add(logger);

            return this;
        }

        public ILoggerFactoty AddLoggers(IEnumerable<ILogger> loggers)
        {
            var anyLoggerIsNull = loggers?.Any(logger => logger == null) ?? true;

            if (anyLoggerIsNull)
                throw new ArgumentNullException(nameof(loggers));

            Loggers.AddRange(loggers);

            return this;
        }

        public void Trace<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message));

        public void Trace(string message) =>
            Loggers.ForEach(logger => logger.Trace(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(exception));

        public void Trace(Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(message, exception));
        
        public void Debug<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Debug<TClass>(message));

        public void Debug(string message) =>
            Loggers.ForEach(logger => logger.Debug(message));

        public void Debug<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Debug<TClass>(exception));

        public void Debug(Exception exception) =>
            Loggers.ForEach(logger => logger.Debug(exception));

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Debug<TClass>(message, exception));

        public void Debug(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Debug(message, exception));
            
        public void Verbose<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(message));

        public void Verbose(string message) =>
            Loggers.ForEach(logger => logger.Verbose(message));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(exception));

        public void Verbose(Exception exception) =>
            Loggers.ForEach(logger => logger.Verbose(exception));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(message, exception));

        public void Verbose(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Verbose(message, exception));
            
        public void Information<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Information<TClass>(message));

        public void Information(string message) =>
            Loggers.ForEach(logger => logger.Information(message));

        public void Information<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Information<TClass>(exception));

        public void Information(Exception exception) =>
            Loggers.ForEach(logger => logger.Information(exception));

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Information<TClass>(message, exception));

        public void Information(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Information(message, exception));
            
        public void Warning<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Warning<TClass>(message));

        public void Warning(string message) =>
            Loggers.ForEach(logger => logger.Warning(message));

        public void Warning<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Warning<TClass>(exception));

        public void Warning(Exception exception) =>
            Loggers.ForEach(logger => logger.Warning(exception));

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Warning<TClass>(message, exception));

        public void Warning(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Warning(message, exception));

        public void Error<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Error<TClass>(message));

        public void Error(string message) =>
            Loggers.ForEach(logger => logger.Error(message));

        public void Error<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Error<TClass>(exception));

        public void Error(Exception exception) =>
            Loggers.ForEach(logger => logger.Error(exception));

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Error<TClass>(message, exception));

        public void Error(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Error(message, exception));

        public void Critical<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Critical<TClass>(message));

        public void Critical(string message) =>
            Loggers.ForEach(logger => logger.Critical(message));

        public void Critical<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Critical<TClass>(exception));

        public void Critical(Exception exception) =>
            Loggers.ForEach(logger => logger.Critical(exception));

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Critical<TClass>(message, exception));

        public void Critical(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Critical(message, exception));
    }
}
