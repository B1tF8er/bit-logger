namespace Bit.Logger.Sources.Database
{
    using Buffer;
    using Config;
    using Contract;
    using Models;

    internal partial class DatabaseLogger : IDatabaseLogger
    {
        public Configuration Configuration { get; }

        public LogBuffer<Log> LogBuffer { get; }

        public DatabaseLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            LogBuffer = new LogBuffer<Log>();
        }
    }
}