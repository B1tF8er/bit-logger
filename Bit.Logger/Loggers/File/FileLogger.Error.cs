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
        public void Error<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Error, message);

        public void Error(string message) =>
            WriteToFile(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            WriteToFile(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            WriteToFile(Level.Error, message, exception);
    }
}