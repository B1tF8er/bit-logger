namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Debug(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Debug(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Debug(message, exception, className, methodName));
    }
}
