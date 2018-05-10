namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            WriteToConsole(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            WriteToConsole(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            WriteToConsole(Level.Warning, message, exception);
    }
}