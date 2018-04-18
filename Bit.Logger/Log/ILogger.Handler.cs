namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;

    public partial interface ILogger
    {
        List<IHandler> Handlers { get; }

        ILogger AddConsoleHandler(ConsoleConfiguration configuration = null);

        ILogger AddDatabaseHandler(DatabaseConfiguration configuration = null);
        
        ILogger AddFileHandler(FileConfiguration configuration = null);

        ILogger AddHandler(IHandler handler);

        ILogger AddHandlers(IEnumerable<IHandler> handlers);
    }
}