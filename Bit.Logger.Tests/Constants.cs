namespace Bit.Logger.Tests
{
    using System;

    internal static class Constants
    {
        internal const string TestMessage = "Test Message";
        internal static readonly Exception TestException = new Exception("Test exception");
        internal const string LevelToken = "level";
        internal const string DateTimeToken = "datetime";
        internal const string DateToken = "date";
        internal const string TimeToken = "time";
        internal const string CallerToken = "caller";
        internal const string ExceptionToken = "exception";
        internal const string MethodToken = "method";
        internal const string MessageToken = "message";
        internal const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        internal const string DateFormat = "yyyy-MM-dd";
        internal const string TimeFormat = "HH:mm:ss";
        internal const string LogName = "BitLogger";
        internal const string LogNameFormat = "yyyy_MM_dd_HH";
        internal const string ConnectionString = "Data Source=logging.db";
        internal const string AsKey = "yyyy-MM-dd HH:mm:ss.fff";
        internal const int LogsThreshold = 500;
    }
}