namespace Bit.Logger.Loggers.Database
{
    using Config;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public DatabaseLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();
    }
}