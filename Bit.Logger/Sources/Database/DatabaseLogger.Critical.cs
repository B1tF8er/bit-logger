namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger
    {
        public void Critical(string message, string className, string methodName) =>
            WriteToDatabase(CriticalMessage(message, className, methodName));

        public void Critical(Exception exception, string className, string methodName) =>
            WriteToDatabase(CriticalException(exception, className, methodName));

        public void Critical(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(CriticalMessageAndException(message, exception, className, methodName));
    }
}
