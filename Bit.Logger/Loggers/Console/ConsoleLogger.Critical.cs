namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            ToConsole(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            ToConsole(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            ToConsole(Level.Critical, message, exception);
    }
}