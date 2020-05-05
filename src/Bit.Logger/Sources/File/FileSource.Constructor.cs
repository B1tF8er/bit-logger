namespace Bit.Logger.Sources.File
{
    using Buffer;
    using Contract;
    using Writers;

    internal partial class FileSource : IFileSource
    {
        private readonly ILogBuffer<string> logBuffer;

        private readonly IFileBulkWriter fileBulkWriter;

        public FileSource(ILogBuffer<string> logBuffer, IFileBulkWriter fileBulkWriter)
        {
            this.logBuffer = logBuffer;
            this.fileBulkWriter = fileBulkWriter;
        }
    }
}
