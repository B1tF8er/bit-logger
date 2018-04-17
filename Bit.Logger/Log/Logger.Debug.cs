namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Debug<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Debug));

        public void Debug(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Debug));

        public void Debug<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Debug));

        public void Debug(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Debug));

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Debug));

        public void Debug(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Debug));
    }
}