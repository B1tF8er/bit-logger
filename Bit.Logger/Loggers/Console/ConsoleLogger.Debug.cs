namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            WriteToConsole(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            WriteToConsole(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            WriteToConsole(Level.Debug, message, exception);
    }
}