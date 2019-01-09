namespace Bit.Logger.Buffer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface ILogBuffer<TLog>
    {
        Dictionary<string, TLog> Logs { get; }

        object Padlock { get; }

        ILogBuffer<TLog> Check(bool isAllowed);

        ILogBuffer<TLog> Add(TLog log);

        ILogBuffer<TLog> Validate();

        ILogBuffer<TLog> Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector);

        ILogBuffer<TLog> Clear();
    }
}