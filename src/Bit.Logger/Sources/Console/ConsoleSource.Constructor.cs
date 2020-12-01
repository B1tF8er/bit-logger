namespace Bit.Logger.Sources.Console
{
    using Buffer;
    using Contract;

    internal partial class ConsoleSource : IConsoleSource
    {
        private readonly ILogBuffer<string> logBuffer;

        public ConsoleSource(ILogBuffer<string> logBuffer)
        {
            this.logBuffer = logBuffer;
        }
    }
}
