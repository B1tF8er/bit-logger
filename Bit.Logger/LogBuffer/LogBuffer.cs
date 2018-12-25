namespace Bit.Logger.LogBuffer
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants;

    internal class LogBuffer<TLog>
    {
        private ConcurrentDictionary<string, TLog> Logs { get; }

        internal LogBuffer() =>
            Logs = new ConcurrentDictionary<string, TLog>();

        internal LogBuffer<TLog> Add(TLog log)
        {
            Logs.AddOrUpdate(DateTime.Now.ToString(AsKey), log, (key, oldLog) => log);

            return this;
        }

        internal void ThenWriteUsing(Action<IEnumerable<TLog>> writeAction)
        {
            var hasLogs = Logs.Any();
            var underThreshold = Logs.Count <= LogsThreshold;
            var notEnoughLogs = hasLogs && underThreshold;

            if (!hasLogs || notEnoughLogs)
                return;

            writeAction(Logs.OrderBy(kv => kv.Key).Select(kv => kv.Value));

            Logs.Clear();
        }
    }
}
