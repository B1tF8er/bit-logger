namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Bit.Logger.Config;
    using System;
    using System.IO;
    using System.Text;
    using static Bit.Logger.Helpers.LogPathResolver;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            using (var logWriter = new StreamWriter(CurrentLogPath, true, Encoding.UTF8))
            {
                var log = string.Format(Configuration.FormatProvider, Configuration.Format,
                    logArguments.Level,
                    DateTime.Now,
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