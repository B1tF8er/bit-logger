namespace Bit.Logger.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal static class Constants
    {
        internal static class Format
        {
            internal const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            internal const string DateFormat = "yyyy-MM-dd";
            internal const string TimeFormat = "HH:mm:ss";
        }

        internal static class PathResolver
        {
            internal const string LogName = "BitLogger";
            internal const string LogNameFormat = "yyyy_MM_dd_HH";
        }

        internal static class Buffer
        {
            internal const string AsKey = "yyyy-MM-dd HH:mm:ss.fff";
            internal const int LogsThreshold = 0;
        }

        internal static class Sqlite
        {
            private const string ParentDirectory = "..";
            private const string DatabaseName = "logging.db";
            private static readonly string[] Paths = new List<string> 
            { 
                AppDomain.CurrentDomain.BaseDirectory,
                ParentDirectory,
                ParentDirectory,
                ParentDirectory,
                DatabaseName
            }.ToArray();
            internal static readonly string ConnectionString = $"Data Source={Path.GetFullPath(Path.Combine(Paths))}";
        }

        internal static class Caller
        {
            internal const string EmptyClassName = "";
            internal const string EmptyMethodName = "";
        }
    }
}
