namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseSource
    {
        public void Error(string message, string className, string methodName) =>
            WriteToDatabase(ErrorMessage(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToDatabase(ErrorException(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(ErrorMessageAndException(message, exception, className, methodName));
    }
}
