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
        private void WriteToFile(LogArguments args) => logBuffer
            .Check(args.IsLevelAllowed(configuration.Level))
            ?.Add(args.ToStringLogUsing(configuration))
            .Validate()
            ?.Write(FileBulkWriter.ToFileAsync, kv => $"{kv.Value}{Environment.NewLine}")
            .Clear();
    }
}