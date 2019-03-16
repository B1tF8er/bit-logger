namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments CriticalMessage(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Critical,
                className,
                methodName,
                message
            );

        internal static LogArguments CriticalException(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Critical,
                className,
                methodName,
                exception
            );

        internal static LogArguments CriticalMessageAndException(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Critical,
                className,
                methodName,
                message,
                exception
            );
    }
}
