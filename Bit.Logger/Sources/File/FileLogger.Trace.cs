namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Trace(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Trace(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Trace(message, exception, className, methodName));
    }
}
