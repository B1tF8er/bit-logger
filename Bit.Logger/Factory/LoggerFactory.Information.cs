namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class LoggerFactory
    {
        public void Information(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Information(message, className, methodName));

        public void Information(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Information(exception, className, methodName));

        public void Information(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Information(message, exception, className, methodName));
    }
}
