namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToFile(VerboseMessage(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToFile(VerboseException(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToFile(VerboseMessageAndException(message, exception, className, methodName));
    }
}
