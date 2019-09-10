namespace Bit.Logger.Helpers
{
    using System;
    using System.IO;
    using static Constants.PathResolver;

    internal static class LogPathResolver
    {
        private static readonly string logDirectory;
        
        internal static string CurrentLogPath(DateTime logDate) =>
            Path.Combine(logDirectory, $"{logDate.ToString(LogNameFormat)}.log");
        
        static LogPathResolver()
        {
            logDirectory = GetLogDirectory();
            CreateLogDirectoryIfItDoesNotExist();
        }

        private static string GetLogDirectory()
        {
            var assemblyLocation = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            return Path.Combine(assemblyLocation, LogName);
        }

        private static void CreateLogDirectoryIfItDoesNotExist()
        {
            if (!Directory.Exists(logDirectory))
                Directory.CreateDirectory(logDirectory);
        }
    }
}
