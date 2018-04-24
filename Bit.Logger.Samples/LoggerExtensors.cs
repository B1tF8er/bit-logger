namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using static Bit.Logger.Samples.Constants;
    
    internal static class LoggerExtensors
    {
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
    }
}