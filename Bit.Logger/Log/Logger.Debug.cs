namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Debug<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Debug);

        public void Debug(string message) =>
            Write(message, Level.Debug);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Debug);

        public void Debug(Exception exception) =>
            Write(exception, Level.Debug);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Debug);

        public void Debug(string message, Exception exception) =>
            Write(message, exception, Level.Debug);
    }
}