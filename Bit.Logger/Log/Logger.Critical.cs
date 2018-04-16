namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Critical<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Critical);

        public void Critical(string message) =>
            Write(message, Level.Critical);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Critical);

        public void Critical(Exception exception) =>
            Write(exception, Level.Critical);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Critical);

        public void Critical(string message, Exception exception) =>
            Write(message, exception, Level.Critical);
    }
}