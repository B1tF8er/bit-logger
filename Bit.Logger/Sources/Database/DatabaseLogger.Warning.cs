namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Warning(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Warning(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Warning(message, exception, className, methodName));
    }
}
