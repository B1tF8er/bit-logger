namespace Bit.Logger
{
    using Bit.Logger.Config;
    using System.Collections.Generic;

    public partial interface ILoggerFactoty : ILogger
    {
        List<ILogger> Loggers { get; }

        ILoggerFactoty AddConsoleLogger(Configuration configuration = default(Configuration));

        ILoggerFactoty AddDatabaseLogger(Configuration configuration = default(Configuration));
        
        ILoggerFactoty AddFileLogger(Configuration configuration = default(Configuration));

        ILoggerFactoty AddLogger(ILogger handler);

        ILoggerFactoty AddLoggers(IEnumerable<ILogger> handlers);
    }
}