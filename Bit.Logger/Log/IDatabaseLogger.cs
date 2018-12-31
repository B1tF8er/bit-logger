namespace Bit.Logger
{
    using Config;
    using Models;
    using LogBuffer;

    public interface IDatabaseLogger : ILogger, IConfiguration, ILogBuffer<Log>
    {
        
    }
}