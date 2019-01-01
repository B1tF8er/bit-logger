namespace Bit.Logger
{
    using Buffer;
    using Config;
    using Contract;

    public interface IConsoleLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        
    }
}