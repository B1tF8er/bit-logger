namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Warning<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Warning);

        public void Warning(string message) =>
            Write(message, Level.Warning);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Warning);

        public void Warning(Exception exception) =>
            Write(exception, Level.Warning);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Warning);

        public void Warning(string message, Exception exception) =>
            Write(message, exception, Level.Warning);
    }
}