namespace Bit.Logger.Loggers.Arguments
{
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments DebugMessage(string message) =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments DebugException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments DebugMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments DebugMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments DebugException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments DebugMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Debug,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}