namespace Bit.Logger.Sources.Console
{
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleSource
    {
        public void Information(string message, string className, string methodName) =>
            WriteToConsole(InformationMessage(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToConsole(InformationException(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(InformationMessageAndException(message, exception, className, methodName));
    }
}
