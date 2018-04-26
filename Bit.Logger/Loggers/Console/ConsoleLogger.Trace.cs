namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            ToConsole(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            ToConsole(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            ToConsole(Level.Trace, message, exception);
    }
}