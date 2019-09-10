namespace Bit.Logger.Sources.Database
{
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseSource
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToDatabase(WarningMessage(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToDatabase(WarningException(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(WarningMessageAndException(message, exception, className, methodName));
    }
}
