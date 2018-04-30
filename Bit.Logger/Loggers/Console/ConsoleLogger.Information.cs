namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, message);

        public void Information(string message) =>
            WriteToConsole(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            WriteToConsole(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            WriteToConsole(Level.Information, message, exception);
    }
}