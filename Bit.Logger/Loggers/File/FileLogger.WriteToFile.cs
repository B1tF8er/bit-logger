namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Arguments;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class FileLogger : ILogger, IConfiguration
    {
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
        
        private void WriteToFile<TClass>(Level level, string message = default(string), Exception exception = default(Exception)) where TClass : class 
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = typeof(TClass).FullName,
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );

        private void WriteToFile(Level level, string message = default(string), Exception exception = default(Exception))
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = GetClassName(),
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );

        private void Write(LogArguments logArguments)
        {
            if (Configuration.Level <= logArguments.Level)
            {
                using (var logWriter = new StreamWriter(LogPath, true, Encoding.UTF8))
                {
                    logWriter.WriteLine(
                        string.Format(Configuration.FormatProvider, Configuration.Format,
                            logArguments.Level,
                            DateTime.Now,
                            logArguments.ClassName,
                            logArguments.MethodName,
                            logArguments.Message,
                            logArguments.Exception
                        )
                    );
                }
            }
        }
    }
}