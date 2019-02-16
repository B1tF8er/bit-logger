namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments Error(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Error,
                className,
                methodName,
                message
            );

        internal static LogArguments Error(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Error,
                className,
                methodName,
                exception
            );

        internal static LogArguments Error(string message, Exception exception, string className, string methodName) =>
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
