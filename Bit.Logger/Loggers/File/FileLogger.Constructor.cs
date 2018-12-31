namespace Bit.Logger.Loggers.File
{
    using Config;
    using LogBuffer;

    internal partial class FileLogger : IFileLogger
    {
        public Configuration Configuration { get; }

        public LogBuffer<string> LogBuffer { get; }

        public FileLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            LogBuffer = new LogBuffer<string>();
        }
    }
}