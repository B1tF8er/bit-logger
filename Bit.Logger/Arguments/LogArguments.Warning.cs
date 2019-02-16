namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments Warning(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Warning,
                className,
                methodName,
                message
            );

        internal static LogArguments Warning(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Warning,
                className,
                methodName,
                exception
            );

        internal static LogArguments Warning(string message, Exception exception, string className, string methodName) =>
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
