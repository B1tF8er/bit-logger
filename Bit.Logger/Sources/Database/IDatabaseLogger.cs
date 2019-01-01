namespace Bit.Logger
{
    using Buffer;
    using Config;
    using Contract;
    using Models;

    public interface IDatabaseLogger : ILogger, IConfiguration, ILogBuffer<Log>
    {
        
    }
}