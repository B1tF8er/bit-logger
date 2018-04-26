namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            WriteToConsole(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            WriteToConsole(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            WriteToConsole(Level.Verbose, message, exception);
    }
}