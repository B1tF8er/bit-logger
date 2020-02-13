namespace Bit.Logger.Buffer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants.Buffer;

    internal class LogBuffer<TLog> : ILogBuffer<TLog>
    {
        public bool Continue { get; set; }

        public Dictionary<string, TLog> Logs { get; }

        public object Padlock { get; }

        internal LogBuffer()
        {
            Logs = new Dictionary<string, TLog>();
            Padlock = new object();
        }

        public ILogBuffer<TLog> Check(bool isAllowed)
        {
            Continue = isAllowed;

            return this;
        }

        public ILogBuffer<TLog> Add(TLog log)
        {
            if (!Continue)
                return this;

            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";

            lock (Padlock)
                Logs.TryAdd(key, log);

            return this;
        }

        public ILogBuffer<TLog> Validate(int logsThreshold)
        {
            if (!Continue)
                return this;

            var count = 0;

            lock (Padlock)
                count = Logs.Count;

            var underThreshold = count <= logsThreshold;

            if (underThreshold)
            {
                Continue = false;
                return this;
            }

            Continue = true;
            return this;
        }

        public void Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            if (!Continue)
                return;

            lock (Padlock)
            {
                write(Logs.OrderByDescending(kv => kv.Key.Split('-').First()).Select(selector));
                Logs.Clear();
            }
        }
    }
}
