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
        public void Trace<TClass>(string message) where TClass : class =>
            WriteToFile<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            WriteToFile(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            WriteToFile(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            WriteToFile(Level.Trace, message, exception);
    }
}