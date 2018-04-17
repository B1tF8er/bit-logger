namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Trace<TClass>(string message) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(message, Level.Trace));

        public void Trace(string message) =>
            _handlers.ForEach(handler => handler.Write(message, Level.Trace));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Trace));

        public void Trace(Exception exception) =>
            _handlers.ForEach(handler => handler.Write(exception, Level.Trace));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Trace));

        public void Trace(string message, Exception exception) =>
            _handlers.ForEach(handler => handler.Write(message, exception, Level.Trace));
    }
}