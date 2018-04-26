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
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            WriteToFile(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            WriteToFile(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            WriteToFile(Level.Warning, message, exception);
    }
}