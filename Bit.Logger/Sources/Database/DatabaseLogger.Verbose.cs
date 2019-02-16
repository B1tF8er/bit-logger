namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;

    internal partial class DatabaseLogger
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Verbose(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(Arguments.LogArguments.Verbose(message, exception, className, methodName));
    }
}
