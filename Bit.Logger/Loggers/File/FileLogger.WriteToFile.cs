namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using BulkWriters;
    using Config;
    using System;
    using static Helpers.LogArgumentsExtensions;

    internal partial class FileLogger
    {
        private void WriteToFile(LogArguments args) => LogBuffer
                .Check(args.IsLevelAllowed(Configuration.Level))
                ?.Add(args.ToStringLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriter.ToFileAsync, kv => $"{kv.Value}{Environment.NewLine}")
                .Clear();
    }
}