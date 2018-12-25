namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using static Helpers.EnumerableExtensions;
    using static Helpers.LogPathResolver;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(CreateLogWith(logArguments))
                .Validate()
                ?.Write(BulkWriteToFileAsync)
                .Clear();
        }

        private string CreateLogWith(LogArguments logArguments)
        {
            return string.Format(Configuration.FormatProvider, Configuration.Format,
                logArguments.Level,
                DateTime.Now,
                logArguments.ClassName,
                logArguments.MethodName,
                logArguments.Message,
                logArguments.Exception
            ).Trim();
        }

        private async void BulkWriteToFileAsync(IEnumerable<string> logs)
        {
            using (var logWriter = new StreamWriter(CurrentLogPath(DateTime.Now), true, Encoding.UTF8))
                await logWriter.WriteAsync(logs.ToAppendedString());
        }
    }
}