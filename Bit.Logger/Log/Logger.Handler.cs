namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILogger
    {
        public List<IHanlder> Handlers { get; }

        public Logger() => Handlers = new List<IHanlder>();

        public ILogger AddConsoleHandler(ConsoleConfiguration configuration = null)
        {
            Handlers.Add(new ConsoleHandlerLogger(configuration));

            return this;
        }

        public ILogger AddDatabaseHandler(DatabaseConfiguration configuration = null)
        {
            Handlers.Add(new DatabaseHandlerLogger(configuration));

            return this;
        }

        public ILogger AddFileHandler(FileConfiguration configuration = null)
        {
            Handlers.Add(new FileHandlerLogger(configuration));

            return this;
        }

        public ILogger AddHandler(IHanlder handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            Handlers.Add(handler);

            return this;
        }

        public ILogger AddHandlers(IEnumerable<IHanlder> handlers)
        {
            var anyHandlerIsNull = handlers?.Any(handler => handler == null) ?? true;

            if (anyHandlerIsNull)
                throw new ArgumentNullException(nameof(handlers));

            Handlers.AddRange(handlers);

            return this;
        }
    }
}
