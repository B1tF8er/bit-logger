namespace Bit.Logger.Sources.File
{
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Information(string message, string className, string methodName) =>
            WriteToFile(InformationMessage(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToFile(InformationException(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToFile(InformationMessageAndException(message, exception, className, methodName));
    }
}
