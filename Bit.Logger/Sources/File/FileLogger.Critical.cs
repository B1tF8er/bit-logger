namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Critical(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Critical(message, className, methodName));

        public void Critical(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Critical(exception, className, methodName));

        public void Critical(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Critical(message, exception, className, methodName));
    }
}
