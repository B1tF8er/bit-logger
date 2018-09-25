namespace Bit.Logger.Loggers.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToConsole(ErrorMessage<TClass>(message));

        public void Error(string message) =>
            WriteToConsole(ErrorMessage(message));

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(ErrorException<TClass>(exception));

        public void Error(Exception exception) =>
            WriteToConsole(ErrorException(exception));

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(ErrorMessageAndException<TClass>(message, exception));

        public void Error(string message, Exception exception) =>
            WriteToConsole(ErrorMessageAndException(message, exception));
    }
}