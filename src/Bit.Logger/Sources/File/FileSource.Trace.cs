namespace Bit.Logger.Sources.File
{
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToFile(TraceMessage(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToFile(TraceException(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToFile(TraceMessageAndException(message, exception, className, methodName));
    }
}
