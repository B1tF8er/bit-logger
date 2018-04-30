namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            WriteToDatabase(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            WriteToDatabase(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            WriteToDatabase(Level.Debug, message, exception);
    }
}