namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Trace(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Trace(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Trace(message, exception, className, methodName));
    }
}
