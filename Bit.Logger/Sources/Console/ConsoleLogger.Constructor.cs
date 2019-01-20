namespace Bit.Logger.Sources.Console
{
    using Buffer;
    using Config;
    using Contract;

    internal partial class ConsoleLogger : IConsoleLogger
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<string> logBuffer;
            
        public ConsoleLogger(IConfiguration configuration, ILogBuffer<string> logBuffer)
        {
            this.configuration = configuration ?? new Configuration();
            this.logBuffer = logBuffer;
        }
    }
}
