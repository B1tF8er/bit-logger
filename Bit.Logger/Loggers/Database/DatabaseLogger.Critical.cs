namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            WriteToDatabase(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            WriteToDatabase(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            WriteToDatabase(Level.Critical, message, exception);
    }
}