namespace Bit.Logger.Sources.Database
{
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseSource
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToDatabase(VerboseMessage(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToDatabase(VerboseException(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(VerboseMessageAndException(message, exception, className, methodName));
    }
}
