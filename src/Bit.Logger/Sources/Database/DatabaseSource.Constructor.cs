namespace Bit.Logger.Sources.Database
{
    using Buffer;
    using Contract;
    using Models;

    internal partial class DatabaseSource : IDatabaseSource
    {
        private readonly ILogBuffer<Log> logBuffer;

        public DatabaseSource(ILogBuffer<Log> logBuffer)
        {
            this.logBuffer = logBuffer;
        }
    }
}
