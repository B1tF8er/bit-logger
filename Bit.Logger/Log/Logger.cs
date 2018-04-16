namespace Bit.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;

    public partial class Logger
    {
        private readonly List<ILogger> _loggers;

        public Logger()
        {
            _loggers = new List<ILogger>();
        }

        public Logger AddConsoleHandler(ConsoleConfiguration configuration = null)
        {
            _loggers.Add(new ConsoleLogger(configuration));

            return this;
        }

        public Logger AddDatabaseHandler(DatabaseConfiguration configuration = null)
        {
            _loggers.Add(new DatabaseLogger(configuration));

            return this;
        }

        public Logger AddFileHandler(FileConfiguration configuration = null)
        {
            _loggers.Add(new FileLogger(configuration));

            return this;
        }

        public Logger AddHandler(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            _loggers.Add(logger);

            return this;
        }

        public Logger AddHandlers(IEnumerable<ILogger> loggers)
        {
            var anyLoggerIsNull = loggers?.Any(logger => logger == null) ?? true;

            if (anyLoggerIsNull)
                throw new ArgumentNullException(nameof(loggers));

            _loggers.AddRange(loggers);

            return this;
        }
    }
}
