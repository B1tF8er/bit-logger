namespace Bit.Logger.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments ErrorMessage(string message) =>
            new LogArguments
            (
                Level.Error,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments ErrorException(Exception exception) =>
            new LogArguments
            (
                Level.Error,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments ErrorMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Error,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments ErrorMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Error,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments ErrorException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Error,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments ErrorMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Error,
                typeof(TClass).FullName,
                GetMethodName(),
                message,
                exception
            );
    }
}