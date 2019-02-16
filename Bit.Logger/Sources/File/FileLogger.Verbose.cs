namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Verbose(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToFile(Arguments.LogArguments.Verbose(message, exception, className, methodName));
    }
}
