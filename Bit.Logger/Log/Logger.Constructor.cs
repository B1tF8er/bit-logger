namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Handlers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILogger
    {
        private readonly List<IHanlder> _handlers;

        public Logger() =>
            _handlers = new List<IHanlder>();

        public Logger AddConsoleHandler(ConsoleConfiguration configuration = null)
        {
            _handlers.Add(new ConsoleHandlerLogger(configuration));

            return this;
        }

        public Logger AddDatabaseHandler(DatabaseConfiguration configuration = null)
        {
            _handlers.Add(new DatabaseHandlerLogger(configuration));

            return this;
        }

        public Logger AddFileHandler(FileConfiguration configuration = null)
        {
            _handlers.Add(new FileHandlerLogger(configuration));

            return this;
        }

        public Logger AddHandler(IHanlder handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            _handlers.Add(handler);

            return this;
        }

        public Logger AddHandlers(IEnumerable<IHanlder> handlers)
        {
            var anyHandlerIsNull = handlers?.Any(handler => handler == null) ?? true;

            if (anyHandlerIsNull)
                throw new ArgumentNullException(nameof(handlers));

            _handlers.AddRange(handlers);

            return this;
        }
    }
}
