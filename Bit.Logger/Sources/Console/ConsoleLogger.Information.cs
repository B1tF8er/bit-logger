namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToConsole(InformationMessage<TClass>(message));

        public void Information(string message) =>
            WriteToConsole(InformationMessage(message));

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(InformationException<TClass>(exception));

        public void Information(Exception exception) =>
            WriteToConsole(InformationException(exception));

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(InformationMessageAndException<TClass>(message, exception));

        public void Information(string message, Exception exception) =>
            WriteToConsole(InformationMessageAndException(message, exception));
    }
}