namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToConsole(WarningMessage<TClass>(message));

        public void Warning(string message) =>
            WriteToConsole(WarningMessage(message));

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(WarningException<TClass>(exception));

        public void Warning(Exception exception) =>
            WriteToConsole(WarningException(exception));

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(WarningMessageAndException<TClass>(message, exception));

        public void Warning(string message, Exception exception) =>
            WriteToConsole(WarningMessageAndException(message, exception));
    }
}