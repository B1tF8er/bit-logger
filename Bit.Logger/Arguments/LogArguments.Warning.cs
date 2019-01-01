namespace Bit.Logger.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments WarningMessage(string message) =>
            new LogArguments
            (
                Level.Warning,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments WarningException(Exception exception) =>
            new LogArguments
            (
                Level.Warning,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments WarningMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Warning,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments WarningMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Warning,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments WarningException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Warning,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments WarningMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Warning,
                typeof(TClass).FullName,
                GetMethodName(),
                message,
                exception
            );
    }
}