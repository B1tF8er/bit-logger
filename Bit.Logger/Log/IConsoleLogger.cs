namespace Bit.Logger
{
    using Config;
    using LogBuffer;

    public interface IConsoleLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        
    }
}