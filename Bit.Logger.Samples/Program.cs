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
                Level = Level.Critical
            };

            var databaseConfiguration = new Configuration()
            {
                Level = Level.Critical
            };

            var fileConfiguration = new Configuration()
            {
                Level = Level.Critical
            };
            
            logger
                .AddConsoleSource(consoleConfiguration)
                .AddDatabaseSource(databaseConfiguration)
                .AddFileSource(fileConfiguration);

            SampleLogging();
        }

        static void SampleLogging()
        {
            logger.Trace("test");
            logger.Debug("test");
            logger.Verbose("test");
            logger.Information("test");
            logger.Warning("test");
            logger.Error("test");
            logger.Critical("test");
        }
    }
}
