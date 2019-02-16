namespace Bit.Logger.Factory
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class LoggerFactory
    {
        public void Verbose(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Verbose(message, className, methodName));

        public void Verbose(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Loggers.ForEach(logger => logger.Verbose(message, exception, className, methodName));
    }
}
