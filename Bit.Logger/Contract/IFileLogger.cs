namespace Bit.Logger.Contract
{
    using Buffer;
    using Config;

    public interface IFileLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        
    }
}