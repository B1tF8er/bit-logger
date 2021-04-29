namespace Bit.Logger.Tests
{
    using Config;
    using Enums;
    using System;
    using System.IO;
    using System.Linq;

    internal static class Constants
    {
        internal const string TestMessage = "Test Message";
        internal static readonly Exception TestException = new Exception("Test exception");
        internal const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        internal const string DateFormat = "yyyy-MM-dd";
        internal const string TimeFormat = "HH:mm:ss";

        internal static class Config
        {
            private static readonly string logicalDrive = Environment.GetLogicalDrives().FirstOrDefault();

            internal static readonly IConsoleConfiguration Console = new ConsoleConfiguration
            {
                Level = Level.None
            };

            internal static readonly IDatabaseConfiguration Database = new DatabaseConfiguration
            {
                Level = Level.None,
                DatabaseLogLocation = Path.Combine(logicalDrive, "Logs", "Database")
            };

            internal static readonly IFileConfiguration File = new FileConfiguration
            {
                Level = Level.None,
                FileLogLocation = Path.Combine(logicalDrive, "Logs", "File")
            };
        }
    }
}
