namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Error(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Error(message, className, methodName));

        public void Error(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Error(exception, className, methodName));

        public void Error(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Error(message, exception, className, methodName));
    }
}
