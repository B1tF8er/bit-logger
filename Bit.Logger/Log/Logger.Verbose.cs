namespace Bit.Logger
{
    using System;
    using System.Linq;

    public partial class Logger : ILoggerFactory
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(message));

        public void Verbose(string message) =>
            Loggers.ForEach(logger => logger.Verbose(message));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(exception));

        public void Verbose(Exception exception) =>
            Loggers.ForEach(logger => logger.Verbose(exception));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Verbose<TClass>(message, exception));

        public void Verbose(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Verbose(message, exception));
    }
}
