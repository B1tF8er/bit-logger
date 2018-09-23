namespace Bit.Logger.Loggers.Arguments
{
    using static Bit.Logger.Helpers.Tracer;
    using System;

    internal partial class LogArguments
    {
        internal static LogArguments TraceMessage(string message) =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments TraceException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments TraceMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments TraceMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments TraceException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments TraceMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Trace,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}