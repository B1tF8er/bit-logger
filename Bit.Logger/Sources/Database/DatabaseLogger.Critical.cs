namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Critical(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Critical(message, className, methodName));

        public void Critical(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Critical(exception, className, methodName));

        public void Critical(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Critical(message, exception, className, methodName));
    }
}
