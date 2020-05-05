namespace Bit.Logger.Sources.Console
{
    using Bit.Logger.Writers;
    using Buffer;
    using Contract;

    internal partial class ConsoleSource : IConsoleSource
    {
        private readonly ILogBuffer<string> logBuffer;

        private readonly IConsoleBulkWriter consoleBulkWriter;

        public ConsoleSource(ILogBuffer<string> logBuffer, IConsoleBulkWriter consoleBulkWriter)
        {
            this.logBuffer = logBuffer;
            this.consoleBulkWriter = consoleBulkWriter;
        }
    }
}
