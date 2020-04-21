namespace Bit.Logger.Sources.Database
{
    using Bit.Logger.Writers;
    using Buffer;
    using Config;
    using Contract;
    using Models;

    internal partial class DatabaseSource : IDatabaseSource
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<Log> logBuffer;

        private readonly IDatabaseBulkWriter databaseBulkWriter;

        public DatabaseSource(IConfiguration configuration, ILogBuffer<Log> logBuffer, IDatabaseBulkWriter databaseBulkWriter)
        {
            this.configuration = configuration;
            this.logBuffer = logBuffer;
            this.databaseBulkWriter = databaseBulkWriter;
        }
    }
}
