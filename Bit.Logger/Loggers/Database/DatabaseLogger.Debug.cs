namespace Bit.Logger.Loggers.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToDatabase(DebugMessage<TClass>(message));

        public void Debug(string message) =>
            WriteToDatabase(DebugMessage(message));

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(DebugException<TClass>(exception));

        public void Debug(Exception exception) =>
            WriteToDatabase(DebugException(exception));

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(DebugMessageAndException<TClass>(message, exception));

        public void Debug(string message, Exception exception) =>
            WriteToDatabase(DebugMessageAndException(message, exception));
    }
}