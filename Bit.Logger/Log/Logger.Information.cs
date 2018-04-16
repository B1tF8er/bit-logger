namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Information<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Information);

        public void Information(string message) =>
            Write(message, Level.Information);

        public void Information<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Information);

        public void Information(Exception exception) =>
            Write(exception, Level.Information);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Information);

        public void Information(string message, Exception exception) =>
            Write(message, exception, Level.Information);
    }
}