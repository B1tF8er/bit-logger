namespace Bit.Logger
{
    using Config;
    using Loggers.Console;
    using Loggers.Database;
    using Loggers.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class LoggerFactory : ILoggerFactory
    {
        public List<ILogger> Loggers { get; }

        public LoggerFactory() => Loggers = new List<ILogger>();

        public ILoggerFactory AddConsoleSource(Configuration configuration = default)
        {
            Loggers.Add(new ConsoleLogger(configuration));

            return this;
        }

        public ILoggerFactory AddDatabaseSource(Configuration configuration = default)
        {
            Loggers.Add(new DatabaseLogger(configuration));

            return this;
        }

        public ILoggerFactory AddFileSource(Configuration configuration = default)
        {
            Loggers.Add(new FileLogger(configuration));

            return this;
        }

        public ILoggerFactory AddSource(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            Loggers.Add(logger);

            return this;
        }

        public ILoggerFactory AddSources(IEnumerable<ILogger> loggers)
        {
            var anyLoggerIsNull = loggers?.Any(logger => logger == null) ?? true;

            if (anyLoggerIsNull)
                throw new ArgumentNullException(nameof(loggers));

            Loggers.AddRange(loggers);

            return this;
        }

        public override string ToString()
        {
            var loggersNames = new StringBuilder();
            
            Loggers.ForEach(logger => loggersNames.AppendLine(logger.GetType().FullName));

            return loggersNames.ToString();
        }
    }
}
