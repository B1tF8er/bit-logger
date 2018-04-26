namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, message);

        public void Error(string message) =>
            ToDatabase(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            ToDatabase(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            ToDatabase(Level.Error, message, exception);
    }
}