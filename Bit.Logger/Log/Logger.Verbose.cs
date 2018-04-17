namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Verbose));

        public void Verbose(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Verbose));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Verbose));

        public void Verbose(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Verbose));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Verbose));

        public void Verbose(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Verbose));
    }
}