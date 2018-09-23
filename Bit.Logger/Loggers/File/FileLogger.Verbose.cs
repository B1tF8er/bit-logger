namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToFile(VerboseMessage<TClass>(message));

        public void Verbose(string message) =>
            WriteToFile(VerboseMessage(message));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToFile(VerboseException<TClass>(exception));

        public void Verbose(Exception exception) =>
            WriteToFile(VerboseException(exception));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(VerboseMessageAndException<TClass>(message, exception));

        public void Verbose(string message, Exception exception) =>
            WriteToFile(VerboseMessageAndException(message, exception));
    }
}