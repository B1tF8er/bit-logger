namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments CriticalMessage(string message) =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments CriticalException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments CriticalMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments CriticalMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments CriticalException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments CriticalMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Critical,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}