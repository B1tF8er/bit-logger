namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseSource
    {
        public void Information(string message, string className, string methodName) =>
            WriteToDatabase(InformationMessage(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToDatabase(InformationException(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(InformationMessageAndException(message, exception, className, methodName));
    }
}
