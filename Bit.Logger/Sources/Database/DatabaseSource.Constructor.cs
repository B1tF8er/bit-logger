namespace Bit.Logger.Sources.Database
{
    using Buffer;
    using Config;
    using Contract;
    using Models;

    internal partial class DatabaseSource : IDatabaseSource
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<Log> logBuffer;

        public DatabaseSource(IConfiguration configuration, ILogBuffer<Log> logBuffer)
        {
            this.configuration = configuration ?? new Configuration();
            this.logBuffer = logBuffer;
        }
    }
}
