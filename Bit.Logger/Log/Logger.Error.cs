namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Error<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Error);

        public void Error(string message) =>
            Write(message, Level.Error);

        public void Error<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Error);

        public void Error(Exception exception) =>
            Write(exception, Level.Error);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Error);

        public void Error(string message, Exception exception) =>
            Write(message, exception, Level.Error);
    }
}