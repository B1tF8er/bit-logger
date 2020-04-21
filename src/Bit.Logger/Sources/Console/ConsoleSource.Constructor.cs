namespace Bit.Logger.Sources.Console
{
    using Buffer;
    using Config;
    using Contract;

    internal partial class ConsoleSource : IConsoleSource
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<string> logBuffer;
            
        public ConsoleSource(IConfiguration configuration, ILogBuffer<string> logBuffer)
        {
            this.configuration = configuration;
            this.logBuffer = logBuffer;
        }
    }
}
