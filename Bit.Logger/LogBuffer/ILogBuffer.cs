namespace Bit.Logger.LogBuffer
{
    public interface ILogBuffer<TLog>
    {
        LogBuffer<TLog> LogBuffer { get; }
    }
}