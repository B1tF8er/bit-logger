namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using static Helpers.EnumerableExtensions;
    using static Helpers.LogArgumentsExtensions;
    using static Helpers.LogPathResolver;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(logArguments.ToStringLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriteToFileAsync, kv => $"{kv.Value}{Environment.NewLine}")
                .Clear();
        }

        private async void BulkWriteToFileAsync(IEnumerable<string> logs)
        {
            using (var logWriter = new StreamWriter(CurrentLogPath(DateTime.Now), true, Encoding.UTF8))
                await logWriter.WriteAsync(logs.ToAppendedString());
        }
    }
}