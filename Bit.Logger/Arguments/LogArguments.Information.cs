namespace Bit.Logger.Arguments
{
    using Enums;
    using System;

    internal partial struct LogArguments
    {
        internal static LogArguments InformationMessage(string message, string className, string methodName) =>
            new LogArguments
            (
                Level.Information,
                className,
                methodName,
                message
            );

        internal static LogArguments InformationException(Exception exception, string className, string methodName) =>
            new LogArguments
            (
                Level.Information,
                className,
                methodName,
                exception
            );

        internal static LogArguments InformationMessageAndException(string message, Exception exception, string className, string methodName) =>
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
