namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILogger
    {
        public List<IHandler> Handlers { get; }

        public Logger() => Handlers = new List<IHandler>();

        public ILogger AddConsoleHandler(Configuration configuration = null)
        {
            Handlers.Add(new ConsoleHandler(configuration));

            return this;
        }

        public ILogger AddDatabaseHandler(Configuration configuration = null)
        {
            Handlers.Add(new DatabaseHandler(configuration));

            return this;
        }

        public ILogger AddFileHandler(Configuration configuration = null)
        {
            Handlers.Add(new FileHandler(configuration));

            return this;
        }

        public ILogger AddHandler(IHandler handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            Handlers.Add(handler);

            return this;
        }

        public ILogger AddHandlers(IEnumerable<IHandler> handlers)
        {
            var anyHandlerIsNull = handlers?.Any(handler => handler == null) ?? true;

            if (anyHandlerIsNull)
                throw new ArgumentNullException(nameof(handlers));

            Handlers.AddRange(handlers);

            return this;
        }
    }
}
