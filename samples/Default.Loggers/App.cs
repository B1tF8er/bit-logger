using Bit.Logger.Contract;
using Microsoft.Extensions.Configuration;
using System;

namespace Default.Loggers
{
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

            logger.Trace(Message.Trace());
            logger.Debug(Message.Debug());
            logger.Verbose(Message.Verbose());
            logger.Information(Message.Information());
            logger.Warning(Message.Warning());
            logger.Error(Message.Error());
            logger.Critical(Message.Critical());
        }
    }
}
