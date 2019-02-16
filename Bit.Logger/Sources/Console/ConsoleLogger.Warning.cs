namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Warning(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Warning(message, className, methodName));

        public void Warning(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Warning(exception, className, methodName));

        public void Warning(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Warning(message, exception, className, methodName));
    }
}
