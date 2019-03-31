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

            logger.Trace("Zeo");
            logger.Debug("One");
            logger.Verbose("Two");
            logger.Information("Three");
            logger.Warning("Four");
            logger.Error("Five");
            logger.Critical("Six");
        }
    }
}