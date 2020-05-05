namespace Bit.Logger.Buffer
{
    using Arguments;
    using Helpers;
    using Config;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Helpers.Constants.Buffer;

    internal class LogBuffer<TLog> : ILogBuffer<TLog> where TLog : class
    {
        private readonly IConfiguration configuration;
        private readonly object padlock;
        private readonly Dictionary<string, TLog> logs;

        internal LogBuffer(IConfiguration configuration)
        {
            this.configuration = configuration;
            padlock = new object();
            logs = new Dictionary<string, TLog>();
        }

        public void Write(
            LogArguments logArguments,
            Func<LogArguments, IConfiguration, TLog> toLog,
            Action<IEnumerable<TLog>> write,
            Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            if (!logArguments.IsLevelAllowed(configuration.Level))
                return;

            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";
            var log = toLog(logArguments, configuration);

            lock (padlock)
                logs.TryAdd(key, log);

            var count = 0;

            lock (padlock)
                count = logs.Count;

            var underThreshold = count < configuration.BufferSize;

            if (underThreshold)
                return;

            lock (padlock)
            {
                write(logs.OrderByDescending(DateTimeKey()).Select(selector));
                logs.Clear();
            }
        }

        private static Func<KeyValuePair<string, TLog>, string> DateTimeKey() =>
            kv => kv.Key.Split('-').First();
    }
}
