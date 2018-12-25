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
            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";
            
            Logs.TryAdd(key, log);

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

        internal LogBuffer<TLog> Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            Func<KeyValuePair<string, TLog>, string> keySelector = kv => kv.Key.Split('-').First();

            var sortedLogs = Logs.OrderByDescending(keySelector).Select(selector);

            write(sortedLogs);

            return this;
        }

        internal LogBuffer<TLog> Clear()
        {
            Logs.Clear();

            return this;
        }
    }
}
