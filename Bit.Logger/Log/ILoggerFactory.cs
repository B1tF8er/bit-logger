namespace Bit.Logger
{
    using Bit.Logger.Config;
    using System.Collections.Generic;

    public partial interface ILoggerFactory : ILogger
    {
        List<ILogger> Loggers { get; }

        ILoggerFactory AddConsoleSource(Configuration configuration = default(Configuration));

        ILoggerFactory AddDatabaseSource(Configuration configuration = default(Configuration));
        
        ILoggerFactory AddFileSource(Configuration configuration = default(Configuration));

        ILoggerFactory AddSource(ILogger logger);

        ILoggerFactory AddSources(IEnumerable<ILogger> loggers);
    }
}