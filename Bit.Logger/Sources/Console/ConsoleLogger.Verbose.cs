namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Verbose(string message, string className, string methodName) =>
            WriteToConsole(VerboseMessage(message, className, methodName));

        public void Verbose(Exception exception, string className, string methodName) =>
            WriteToConsole(VerboseException(exception, className, methodName));

        public void Verbose(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(VerboseMessageAndException(message, exception, className, methodName));
    }
}
