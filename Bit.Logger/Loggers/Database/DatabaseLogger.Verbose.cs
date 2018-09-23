namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToDatabase(VerboseMessage<TClass>(message));

        public void Verbose(string message) =>
            WriteToDatabase(VerboseMessage(message));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(VerboseException<TClass>(exception));

        public void Verbose(Exception exception) =>
            WriteToDatabase(VerboseException(exception));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(VerboseMessageAndException<TClass>(message, exception));

        public void Verbose(string message, Exception exception) =>
            WriteToDatabase(VerboseMessageAndException(message, exception));
    }
}