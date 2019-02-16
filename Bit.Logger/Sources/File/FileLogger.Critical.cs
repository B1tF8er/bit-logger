namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Critical(string message, string className, string methodName) =>
            WriteToFile(CriticalMessage(message, className, methodName));

        public void Critical(Exception exception, string className, string methodName) =>
            WriteToFile(CriticalException(exception, className, methodName));

        public void Critical(string message, Exception exception, string className, string methodName) =>
            WriteToFile(CriticalMessageAndException(message, exception, className, methodName));
    }
}
