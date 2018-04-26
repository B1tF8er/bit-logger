namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            ToConsole(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            ToConsole(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            ToConsole(Level.Warning, message, exception);
    }
}