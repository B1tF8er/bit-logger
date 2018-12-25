namespace Bit.Logger
{
    using System;

    public partial class Logger : ILoggerFactory
    {
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
    }
}
