namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            WriteToConsole(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            WriteToConsole(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            WriteToConsole(Level.Trace, message, exception);
    }
}