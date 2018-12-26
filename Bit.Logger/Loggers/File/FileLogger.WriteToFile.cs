namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using BulkWriters;
    using Config;
    using System;
    using static Helpers.LogArgumentsExtensions;

    internal partial class FileLogger
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(logArguments.ToStringLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriter.ToFileAsync, kv => $"{kv.Value}{Environment.NewLine}")
                .Clear();
        }
    }
}