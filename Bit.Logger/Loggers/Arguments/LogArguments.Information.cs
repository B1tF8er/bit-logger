namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;

    internal partial struct LogArguments
    {
        internal static LogArguments InformationMessage(string message) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments InformationException(Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments InformationMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Critical,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments InformationMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments InformationException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Critical,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments InformationMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
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