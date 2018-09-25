namespace Bit.Logger.Loggers.Arguments
{
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class LogArguments
    {
        internal static LogArguments VerboseMessage(string message) =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments VerboseException(Exception exception) =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments VerboseMessageAndException(string message, Exception exception) =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = GetClassName(),
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };

        internal static LogArguments VerboseMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message
            };

        internal static LogArguments VerboseException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Exception = exception
            };

        internal static LogArguments VerboseMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            {
                Level = Level.Verbose,
                ClassName = typeof(TClass).FullName,
                MethodName = GetMethodName(),
                Message = message,
                Exception = exception
            };
    }
}