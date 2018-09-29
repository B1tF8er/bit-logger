namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments DebugMessage(string message) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments DebugException(Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments DebugMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments DebugMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments DebugException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments DebugMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
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