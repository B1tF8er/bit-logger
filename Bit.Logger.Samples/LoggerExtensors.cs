namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using static Constants;
    using static SourceConfiguration;

    internal static class LoggerExtensors
    {
        internal static ILoggerFactory ConfigureLoggerSources(this ILoggerFactory logger)
        {
            logger
                .AddConsoleSource(CreateConsoleConfiguration())
                .AddDatabaseSource(CreateDatabaseConfiguration())
                .AddFileSource(CreateFileConfiguration())
                .AddSource(CreateCustomConsoleSource())
                .AddSources(CreateCustomConsoleSources());

            return logger;
        }

        internal static ILoggerFactory SampleMessageLogs<TClass>(this ILoggerFactory logger) where TClass : class
        {
            logger.Trace<TClass>(TraceMessage);
            logger.Debug<TClass>(DebugMessage);
            logger.Verbose<TClass>(VerboseMessage);
            logger.Information<TClass>(InformationMessage);
            logger.Warning<TClass>(WarningMessage);
            logger.Error<TClass>(ErrorMessage);
            logger.Critical<TClass>(CriticalMessage);

            return logger;
        }

        internal static ILoggerFactory SampleMessageLogs(this ILoggerFactory logger)
        {
            logger.Trace(TraceMessage);
            logger.Debug(DebugMessage);
            logger.Verbose(VerboseMessage);
            logger.Information(InformationMessage);
            logger.Warning(WarningMessage);
            logger.Error(ErrorMessage);
            logger.Critical(CriticalMessage);

            return logger;
        }

        internal static ILoggerFactory SampleExceptionLogs<TClass>(this ILoggerFactory logger) where TClass : class
        {
            logger.Trace<TClass>(TraceException);
            logger.Debug<TClass>(DebugException);
            logger.Verbose<TClass>(VerboseException);
            logger.Information<TClass>(InformationException);
            logger.Warning<TClass>(WarningException);
            logger.Error<TClass>(ErrorException);
            logger.Critical<TClass>(CriticalException);

            return logger;
        }

        internal static ILoggerFactory SampleExceptionLogs(this ILoggerFactory logger)
        {
            logger.Trace(TraceException);
            logger.Debug(DebugException);
            logger.Verbose(VerboseException);
            logger.Information(InformationException);
            logger.Warning(WarningException);
            logger.Error(ErrorException);
            logger.Critical(CriticalException);

            return logger;
        }

        internal static ILoggerFactory SampleMessageAndExceptionLogs(this ILoggerFactory logger)
        {
            logger.Trace(TraceMessage, TraceException);
            logger.Debug(DebugMessage, DebugException);
            logger.Verbose(VerboseMessage, VerboseException);
            logger.Information(InformationMessage, InformationException);
            logger.Warning(WarningMessage, WarningException);
            logger.Error(ErrorMessage, ErrorException);
            logger.Critical(CriticalMessage, CriticalException);

            return logger;
        }

        internal static ILoggerFactory SampleMessageAndExceptionLogs<TClass>(this ILoggerFactory logger) where TClass : class
        {
            logger.Trace<TClass>(TraceMessage, TraceException);
            logger.Debug<TClass>(DebugMessage, DebugException);
            logger.Verbose<TClass>(VerboseMessage, VerboseException);
            logger.Information<TClass>(InformationMessage, InformationException);
            logger.Warning<TClass>(WarningMessage, WarningException);
            logger.Error<TClass>(ErrorMessage, ErrorException);
            logger.Critical<TClass>(CriticalMessage, CriticalException);

            return logger;
        }
    }
}