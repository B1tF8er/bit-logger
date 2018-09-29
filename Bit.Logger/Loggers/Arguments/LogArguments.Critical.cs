namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments CriticalMessage(string message) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments CriticalException(Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments CriticalMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments CriticalMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments CriticalException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments CriticalMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                message,
                exception
            );
    }
}