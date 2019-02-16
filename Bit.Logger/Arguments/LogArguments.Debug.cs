namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments Debug(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Debug,
                className,
                methodName,
                message
            );

        internal static LogArguments Debug(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Debug,
                className,
                methodName,
                exception
            );

        internal static LogArguments Debug(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Debug,
                className,
                methodName,
                message,
                exception
            );
    }
}
