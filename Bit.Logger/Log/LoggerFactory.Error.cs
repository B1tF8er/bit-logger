namespace Bit.Logger
{
    using System;

    public partial class LoggerFactory
    {
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
    }
}
