namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Config;
    using System;
    using System.IO;
    using System.Text;
    using static Helpers.LogPathResolver;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            var logDate = DateTime.Now;

            using (var logWriter = new StreamWriter(CurrentLogPath(logDate), true, Encoding.UTF8))
            {
                var log = string.Format(Configuration.FormatProvider, Configuration.Format,
                    logArguments.Level,
                    logDate,
                    logArguments.ClassName,
                    logArguments.MethodName,
                    logArguments.Message,
                    logArguments.Exception
                );

                logWriter.WriteLine(log);
            }
        }
    }
}