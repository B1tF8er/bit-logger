namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Error(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Error(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Error(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Error(message, exception, className, methodName));
    }
}
