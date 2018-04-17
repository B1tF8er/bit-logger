namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Warning<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Warning));

        public void Warning(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Warning));

        public void Warning<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Warning));

        public void Warning(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Warning));

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Warning));

        public void Warning(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Warning));
    }
}