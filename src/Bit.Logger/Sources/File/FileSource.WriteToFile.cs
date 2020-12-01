namespace Bit.Logger.Sources.File
{
    using Arguments;
    using Helpers;
    using System;

    internal partial class FileSource
    {
        private void WriteToFile(LogArguments logArguments) => logBuffer
            .Write(
                logArguments,
                (logArguments, configuration) => logArguments.ToStringLogUsing(configuration),
                kv => $"{kv.Value}{Environment.NewLine}"
            );
    }
}
