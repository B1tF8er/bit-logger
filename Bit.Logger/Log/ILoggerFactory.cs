namespace Bit.Logger
{
    using Bit.Logger.Config;
    using System.Collections.Generic;

    public partial interface ILoggerFactory : ILogger
    {
        List<ILogger> Loggers { get; }

        ILoggerFactory AddConsole(Configuration configuration = default(Configuration));

        ILoggerFactory AddDatabase(Configuration configuration = default(Configuration));
        
        ILoggerFactory AddFile(Configuration configuration = default(Configuration));

        ILoggerFactory AddSource(ILogger handler);

        ILoggerFactory AddSources(IEnumerable<ILogger> handlers);
    }
}