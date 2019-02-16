namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;

    public partial class LoggerFactory
    {
        public void Error(string message, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Error(message, className, methodName));

        public void Error(Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Error(exception, className, methodName));

        public void Error(string message, Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Error(message, exception, className, methodName));
    }
}
