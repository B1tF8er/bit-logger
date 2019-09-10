namespace Bit.Logger.Sources.Console
{
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleSource
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToConsole(WarningMessage(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToConsole(WarningException(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(WarningMessageAndException(message, exception, className, methodName));
    }
}
