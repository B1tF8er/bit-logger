namespace Bit.Logger.Contract
{
    using Buffer;
    using Config;
    using Contract;

    public interface IFileLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        
    }
}