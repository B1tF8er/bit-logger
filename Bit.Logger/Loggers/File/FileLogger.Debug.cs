namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            WriteToFile(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            WriteToFile(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            WriteToFile(Level.Debug, message, exception);
    }
}