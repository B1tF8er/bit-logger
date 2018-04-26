namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            WriteToDatabase(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            WriteToDatabase(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            WriteToDatabase(Level.Warning, message, exception);
    }
}