namespace Bit.Logger.Factory
{
    using Config;
    using Contract;
    using System.Collections.Generic;

    public interface ILoggerFactory : ILogger
    {
        List<ILogger> Loggers { get; }

        ILoggerFactory AddConsoleSource(Configuration configuration = default);

        ILoggerFactory AddDatabaseSource(Configuration configuration = default);
        
        ILoggerFactory AddFileSource(Configuration configuration = default);

        ILoggerFactory AddSource(ILogger logger);

        ILoggerFactory AddSources(IEnumerable<ILogger> loggers);
    }
}