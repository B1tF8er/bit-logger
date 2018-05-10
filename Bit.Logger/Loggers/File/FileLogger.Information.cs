namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Information, message);

        public void Information(string message) =>
            WriteToFile(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            WriteToFile(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            WriteToFile(Level.Information, message, exception);
    }
}