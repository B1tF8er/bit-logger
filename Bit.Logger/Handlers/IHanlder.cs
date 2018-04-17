namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;

    public interface IHanlder
    {
        Configuration Configuration { get; } 

        void Write<TClass>(string message, Level level) where TClass : class;

        void Write(string message, Level level);
        
        void Write<TClass>(Exception exception, Level level) where TClass : class;

        void Write(Exception exception, Level level);

        void Write<TClass>(string message, Exception exception, Level level) where TClass : class;

        void Write(string message, Exception exception, Level level);
    }
}