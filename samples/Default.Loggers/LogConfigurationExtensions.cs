namespace Default.Loggers
{
    using Bit.Logger.Config;
    using Bit.Logger.Enums;
    using System;
    using System.IO;
    using System.Linq;

    internal static class LogConfigurationExtensions
    {
        internal static Configuration CreateConsoleLogConfiguration() =>
            new Configuration
            {
                DateTypeFormat = DateType.DateTimeIso,
                ShowLevel = ShowLevel.Yes,
                Level = Level.Trace
            };

        internal static Configuration CreateDatabaseLogConfiguration() =>
                new Configuration
                {
                    DateTypeFormat = DateType.DateIso,
                    ShowLevel = ShowLevel.Yes,
                    Level = Level.Information,
                    DatabaseLogLocation = GetCustomLogLocation("Database")
                };

        internal static Configuration CreateFileLogConfiguration() =>
            new Configuration
            {
                DateTypeFormat = DateType.TimeIso,
                ShowLevel = ShowLevel.No,
                Level = Level.Critical,
                FileLogLocation = GetCustomLogLocation("File")
            };

        private static string GetCustomLogLocation(string logType) =>
            Path.Combine(Environment.GetLogicalDrives().FirstOrDefault(), "Logs", logType);
    }
}
