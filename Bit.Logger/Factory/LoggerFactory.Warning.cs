namespace Bit.Logger.Factory
{
    using System;

    public partial class LoggerFactory
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
