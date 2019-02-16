namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class LoggerFactory
    {
        public void Warning(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Warning(message, className, methodName));

        public void Warning(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Warning(exception, className, methodName));

        public void Warning(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Warning(message, exception, className, methodName));
    }
}
