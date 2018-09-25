namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments ErrorMessage(string message) =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments ErrorException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments ErrorMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments ErrorMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments ErrorException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments ErrorMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Error,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}