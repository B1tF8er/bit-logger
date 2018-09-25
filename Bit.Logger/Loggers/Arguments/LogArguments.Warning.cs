namespace Bit.Logger.Loggers.Arguments
{
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments WarningMessage(string message) =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments WarningException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments WarningMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments WarningMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments WarningException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments WarningMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Warning,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}