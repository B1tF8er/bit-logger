namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }
            
        public ConsoleLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();
    }
}