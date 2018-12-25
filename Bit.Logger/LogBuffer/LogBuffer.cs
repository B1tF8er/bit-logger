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

        internal LogBuffer<TLog> Validate()
        {
            var hasLogs = Logs.Any();
            var underThreshold = Logs.Count <= LogsThreshold;
            var notEnoughLogs = hasLogs && underThreshold;

            if (!hasLogs || notEnoughLogs)
                return null;

            return this;
        }

        internal LogBuffer<TLog> Write(Action<IEnumerable<TLog>> write)
        {
            write(Logs.OrderBy(kv => kv.Key).Select(kv => kv.Value));

            return this;
        }

        internal LogBuffer<TLog> Clear()
        {
            Logs.Clear();

            return this;
        }
    }
}
