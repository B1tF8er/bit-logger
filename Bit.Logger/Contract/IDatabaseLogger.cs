namespace Bit.Logger.Contract
{
    using Buffer;
    using Config;
    using Models;

    public interface IDatabaseLogger : ILogger, IConfiguration, ILogBuffer<Log>
    {
        
    }
}