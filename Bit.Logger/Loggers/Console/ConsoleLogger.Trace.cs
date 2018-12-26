namespace Bit.Logger.Loggers.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToConsole(TraceMessage<TClass>(message));

        public void Trace(string message) =>
            WriteToConsole(TraceMessage(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(TraceException<TClass>(exception));

        public void Trace(Exception exception) =>
            WriteToConsole(TraceException(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(TraceMessageAndException<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            WriteToConsole(TraceMessageAndException(message, exception));
    }
}