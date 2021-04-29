namespace Default.Loggers
{
    using Bit.Logger.Config;
    using Bit.Logger.Enums;
    using System;
    using System.IO;
    using System.Linq;

    internal static class LogConfigurationExtensions
    {
        internal static IConsoleConfiguration CreateConsoleLogConfiguration() =>
            new ConsoleConfiguration
            {
                DateTypeFormat = DateType.DateTimeIso,
                ShowLevel = ShowLevel.Yes,
                Level = Level.Trace
            };

        internal static IDatabaseConfiguration CreateDatabaseLogConfiguration() =>
            new DatabaseConfiguration
            {
                DateTypeFormat = DateType.DateIso,
                ShowLevel = ShowLevel.Yes,
                Level = Level.Information,
                DatabaseLogLocation = GetCustomLogLocation("Database")
            };

        internal static IFileConfiguration CreateFileLogConfiguration() =>
            new FileConfiguration
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
