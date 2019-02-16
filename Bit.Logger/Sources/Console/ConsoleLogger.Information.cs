namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Information(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Information(message, className, methodName));

        public void Information(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Information(exception, className, methodName));

        public void Information(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Information(message, exception, className, methodName));
    }
}
