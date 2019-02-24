namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Error(string message, string className, string methodName) =>
            WriteToFile(ErrorMessage(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToFile(ErrorException(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToFile(ErrorMessageAndException(message, exception, className, methodName));
    }
}
