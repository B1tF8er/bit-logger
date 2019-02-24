namespace Bit.Logger.Sources.Console
{
    using Arguments;
    using Config;
    using System;
    using Writers;
    using static Helpers.LogArgumentsExtensions;

    internal partial class ConsoleSource
    {
        private void WriteToConsole(LogArguments logArguments) => logBuffer
            .Check(logArguments.IsLevelAllowed(configuration.Level))
            ?.Add(logArguments.ToStringLogUsing(configuration))
            .Validate(configuration.BufferSize)
            ?.Write(ConsoleBulkWriter.ToConsole, kv => kv.Value);
    }
}
