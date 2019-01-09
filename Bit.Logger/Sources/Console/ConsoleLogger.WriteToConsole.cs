namespace Bit.Logger.Sources.Console
{
    using Arguments;
    using Config;
    using System;
    using Writers;
    using static Helpers.LogArgumentsExtensions;

    internal partial class ConsoleLogger
    {
        private void WriteToConsole(LogArguments args) => logBuffer
            .Check(args.IsLevelAllowed(configuration.Level))
            ?.Add(args.ToStringLogUsing(configuration))
            .Validate()
            ?.Write(BulkWriter.ToConsole, kv => kv.Value)
            .Clear();
    }
}