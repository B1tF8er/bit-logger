namespace Bit.Logger.Helpers
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using static Constants;

    internal static class LogPathResolver
    {
        private static string logDirectory = default(string);
        
        internal static string CurrentLogPath(DateTime logDate) =>
            Path.Combine(logDirectory, $"{logDate.ToString(LogNameFormat)}.log");
        
        static LogPathResolver()
        {
            GetLogDirectory();
            CreateLogDirectoryIfItDoesNotExist();
        }

        private static void GetLogDirectory()
        {
            var assemblyLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            logDirectory = Path.Combine(assemblyLocation, LogName);
        }

        private static void CreateLogDirectoryIfItDoesNotExist()
        {
            if (Directory.Exists(logDirectory))
                return;

            Directory.CreateDirectory(logDirectory);
        }
    }
}