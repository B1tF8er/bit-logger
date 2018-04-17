namespace Bit.Logger
{
    using System;

    public partial class Logger : ILogger
    {
        public void Error<TClass>(string message) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, Level.Error));

        public void Error(string message) =>
            Handlers.ForEach(handler => handler.Write(message, Level.Error));

        public void Error<TClass>(Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(exception, Level.Error));

        public void Error(Exception exception) =>
            Handlers.ForEach(handler => handler.Write(exception, Level.Error));

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            Handlers.ForEach(handler => handler.Write<TClass>(message, exception, Level.Error));

        public void Error(string message, Exception exception) =>
            Handlers.ForEach(handler => handler.Write(message, exception, Level.Error));
    }
}