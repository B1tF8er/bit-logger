namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToDatabase(ErrorMessage<TClass>(message));

        public void Error(string message) =>
            WriteToDatabase(ErrorMessage(message));

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(ErrorException<TClass>(exception));

        public void Error(Exception exception) =>
            WriteToDatabase(ErrorException(exception));

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(ErrorMessageAndException<TClass>(message, exception));

        public void Error(string message, Exception exception) =>
            WriteToDatabase(ErrorMessageAndException(message, exception));
    }
}