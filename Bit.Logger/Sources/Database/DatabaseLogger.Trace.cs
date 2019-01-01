namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger
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