namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Information(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Information(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Information(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Information(message, exception, className, methodName));
    }
}
