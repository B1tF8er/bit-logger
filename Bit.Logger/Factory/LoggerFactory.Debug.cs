namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;

    public partial class LoggerFactory
    {
        public void Debug(string message, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Debug(message, className, methodName));

        public void Debug(Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Debug(exception, className, methodName));

        public void Debug(string message, Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Debug(message, exception, className, methodName));
    }
}
