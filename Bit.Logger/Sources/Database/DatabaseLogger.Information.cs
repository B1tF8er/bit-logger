namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Information(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Information(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Information(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Information(message, exception, className, methodName));
    }
}
