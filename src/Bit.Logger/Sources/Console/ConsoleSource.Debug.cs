namespace Bit.Logger.Sources.Console
{
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleSource
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToConsole(DebugMessage(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToConsole(DebugException(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(DebugMessageAndException(message, exception, className, methodName));
    }
}
