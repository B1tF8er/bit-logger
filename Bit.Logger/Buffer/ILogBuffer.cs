namespace Bit.Logger.Buffer
{
    public interface ILogBuffer<TLog>
    {
        LogBuffer<TLog> LogBuffer { get; }
    }
}