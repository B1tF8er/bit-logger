namespace Bit.Logger.Loggers.Database
{
    using Config;
    using LogBuffer;
    using Models;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        private LogBuffer<Log> LogBuffer { get; }

        public DatabaseLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            LogBuffer = new LogBuffer<Log>();
        }
            
    }
}