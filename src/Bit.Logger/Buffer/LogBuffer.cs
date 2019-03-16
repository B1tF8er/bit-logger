namespace Bit.Logger.Buffer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants.Buffer;

    internal class LogBuffer<TLog> : ILogBuffer<TLog>
    {
        public Dictionary<string, TLog> Logs { get; }

        public object Padlock { get; }

        internal LogBuffer()
        {
            Logs = new Dictionary<string, TLog>();
            Padlock = new object();
        }

        public ILogBuffer<TLog> Check(bool isAllowed) =>
            isAllowed ? this : null;

        public ILogBuffer<TLog> Add(TLog log)
        {
            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";

            lock (Padlock)
                Logs.TryAdd(key, log);

            return this;
        }

        public ILogBuffer<TLog> Validate(int logsThreshold)
        {
            var count = 0;

            lock (Padlock)
                count = Logs.Count;

            var underThreshold = count <= logsThreshold;

            if (underThreshold)
                return null;

            return this;
        }

        public void Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            lock (Padlock)
            {
                write(Logs.OrderByDescending(kv => kv.Key.Split('-').First()).Select(selector));
                Logs.Clear();
            }
        }
    }
}
