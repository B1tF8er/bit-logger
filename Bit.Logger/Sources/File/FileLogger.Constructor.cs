namespace Bit.Logger.Sources.File
{
    using Buffer;
    using Config;
    using Contract;

    internal partial class FileLogger : IFileLogger
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<string> logBuffer;

        public FileLogger(IConfiguration configuration, ILogBuffer<string> logBuffer)
        {
            this.configuration = configuration ?? new Configuration();
            this.logBuffer = logBuffer;
        }
    }
}