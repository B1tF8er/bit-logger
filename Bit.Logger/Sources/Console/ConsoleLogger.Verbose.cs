namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;

    internal partial class ConsoleLogger
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Verbose(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Verbose(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(Arguments.LogArguments.Verbose(message, exception, className, methodName));
    }
}
