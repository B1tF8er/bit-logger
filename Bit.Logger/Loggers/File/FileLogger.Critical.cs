namespace Bit.Logger.Loggers.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToFile(CriticalMessage<TClass>(message));

        public void Critical(string message) =>
            WriteToFile(CriticalMessage(message));

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToFile(CriticalException<TClass>(exception));

        public void Critical(Exception exception) =>
            WriteToFile(CriticalException(exception));

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(CriticalMessageAndException<TClass>(message, exception));

        public void Critical(string message, Exception exception) =>
            WriteToFile(CriticalMessageAndException(message, exception));
    }
}