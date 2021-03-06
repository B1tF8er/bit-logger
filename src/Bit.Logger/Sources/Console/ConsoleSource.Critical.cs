namespace Bit.Logger.Sources.Console
{
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleSource
    {
        public void Critical(string message, string className, string methodName) =>
            WriteToConsole(CriticalMessage(message, className, methodName));

        public void Critical(Exception exception, string className, string methodName) =>
            WriteToConsole(CriticalException(exception, className, methodName));

        public void Critical(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(CriticalMessageAndException(message, exception, className, methodName));
    }
}
