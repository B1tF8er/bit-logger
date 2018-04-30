namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            WriteToFile(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            WriteToFile(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            WriteToFile(Level.Critical, message, exception);
    }
}