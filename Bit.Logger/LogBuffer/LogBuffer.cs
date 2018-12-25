namespace Bit.Logger.LogBuffer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants;

    internal class LogBuffer<TLog>
    {
        private Dictionary<string, TLog> Logs { get; }

        private object Padlock { get; }

        internal LogBuffer()
        {
            Logs = new Dictionary<string, TLog>();
            Padlock = new object();
        }

        internal LogBuffer<TLog> Add(TLog log)
        {
            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";

            lock (Padlock)
                Logs.TryAdd(key, log);

            return this;
        }

        internal LogBuffer<TLog> Validate()
        {
            var count = 0;

            lock (Padlock)
                count = Logs.Count;

            var underThreshold = count <= LogsThreshold;

            if (underThreshold)
                return null;

            return this;
        }

        internal LogBuffer<TLog> Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            IEnumerable<TLog> sortedLogs;

            Func<KeyValuePair<string, TLog>, string> keySelector = kv => kv.Key.Split('-').First();

            lock (Padlock)
                sortedLogs = Logs.OrderByDescending(keySelector).Select(selector);

            write(sortedLogs);

            return this;
        }

        internal LogBuffer<TLog> Clear()
        {
            lock (Padlock)
                Logs.Clear();

            return this;
        }
    }
}
