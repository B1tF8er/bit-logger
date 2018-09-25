namespace Bit.Logger.Loggers.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToFile(TraceMessage<TClass>(message));

        public void Trace(string message) =>
            WriteToFile(TraceMessage(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToFile(TraceException<TClass>(exception));

        public void Trace(Exception exception) =>
            WriteToFile(TraceException(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(TraceMessageAndException<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            WriteToFile(TraceMessageAndException(message, exception));
    }
}