namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments TraceMessage(string message) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments TraceException(Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments TraceMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments TraceMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments TraceException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments TraceMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
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