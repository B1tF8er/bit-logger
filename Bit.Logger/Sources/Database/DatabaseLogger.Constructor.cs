namespace Bit.Logger.Sources.Database
{
    using Buffer;
    using Config;
    using Contract;
    using Models;

    internal partial class DatabaseLogger : IDatabaseLogger
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<Log> logBuffer;

        public DatabaseLogger(IConfiguration configuration, ILogBuffer<Log> logBuffer)
        {
            this.configuration = configuration ?? new Configuration();
            this.logBuffer = logBuffer;
        }
    }
}
