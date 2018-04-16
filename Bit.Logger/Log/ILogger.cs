namespace Bit.Logger
{
    using System;

    public interface ILogger
    {
        void Write<TClass>(string message, Level logLevel) where TClass : class;

        void Write(string message, Level logLevel);
        
        void Write<TClass>(Exception exception, Level logLevel) where TClass : class;

        void Write(Exception exception, Level logLevel);

        void Write<TClass>(string message, Exception exception, Level logLevel) where TClass : class;

        void Write(string message, Exception exception, Level logLevel);
    }
}