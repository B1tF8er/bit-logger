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
    }
}
