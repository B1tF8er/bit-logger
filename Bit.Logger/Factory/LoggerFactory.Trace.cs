namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;

    public partial class LoggerFactory
    {
        public void Trace(string message, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Trace(message, className, methodName));

        public void Trace(Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Trace(exception, className, methodName));

        public void Trace(string message, Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Trace(message, exception, className, methodName));
    }
}
