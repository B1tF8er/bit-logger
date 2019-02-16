namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments ErrorMessage(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Error,
                className,
                methodName,
                message
            );

        internal static LogArguments ErrorException(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Error,
                className,
                methodName,
                exception
            );

        internal static LogArguments ErrorMessageAndException(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Error,
                className,
                methodName,
                message,
                exception
            );
    }
}
