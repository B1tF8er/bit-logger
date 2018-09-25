namespace Bit.Logger.Loggers.File
{
    using Config;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public FileLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();
    }
}