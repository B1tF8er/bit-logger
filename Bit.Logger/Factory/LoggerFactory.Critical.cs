namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class LoggerFactory
    {
        public void Critical(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Critical(message, className, methodName));

        public void Critical(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Critical(exception, className, methodName));

        public void Critical(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Critical(message, exception, className, methodName));
    }
}
