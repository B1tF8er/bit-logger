namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;

    public partial class LoggerFactory
    {
        public void Verbose(string message, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Verbose(message, className, methodName));

        public void Verbose(Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, [CallerFilePath] string className = "", [CallerMemberName] string methodName = "") =>
            Loggers.ForEach(logger => logger.Verbose(message, exception, className, methodName));
    }
}
