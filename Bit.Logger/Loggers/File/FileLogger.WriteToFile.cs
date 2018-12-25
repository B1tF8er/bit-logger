namespace Bit.Logger.Loggers.File
{
    using Arguments;
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using static Helpers.Constants;
    using static Helpers.LogPathResolver;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        private void WriteToFile(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            var logDate = DateTime.Now;
            var log = string.Format(Configuration.FormatProvider, Configuration.Format,
                logArguments.Level,
                logDate,
                logArguments.ClassName,
                logArguments.MethodName,
                logArguments.Message,
                logArguments.Exception
            );
            
            CreateFileBuffer(logDate, log);
        }

        private void CreateFileBuffer(DateTime logDate, string log)
        {
            var key = logDate.ToString(AsKey);
    
            lock (Padlock)
                AddToLogs(key, log);

            var logsThresholdSurpassed = Logs.Count >= LogsThreshold;

            if (logsThresholdSurpassed)
            {
                var sb = new StringBuilder();

                lock (Padlock)
                    sb = CreateLogsStringBuilder();
                
                BulkWriteAsync(logDate, sb.ToString());
            }
        }

        private void AddToLogs(string key, string log)
        {
            if (!Logs.ContainsKey(key))
                Logs.Add(key, log);
        }

        private StringBuilder CreateLogsStringBuilder()
        {
            var logs = new StringBuilder();

            IEnumerable<string> logsOrderedByDate = GetLogsOrderedByDate();
            
            ResetLogs();

            foreach (var log in logsOrderedByDate)
                logs.Append(log);

            return logs;
        }

        private IEnumerable<string> GetLogsOrderedByDate()
        {
            IEnumerable<string> logsOrderedByDate;

            logsOrderedByDate = Logs
                .OrderBy(kv => kv.Key)
                .Select(kv => kv.Value);

            return logsOrderedByDate;
        }

        private void ResetLogs()
        {
            Logs = new Dictionary<string, string>();
        }

        private async void BulkWriteAsync(DateTime logDate, string logs)
        {
            using (var logWriter = new StreamWriter(CurrentLogPath(logDate), true, Encoding.UTF8))
                await logWriter.WriteAsync(logs);
        }
    }
}