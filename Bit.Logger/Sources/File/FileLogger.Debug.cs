namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Debug(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Debug(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Debug(message, exception, className, methodName));
    }
}
