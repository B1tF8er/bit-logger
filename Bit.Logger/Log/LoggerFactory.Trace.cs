namespace Bit.Logger
{
    using System;

    public partial class LoggerFactory
    {
        public void Trace<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message));

        public void Trace(string message) =>
            Loggers.ForEach(logger => logger.Trace(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(exception));

        public void Trace(Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(message, exception));
    }
}
