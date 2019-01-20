namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToDatabase(CriticalMessage<TClass>(message));

        public void Critical(string message) =>
            WriteToDatabase(CriticalMessage(message));

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(CriticalException<TClass>(exception));

        public void Critical(Exception exception) =>
            WriteToDatabase(CriticalException(exception));

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(CriticalMessageAndException<TClass>(message, exception));

        public void Critical(string message, Exception exception) =>
            WriteToDatabase(CriticalMessageAndException(message, exception));
    }
}
