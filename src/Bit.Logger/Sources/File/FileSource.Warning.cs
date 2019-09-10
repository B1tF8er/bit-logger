namespace Bit.Logger.Sources.File
{
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToFile(WarningMessage(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToFile(WarningException(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToFile(WarningMessageAndException(message, exception, className, methodName));
    }
}
