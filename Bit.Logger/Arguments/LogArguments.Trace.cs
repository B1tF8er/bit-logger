namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments Trace(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Trace,
                className,
                methodName,
                message
            );

        internal static LogArguments Trace(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Trace,
                className,
                methodName,
                exception
            );

        internal static LogArguments Trace(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Trace,
                className,
                methodName,
                message,
                exception
            );
    }
}
