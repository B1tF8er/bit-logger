namespace Bit.Logger.Sources.File
{
    using Buffer;
    using Contract;

    internal partial class FileSource : IFileSource
    {
        private readonly ILogBuffer<string> logBuffer;

        public FileSource(ILogBuffer<string> logBuffer)
        {
            this.logBuffer = logBuffer;
        }
    }
}
