namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }
            
        public ConsoleLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();
    }
}