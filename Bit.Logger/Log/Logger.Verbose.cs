namespace Bit.Logger
{
    using System;

    public partial class Logger
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            Write<TClass>(message, Level.Verbose);

        public void Verbose(string message) =>
            Write(message, Level.Verbose);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            Write<TClass>(exception, Level.Verbose);

        public void Verbose(Exception exception) =>
            Write(exception, Level.Verbose);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            Write<TClass>(message, exception, Level.Verbose);

        public void Verbose(string message, Exception exception) =>
            Write(message, exception, Level.Verbose);
    }
}