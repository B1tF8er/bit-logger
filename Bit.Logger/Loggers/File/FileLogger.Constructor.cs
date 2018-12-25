namespace Bit.Logger.Loggers.File
{
    using Config;
    using LogBuffer;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        private LogBuffer<string> LogBuffer { get; }

        public FileLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            LogBuffer = new LogBuffer<string>();
        }
    }
}