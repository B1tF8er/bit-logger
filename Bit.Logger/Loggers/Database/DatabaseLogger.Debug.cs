namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            ToDatabase(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            ToDatabase(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            ToDatabase(Level.Debug, message, exception);
    }
}