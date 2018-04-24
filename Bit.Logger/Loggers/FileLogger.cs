namespace Bit.Logger.Loggers
{
    using Bit.Logger.Config;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using static Bit.Logger.Helpers.Tracer;

    internal class FileLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        private const string logName = "BitLogger";

        private const string dateFormat = "yyyy_MM_dd_HH";

        private string lastHour = default(string);

        private string logPath = default(string);

        private string LogPath
        {
            get
            {
                var currentHour = DateTime.Now.ToString(dateFormat);

                if (logPath == null || currentHour != lastHour)
                {
                    var assemblyLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                    var logLocation = Path.Combine(assemblyLocation, logName);

                    logPath = $"{logLocation}\\{currentHour}.log";
                    lastHour = currentHour;

                    if (!Directory.Exists(logLocation))
                        Directory.CreateDirectory(logLocation);
                }

                return logPath;
            }
        }

        public FileLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();

        public void Trace<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Trace, message);

        public void Trace(string message) =>
            ToFile(Level.Trace, message);

        public void Trace<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Trace, exception: exception);

        public void Trace(Exception exception) =>
            ToFile(Level.Trace, exception: exception);

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Trace, message, exception);

        public void Trace(string message, Exception exception) =>
            ToFile(Level.Trace, message, exception);
        
        public void Debug<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Debug, message);

        public void Debug(string message) =>
            ToFile(Level.Debug, message);

        public void Debug<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Debug, exception: exception);

        public void Debug(Exception exception) =>
            ToFile(Level.Debug, exception: exception);

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Debug, message, exception);

        public void Debug(string message, Exception exception) =>
            ToFile(Level.Debug, message, exception);
            
        public void Verbose<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Verbose, message);

        public void Verbose(string message) =>
            ToFile(Level.Verbose, message);

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Verbose, exception: exception);

        public void Verbose(Exception exception) =>
            ToFile(Level.Verbose, exception: exception);

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Verbose, message, exception);

        public void Verbose(string message, Exception exception) =>
            ToFile(Level.Verbose, message, exception);

        public void Information<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Information, message);

        public void Information(string message) =>
            ToFile(Level.Information, message);

        public void Information<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Information, exception: exception);

        public void Information(Exception exception) =>
            ToFile(Level.Information, exception: exception);

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Information, message, exception);

        public void Information(string message, Exception exception) =>
            ToFile(Level.Information, message, exception);

        public void Warning<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Warning, message);

        public void Warning(string message) =>
            ToFile(Level.Warning, message);

        public void Warning<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Warning, exception: exception);

        public void Warning(Exception exception) =>
            ToFile(Level.Warning, exception: exception);

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Warning, message, exception);

        public void Warning(string message, Exception exception) =>
            ToFile(Level.Warning, message, exception);

        public void Error<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Error, message);

        public void Error(string message) =>
            ToFile(Level.Error, message);

        public void Error<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Error, exception: exception);

        public void Error(Exception exception) =>
            ToFile(Level.Error, exception: exception);

        public void Error<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Error, message, exception);

        public void Error(string message, Exception exception) =>
            ToFile(Level.Error, message, exception);
            
        public void Critical<TClass>(string message) where TClass : class =>
            ToFile<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            ToFile(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            ToFile(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            ToFile<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            ToFile(Level.Critical, message, exception);

        private void ToFile<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level <= level)
            {
                using (var logWriter = new StreamWriter(LogPath, true, Encoding.UTF8))
                {
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
                }
            }
        }

        private void ToFile(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level <= level)
            {
                using (var logWriter = new StreamWriter(LogPath, true, Encoding.UTF8))
                {
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
                }
            }
        }
    }
}