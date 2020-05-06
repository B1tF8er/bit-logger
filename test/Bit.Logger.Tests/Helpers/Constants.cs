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
            private static readonly string logicalDrive = Environment.GetLogicalDrives().First();

            internal static readonly Configuration Console = new Configuration
            {
                Level = Level.None
            };

            internal static readonly Configuration Database = new Configuration
            {
                Level = Level.None,
                DatabaseLogLocation = Path.Combine(logicalDrive, "Logs", "Database")
            };

            internal static readonly Configuration File = new Configuration
            {
                Level = Level.None,
                DatabaseLogLocation = Path.Combine(logicalDrive, "Logs", "File")
            };
        }
    }
}
