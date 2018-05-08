namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using System;

    internal class Sample
    {
        private readonly ILoggerFactory logger;

        public Sample(ILoggerFactory logger) =>
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

        internal void BasicTest()
        {
            logger.Trace("entry test");

            try
            {
                logger.Information("this message will be sent to a file, a database and the console");

                logger.Warning("this messages depending on the configuration level for each source will be shown or not");

                logger.Verbose("this could be seen by almost anyone depending on the configuration");
    
                logger.Debug("this is just for devs");

                logger.Critical("an exception will be thrown");

                throw new Exception("Fatal exception");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            logger.Trace("exit test");
        }

        internal void AllPossibleLevels()
        {
            logger
                .SampleMessageLogs<Sample>()
                .SampleMessageLogs()
                .SampleExceptionLogs<Sample>()
                .SampleExceptionLogs()
                .SampleMessageAndExceptionLogs<Sample>()
                .SampleMessageAndExceptionLogs();
        }
    }
}