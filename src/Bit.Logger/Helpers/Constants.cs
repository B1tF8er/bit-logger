namespace Bit.Logger.Helpers
{
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

        internal static class Caller
        {
            internal const string EmptyClassName = "NoClass";
            internal const string EmptyMethodName = "NoMethod";
        }
    }
}
