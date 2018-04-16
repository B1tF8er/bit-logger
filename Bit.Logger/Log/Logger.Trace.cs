namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Trace<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Trace);

        public void Trace(string message) =>
            Write(message, Level.Trace);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Trace);

        public void Trace(Exception exception) =>
            Write(exception, Level.Trace);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Trace);

        public void Trace(string message, Exception exception) =>
            Write(message, exception, Level.Trace);
    }
}