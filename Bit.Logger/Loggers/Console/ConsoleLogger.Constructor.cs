namespace Bit.Logger.Loggers.Console
{
    using Config;
    using LogBuffer;

    internal partial class ConsoleLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        public Configuration Configuration { get; }

        public LogBuffer<string> LogBuffer { get; }
            
        public ConsoleLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            LogBuffer = new LogBuffer<string>();
        }
    }
}