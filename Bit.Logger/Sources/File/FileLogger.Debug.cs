namespace Bit.Logger.Loggers.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToFile(DebugMessage<TClass>(message));

        public void Debug(string message) =>
            WriteToFile(DebugMessage(message));

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToFile(DebugException<TClass>(exception));

        public void Debug(Exception exception) =>
            WriteToFile(DebugException(exception));

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(DebugMessageAndException<TClass>(message, exception));

        public void Debug(string message, Exception exception) =>
            WriteToFile(DebugMessageAndException(message, exception));
    }
}