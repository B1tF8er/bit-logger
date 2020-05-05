namespace Bit.Logger.Sources.Database
{
    using Bit.Logger.Writers;
    using Buffer;
    using Contract;
    using Models;

    internal partial class DatabaseSource : IDatabaseSource
    {
        private readonly ILogBuffer<Log> logBuffer;

        private readonly IDatabaseBulkWriter databaseBulkWriter;

        public DatabaseSource(ILogBuffer<Log> logBuffer, IDatabaseBulkWriter databaseBulkWriter)
        {
            this.logBuffer = logBuffer;
            this.databaseBulkWriter = databaseBulkWriter;
        }
    }
}
