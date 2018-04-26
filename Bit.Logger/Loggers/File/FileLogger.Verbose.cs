namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            WriteToFile(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            WriteToFile(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            WriteToFile(Level.Verbose, message, exception);
    }
}