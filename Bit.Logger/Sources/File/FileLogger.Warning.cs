namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Warning(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Warning(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Warning(message, exception, className, methodName));
    }
}
