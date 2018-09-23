namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToFile(ErrorMessage<TClass>(message));

        public void Error(string message) =>
            WriteToFile(ErrorMessage(message));

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToFile(ErrorException<TClass>(exception));

        public void Error(Exception exception) =>
            WriteToFile(ErrorException(exception));

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(ErrorMessageAndException<TClass>(message, exception));

        public void Error(string message, Exception exception) =>
            WriteToFile(ErrorMessageAndException(message, exception));
    }
}