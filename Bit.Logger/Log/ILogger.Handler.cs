namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;

    public partial interface ILogger
    {
        List<IHandler> Handlers { get; }

        ILogger AddConsoleHandler(Configuration configuration = default(Configuration));

        ILogger AddDatabaseHandler(Configuration configuration = default(Configuration));
        
        ILogger AddFileHandler(Configuration configuration = default(Configuration));

        ILogger AddHandler(IHandler handler);

        ILogger AddHandlers(IEnumerable<IHandler> handlers);
    }
}