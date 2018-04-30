namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, message);

        public void Error(string message) =>
            WriteToDatabase(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            WriteToDatabase(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            WriteToDatabase(Level.Error, message, exception);
    }
}