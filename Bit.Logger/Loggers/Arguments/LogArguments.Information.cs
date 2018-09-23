namespace Bit.Logger.Loggers.Arguments
{
    using static Bit.Logger.Helpers.Tracer;
    using System;

    internal partial class LogArguments
    {
        internal static LogArguments InformationMessage(string message) =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments InformationException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments InformationMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments InformationMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments InformationException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments InformationMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Information,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}