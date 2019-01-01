namespace Bit.Logger.Loggers.Console
{
    using Buffer;
    using Config;

    internal partial class ConsoleLogger : IConsoleLogger
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