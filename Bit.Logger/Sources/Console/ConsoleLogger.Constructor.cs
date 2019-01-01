namespace Bit.Logger.Sources.Console
{
    using Buffer;
    using Config;
    using Contract;

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