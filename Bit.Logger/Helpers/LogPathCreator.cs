namespace Bit.Logger.Helpers
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal static class LogPathCreator
    {
        private const string logName = "BitLogger";

        private const string dateFormat = "yyyy_MM_dd_HH";

        private static string lastHour = default(string);

        private static string logDirectory = default(string);

        private static string logPath = default(string);

        internal static string LogPath => GetLogPath();

        private static string GetLogPath()
        {
            var currentHour = DateTime.Now.ToString(dateFormat);
            var hourChanged = currentHour != lastHour;

            if (logPath is null || hourChanged)
            {
                logPath = Path.Combine(logDirectory, $"{currentHour}.log");
                lastHour = currentHour;
            }

            return logPath;
        }

        static LogPathCreator()
        {
            GetLogDirectory();
            CreateLogDirectory();
        }

        private static void GetLogDirectory()
        {
            var assemblyLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            logDirectory = Path.Combine(assemblyLocation, logName);
        }

        private static void CreateLogDirectory()
        {
            if (Directory.Exists(logDirectory))
                return;

            Directory.CreateDirectory(logDirectory);
        }
    }
}