namespace Bit.Logger.Tests
{
    using Bit.Logger.Config;
    using System;

    public class CustomLogger : ILogger
    {
        public Configuration Configuration { get; }

        public void Write<TClass>(string message, Level level) where TClass : class =>
            Console.WriteLine(message);
        
        public void Write(string message, Level level) =>
            Console.WriteLine(message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            Console.WriteLine(exception);

        public void Write(Exception exception, Level level) =>
            Console.WriteLine(exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class
        {
            Console.WriteLine(message);
            Console.WriteLine(exception);
        }

        public void Write(string message, Exception exception, Level level)
        {
            Console.WriteLine(message);
            Console.WriteLine(exception);
        }
    }
}