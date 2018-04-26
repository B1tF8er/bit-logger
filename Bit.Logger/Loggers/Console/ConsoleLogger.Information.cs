namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, message);

        public void Information(string message) =>
            ToConsole(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            ToConsole(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            ToConsole(Level.Information, message, exception);
    }
}