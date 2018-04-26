namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Console;
    using Bit.Logger.Loggers.Database;
    using Bit.Logger.Loggers.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILoggerFactory
    {
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
