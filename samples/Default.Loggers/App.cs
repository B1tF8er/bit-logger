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
            logger.Trace(Message.Trace().CreateException());
            logger.Debug(Message.Debug().CreateException());
            logger.Verbose(Message.Verbose().CreateException());
            logger.Information(Message.Information().CreateException());
            logger.Warning(Message.Warning().CreateException());
            logger.Error(Message.Error().CreateException());
            logger.Critical(Message.Critical().CreateException());
        }

        private void LogMessagesWithExceptions()
        {
            logger.Trace("Trace", Message.Trace().CreateException());
            logger.Debug("Debug", Message.Debug().CreateException());
            logger.Verbose("Verbose", Message.Verbose().CreateException());
            logger.Information("Information", Message.Information().CreateException());
            logger.Warning("Warning", Message.Warning().CreateException());
            logger.Error("Error", Message.Error().CreateException());
            logger.Critical("Critical", Message.Critical().CreateException());
        }
    }
}
