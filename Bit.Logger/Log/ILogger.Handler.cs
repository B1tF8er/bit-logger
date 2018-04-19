namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;

    public partial interface ILogger
    {
        List<IHandler> Handlers { get; }

        ILogger AddConsoleHandler(Configuration configuration = null);

        ILogger AddDatabaseHandler(Configuration configuration = null);
        
        ILogger AddFileHandler(Configuration configuration = null);

        ILogger AddHandler(IHandler handler);

        ILogger AddHandlers(IEnumerable<IHandler> handlers);
    }
}