namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, message);

        public void Information(string message) =>
            ToDatabase(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            ToDatabase(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            ToDatabase(Level.Information, message, exception);
    }
}