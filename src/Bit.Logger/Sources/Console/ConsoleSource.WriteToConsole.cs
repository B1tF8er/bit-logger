namespace Bit.Logger.Sources.Console
{
    using Arguments;
    using Helpers;

    internal partial class ConsoleSource
    {
        private void WriteToConsole(LogArguments logArguments) => logBuffer
            .Write(
                logArguments,
                (logArguments, configuration) => logArguments.ToStringLogUsing(configuration),
                consoleBulkWriter.ToConsole,
                kv => kv.Value
            );
    }
}
