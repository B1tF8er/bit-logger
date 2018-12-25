namespace Bit.Logger.LogBuffer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants;

    internal class LogBuffer<TLog> : ILogBuffer<TLog>
    {
        public IDictionary<string, TLog> Logs { get; set; } 

        public object Padlock { get; }

        internal LogBuffer()
        {
            Logs = new Dictionary<string, TLog>();
            Padlock = new object();
        }

        internal LogBuffer<TLog> Add(TLog log)
        {
            var key = DateTime.Now.ToString(AsKey);

            lock (Padlock)
            {
                if (!Logs.ContainsKey(key))
                    Logs.Add(key, log);
            }

            return this;
        }

        internal void ThenWriteUsing(Action<IEnumerable<TLog>> writeAction)
        {
            var thresholdSurpassed = Logs.Count >= LogsThreshold;

            if (!Logs.Any() && !thresholdSurpassed)
                return;

            IEnumerable<TLog> sortedLogs;

            lock (Padlock)
            {
                sortedLogs = Logs.OrderBy(kv => kv.Key).Select(kv => kv.Value);
                Logs = new Dictionary<string, TLog>();
            }

            writeAction(sortedLogs);
        }
    }
}
