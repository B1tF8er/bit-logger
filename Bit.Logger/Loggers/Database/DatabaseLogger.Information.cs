namespace Bit.Logger.Loggers.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToDatabase(InformationMessage<TClass>(message));

        public void Information(string message) =>
            WriteToDatabase(InformationMessage(message));

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(InformationException<TClass>(exception));

        public void Information(Exception exception) =>
            WriteToDatabase(InformationException(exception));

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(InformationMessageAndException<TClass>(message, exception));

        public void Information(string message, Exception exception) =>
            WriteToDatabase(InformationMessageAndException(message, exception));
    }
}