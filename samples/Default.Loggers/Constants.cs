namespace Default.Loggers
{
    internal static class Constants
    {
        internal static class When
        {
            internal const string Trace = "Only when I would be 'tracing' the code and trying to find one part of a function specifically.";
            internal const string Debug = "Information that is diagnostically helpful to people more than just developers (IT, sysadmins, etc.)";
            internal const string Verbose = "Information that I want to have available but using more words than necessary.";
            internal const string Information = "Generally useful information to log (service start/stop, configuration assumptions, etc). Info I want to always have available but usually don't care about under normal circumstances. This is my out-of-the-box config level.";
            internal const string Warning = "Anything that can potentially cause application oddities, but for which I am automatically recovering. (Such as switching from a primary to backup server, retrying an operation, missing secondary data, etc.)";
            internal const string Error = "Any error which is fatal to the operation, but not the service or application (can't open a required file, missing data, etc.). These errors will force user (administrator, or direct user) intervention. These are usually reserved (in my apps) for incorrect connection strings, missing services, etc.";
            internal const string Critical = "Any error that is forcing a shutdown of the service or application to prevent data loss (or further data loss). I reserve these only for the most heinous errors and situations where there is guaranteed to have been data corruption or loss.";
        }
    }
}
