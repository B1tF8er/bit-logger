namespace Bit.Logger.Loggers.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToConsole(CriticalMessage<TClass>(message));

        public void Critical(string message) =>
            WriteToConsole(CriticalMessage(message));

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(CriticalException<TClass>(exception));

        public void Critical(Exception exception) =>
            WriteToConsole(CriticalException(exception));

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(CriticalMessageAndException<TClass>(message, exception));

        public void Critical(string message, Exception exception) =>
            WriteToConsole(CriticalMessageAndException(message, exception));
    }
}