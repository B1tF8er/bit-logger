namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, message);

        public void Information(string message) =>
            WriteToDatabase(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            WriteToDatabase(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            WriteToDatabase(Level.Information, message, exception);
    }
}