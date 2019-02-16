namespace Bit.Logger.Arguments
{
    using Enums;
    using System;
    
    internal partial struct LogArguments
    {
        internal static LogArguments Verbose(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Verbose,
                className,
                methodName,
                message
            );

        internal static LogArguments Verbose(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Verbose,
                className,
                methodName,
                exception
            );

        internal static LogArguments Verbose(string message, Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Verbose,
                className,
                methodName,
                message,
                exception
            );
    }
}
