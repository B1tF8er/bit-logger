namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;

    public partial class LoggerFactory
    {
        public void Critical(string message, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Critical(message, className, methodName));

        public void Critical(Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Critical(exception, className, methodName));

        public void Critical(string message, Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Critical(message, exception, className, methodName));
    }
}
