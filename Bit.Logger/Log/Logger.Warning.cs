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
    }
}
