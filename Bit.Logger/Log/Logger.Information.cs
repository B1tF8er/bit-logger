namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Information<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Information));

        public void Information(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Information));

        public void Information<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Information));

        public void Information(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Information));

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Information));

        public void Information(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Information));
    }
}