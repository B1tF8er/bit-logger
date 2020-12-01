namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments VerboseMessage(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Verbose,
                className,
                methodName,
                message
            );

        internal static LogArguments VerboseException(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Verbose,
                className,
                methodName,
                exception
            );

        internal static LogArguments VerboseMessageAndException(string message, Exception exception, string className, string methodName) =>
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
