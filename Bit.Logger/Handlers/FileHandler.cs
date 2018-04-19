namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;
    using System.IO;
    using System.Reflection;
    using static Bit.Logger.Helpers.Tracer;

    internal class FileHandler : IHandler 
    {
        public Configuration Configuration { get; }

        private string _assemblyPath = default(string);
        
        private string AssemblyPath 
        { 
            get
            {
                if (_assemblyPath == null)
                {
                    var assemblyLocation = Assembly.GetEntryAssembly().Location;
                    _assemblyPath = Path.GetDirectoryName(assemblyLocation);
                }

                return _assemblyPath;
            }
        }

        public FileHandler(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();

        public void Write<TClass>(string message, Level level) where TClass : class =>
            ToFile<TClass>(level, message);

        public void Write(string message, Level level) =>
            ToFile(level, message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            ToFile<TClass>(level, exception: exception);

        public void Write(Exception exception, Level level) =>
            ToFile(level, exception: exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            ToFile<TClass>(level, message, exception);

        public void Write(string message, Exception exception, Level level) =>
            ToFile(level, message, exception);

        private void ToFile<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level >= level)
            {
                var logFile = File.Create(AssemblyPath);
                var logWriter = new StreamWriter(logFile);
                logWriter.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        typeof(TClass).FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
                logWriter.Dispose();
            }
        }

        private void ToFile(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level >= level)
            {
                var logFile = File.Create(AssemblyPath);
                var logWriter = new StreamWriter(logFile);
                logWriter.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        GetClass().FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
                logWriter.Dispose();
            }
        }
    }
}