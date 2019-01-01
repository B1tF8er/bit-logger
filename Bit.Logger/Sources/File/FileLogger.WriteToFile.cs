namespace Bit.Logger.Sources.File
{
    using Arguments;
    using Config;
    using Contract;
    using System;
    using Writers;
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