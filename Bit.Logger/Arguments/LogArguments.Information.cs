namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments Information(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Information,
                className,
                methodName,
                message
            );

        internal static LogArguments Information(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Information,
                className,
                methodName,
                exception
            );

        internal static LogArguments Information(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Information,
                className,
                methodName,
                message,
                exception
            );
    }
}
