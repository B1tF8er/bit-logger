namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToDatabase(TraceMessage<TClass>(message));

        public void Trace(string message) =>
            WriteToDatabase(TraceMessage(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(TraceException<TClass>(exception));

        public void Trace(Exception exception) =>
            WriteToDatabase(TraceException(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(TraceMessageAndException<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            WriteToDatabase(TraceMessageAndException(message, exception));
    }
}