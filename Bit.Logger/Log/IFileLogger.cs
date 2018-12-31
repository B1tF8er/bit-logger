namespace Bit.Logger
{
    using Config;
    using LogBuffer;

    public interface IFileLogger : ILogger, IConfiguration, ILogBuffer<string>
    {
        
    }
}