namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Bit.Logger.Config;
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

        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            using (var logWriter = new StreamWriter(LogPath, true, Encoding.UTF8))
            {
                var log = string.Format(Configuration.FormatProvider, Configuration.Format,
                    logArguments.Level,
                    DateTime.Now,
                    logArguments.ClassName,
                    logArguments.MethodName,
                    logArguments.Message,
                    logArguments.Exception
                );

                logWriter.WriteLine(log);
            }
        }
    }
}