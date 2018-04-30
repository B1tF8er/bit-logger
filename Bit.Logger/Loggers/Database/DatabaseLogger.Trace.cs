namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using System;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            WriteToDatabase(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            WriteToDatabase(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            WriteToDatabase(Level.Trace, message, exception);
    }
}