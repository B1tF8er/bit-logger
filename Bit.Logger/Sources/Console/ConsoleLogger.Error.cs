namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Error(string message, string className, string methodName) =>
            WriteToConsole(ErrorMessage(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToConsole(ErrorException(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(ErrorMessageAndException(message, exception, className, methodName));
    }
}
