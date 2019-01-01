namespace Bit.Logger.Factory
{
    using System;


    public partial class LoggerFactory
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
