namespace Default.Loggers
{
    using Bit.Logger.Contract;
    using Microsoft.Extensions.Configuration;
    using System;
    using static ExceptionExtensions;

    public class App
    {
        private readonly ILogger logger;
        private readonly IConfiguration configuration;

        public App(ILogger logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }

        public void Run()
        {
            var enabled = Convert.ToBoolean(configuration.GetSection("Log:Enabled").Value);

            if (!enabled)
                return;

            LogMessages();
            LogExceptions();
            LogMessagesWithExceptions();
        }

        private void LogMessages()
        {
            logger.Trace(Message.Trace());
            logger.Debug(Message.Debug());
            logger.Verbose(Message.Verbose());
            logger.Information(Message.Information());
            logger.Warning(Message.Warning());
            logger.Error(Message.Error());
            logger.Critical(Message.Critical());
        }

        private void LogExceptions()
        {
            logger.Trace(CreateException(Message.Trace()));
            logger.Debug(CreateException(Message.Debug()));
            logger.Verbose(CreateException(Message.Verbose()));
            logger.Information(CreateException(Message.Information()));
            logger.Warning(CreateException(Message.Warning()));
            logger.Error(CreateException(Message.Error()));
            logger.Critical(CreateException(Message.Critical()));
        }

        private void LogMessagesWithExceptions()
        {
            logger.Trace("Trace", CreateException(Message.Trace()));
            logger.Debug("Debug", CreateException(Message.Debug()));
            logger.Verbose("Verbose", CreateException(Message.Verbose()));
            logger.Information("Information", CreateException(Message.Information()));
            logger.Warning("Warning", CreateException(Message.Warning()));
            logger.Error("Error", CreateException(Message.Error()));
            logger.Critical("Critical", CreateException(Message.Critical()));
        }
    }
}
