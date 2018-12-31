namespace Bit.Logger
{
    using System;

    public partial class LoggerFactory
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
