namespace Bit.Logger.Arguments
{
    using Enums;
    using System;
    using static Helpers.Tracer;
    
    internal partial struct LogArguments
    {
        internal static LogArguments VerboseMessage(string message) =>
            new LogArguments
            (
                Level.Verbose,
                GetClassName(),
                GetMethodName(),
                message
            );

        internal static LogArguments VerboseException(Exception exception) =>
            new LogArguments
            (
                Level.Verbose,
                GetClassName(),
                GetMethodName(),
                exception
            );

        internal static LogArguments VerboseMessageAndException(string message, Exception exception) =>
            new LogArguments
            (
                Level.Verbose,
                GetClassName(),
                GetMethodName(),
                message,
                exception
            );

        internal static LogArguments VerboseMessage<TClass>(string message) where TClass : class =>
            new LogArguments
            (
                Level.Verbose,
                typeof(TClass).FullName,
                GetMethodName(),
                message
            );

        internal static LogArguments VerboseException<TClass>(Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Verbose,
                typeof(TClass).FullName,
                GetMethodName(),
                exception
            );

        internal static LogArguments VerboseMessageAndException<TClass>(string message, Exception exception) where TClass : class =>
            new LogArguments
            (
                Level.Verbose,
                typeof(TClass).FullName,
                GetMethodName(),
                message,
                exception
            );
    }
}
