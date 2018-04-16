namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        private void Write<TClass>(string message, Level logLevel) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(message, logLevel));

        private void Write(string message, Level logLevel) =>
            _loggers.ForEach(logger => logger.Write(message, logLevel));

        private void Write<TClass>(Exception exception, Level logLevel) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(exception, logLevel));

        private void Write(Exception exception, Level logLevel) =>
            _loggers.ForEach(logger => logger.Write(exception, logLevel));

        private void Write<TClass>(string message, Exception exception, Level logLevel) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(message, exception, logLevel));

        private void Write(string message, Exception exception, Level logLevel) =>
            _loggers.ForEach(logger => logger.Write(message, exception, logLevel));
    }
}