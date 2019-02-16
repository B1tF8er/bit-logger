namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToDatabase(TraceMessage(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToDatabase(TraceException(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(TraceMessageAndException(message, exception, className, methodName));
    }
}
