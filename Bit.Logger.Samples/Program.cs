namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using System;
    
    class Program
    {
        static ILoggerFactory logger = new Logger();

        static void Main(string[] args)
        {
            var consoleConfiguration = new Configuration()
            {
                Level = Level.Trace,
                ShowLevel = false
            };

            var databaseConfiguration = new Configuration()
            {
                Level = Level.Critical,
                ShowTime = false,
            };

            var fileConfiguration = new Configuration()
            {
                Level = Level.Information,
                ShowDate = false
            };
            
            logger
                .AddConsoleSource(consoleConfiguration)
                .AddDatabaseSource(databaseConfiguration)
                .AddFileSource(fileConfiguration);

            SampleMessageLogs();
            SampleExceptionLogs();
            SampleMessageAndExceptionLogs();
        }

        static void SampleMessageLogs()
        {
            logger.Trace(Constants.TraceMessage);
            logger.Debug(Constants.DebugMessage);
            logger.Verbose(Constants.VerboseMessage);
            logger.Information(Constants.InformationMessage);
            logger.Warning(Constants.WarningMessage);
            logger.Error(Constants.ErrorMessage);
            logger.Critical(Constants.CriticalMessage);
        }
        
        static void SampleExceptionLogs()
        {
            logger.Trace(Constants.TraceException);
            logger.Debug(Constants.DebugException);
            logger.Verbose(Constants.VerboseException);
            logger.Information(Constants.InformationException);
            logger.Warning(Constants.WarningException);
            logger.Error(Constants.ErrorException);
            logger.Critical(Constants.CriticalException);
        }

        static void SampleMessageAndExceptionLogs()
        {
            logger.Trace(Constants.TraceMessage, Constants.TraceException);
            logger.Debug(Constants.DebugMessage, Constants.DebugException);
            logger.Verbose(Constants.VerboseMessage, Constants.VerboseException);
            logger.Information(Constants.InformationMessage, Constants.InformationException);
            logger.Warning(Constants.WarningMessage, Constants.WarningException);
            logger.Error(Constants.ErrorMessage, Constants.ErrorException);
            logger.Critical(Constants.CriticalMessage, Constants.CriticalException);
        }
    }
}
