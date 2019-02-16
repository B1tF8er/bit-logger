namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToConsole(WarningMessage(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToConsole(WarningException(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(WarningMessageAndException(message, exception, className, methodName));
    }
}
