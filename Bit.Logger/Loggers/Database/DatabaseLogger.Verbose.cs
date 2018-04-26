namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {    
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            WriteToDatabase(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            WriteToDatabase(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            WriteToDatabase(Level.Verbose, message, exception);
    }
}