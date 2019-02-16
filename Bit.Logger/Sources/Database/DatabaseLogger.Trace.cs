namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Trace(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Trace(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Trace(message, exception, className, methodName));
    }
}
