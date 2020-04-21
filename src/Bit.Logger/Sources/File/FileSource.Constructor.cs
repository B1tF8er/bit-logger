namespace Bit.Logger.Sources.File
{
    using Buffer;
    using Config;
    using Contract;
    using Writers;

    internal partial class FileSource : IFileSource
    {
        private readonly IConfiguration configuration;

        private readonly ILogBuffer<string> logBuffer;

        private readonly IFileBulkWriter fileBulkWriter;

        public FileSource(IConfiguration configuration, ILogBuffer<string> logBuffer, IFileBulkWriter fileBulkWriter)
        {
            this.configuration = configuration;
            this.logBuffer = logBuffer;
            this.fileBulkWriter = fileBulkWriter;
        }
    }
}
