namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Trace<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Trace));

        public void Trace(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Trace));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Trace));

        public void Trace(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Trace));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Trace));

        public void Trace(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Trace));
    }
}