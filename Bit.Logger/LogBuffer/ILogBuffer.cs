namespace Bit.Logger.LogBuffer
{
    using System.Collections.Generic;

    public interface ILogBuffer<TLog>
    {
        IDictionary<string, TLog> Logs { get; set; }
        object Padlock { get; }
    }
}