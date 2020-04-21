namespace Bit.Logger.Sources.File
{
    using Arguments;
    using System;
    using static Helpers.LogArgumentsExtensions;

    internal partial class FileSource
    {
        private void WriteToFile(LogArguments logArguments) => logBuffer
            .Check(logArguments.IsLevelAllowed(configuration.Level))
            .Add(logArguments.ToStringLogUsing(configuration))
            .Validate(configuration.BufferSize)
            .Write(fileBulkWriter.ToFileAsync, kv => $"{kv.Value}{Environment.NewLine}");
    }
}
