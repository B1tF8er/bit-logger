namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Critical<TClass>(string message) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(message, Level.Critical));

        public void Critical(string message) =>
            _handlers.ForEach(handler => handler.Write(message, Level.Critical));

        public void Critical<TClass>(Exception exception) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Critical));

        public void Critical(Exception exception) =>
            _handlers.ForEach(handler => handler.Write(exception, Level.Critical));

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            _handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Critical));

        public void Critical(string message, Exception exception) =>
            _handlers.ForEach(handler => handler.Write(message, exception, Level.Critical));
    }
}