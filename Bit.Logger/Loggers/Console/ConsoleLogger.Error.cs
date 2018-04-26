namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Error<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Error, message);

        public void Error(string message) =>
            WriteToConsole(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            WriteToConsole(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            WriteToConsole(Level.Error, message, exception);
    }
}