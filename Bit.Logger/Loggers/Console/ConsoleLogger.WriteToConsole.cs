namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using BulkWriters;
    using System;
    using static Helpers.LogArgumentsExtensions;

    internal partial class ConsoleLogger
    {
        private void WriteToConsole(LogArguments args) => LogBuffer
                .Check(args.IsLevelAllowed(Configuration.Level))
                ?.Add(args.ToStringLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriter.ToConsole, kv => kv.Value)
                .Clear();
    }
}