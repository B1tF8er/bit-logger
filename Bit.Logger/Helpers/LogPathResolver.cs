namespace Bit.Logger.Helpers
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal static class LogPathResolver
    {
        private const string logName = "BitLogger";

        private const string dateFormat = "yyyy_MM_dd_HH";

        private static string lastHour = default(string);

        private static string logDirectory = default(string);

        private static string currentLogPath = default(string);

        internal static string CurrentLogPath => GetCurrentLogPath();

        private static string GetCurrentLogPath()
        {
            var currentHour = DateTime.Now.ToString(dateFormat);
            var hourChanged = currentHour != lastHour;

            if (currentLogPath is null || hourChanged)
            {
                currentLogPath = Path.Combine(logDirectory, $"{currentHour}.log");
                lastHour = currentHour;
            }

            return currentLogPath;
        }

        static LogPathResolver()
        {
            GetLogDirectory();
            CreateLogDirectoryIfItDoesNotExist();
        }

        private static void GetLogDirectory()
        {
            var assemblyLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            logDirectory = Path.Combine(assemblyLocation, logName);
        }

        private static void CreateLogDirectoryIfItDoesNotExist()
        {
            if (Directory.Exists(logDirectory))
                return;

            Directory.CreateDirectory(logDirectory);
        }
    }
}