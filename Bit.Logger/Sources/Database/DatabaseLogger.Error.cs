namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Error(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Error(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Error(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Error(message, exception, className, methodName));
    }
}
