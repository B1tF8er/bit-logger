namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            ToConsole(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            ToConsole(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            ToConsole(Level.Debug, message, exception);
    }
}