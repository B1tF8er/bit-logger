namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Debug(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Debug(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Debug(message, exception, className, methodName));
    }
}
