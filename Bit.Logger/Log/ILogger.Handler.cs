namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;

    public partial interface ILogger
    {
        List<IHanlder> Handlers { get; }

        ILogger AddConsoleHandler(ConsoleConfiguration configuration = null);

        ILogger AddDatabaseHandler(DatabaseConfiguration configuration = null);
        
        ILogger AddFileHandler(FileConfiguration configuration = null);

        ILogger AddHandler(IHanlder handler);

        ILogger AddHandlers(IEnumerable<IHanlder> handlers);
    }
}