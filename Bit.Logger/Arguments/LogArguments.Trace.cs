namespace Bit.Logger.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments TraceMessage(string message) =>
            new LogArguments
            (
                Level.Trace,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments TraceException(Exception exception) =>
            new LogArguments
            (
                Level.Trace,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments TraceMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Trace,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments TraceMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Trace,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments TraceException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Trace,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments TraceMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Trace,
                typeof(TClass).FullName,
                GetMethodName(),
                message,
                exception
            );
    }
}