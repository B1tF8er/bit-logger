namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        private void Write<TClass>(string message, Level level) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(message, level));

        private void Write(string message, Level level) =>
            _loggers.ForEach(logger => logger.Write(message, level));

        private void Write<TClass>(Exception exception, Level level) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(exception, level));

        private void Write(Exception exception, Level level) =>
            _loggers.ForEach(logger => logger.Write(exception, level));

        private void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            _loggers.ForEach(logger => logger.Write<TClass>(message, exception, level));

        private void Write(string message, Exception exception, Level level) =>
            _loggers.ForEach(logger => logger.Write(message, exception, level));
    }
}