namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments WarningMessage(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Warning,
                className,
                methodName,
                message
            );

        internal static LogArguments WarningException(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Warning,
                className,
                methodName,
                exception
            );

        internal static LogArguments WarningMessageAndException(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Warning,
                className,
                methodName,
                message,
                exception
            );
    }
}
