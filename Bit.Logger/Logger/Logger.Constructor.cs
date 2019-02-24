namespace Bit.Logger
{
    using Buffer;
    using Config;
    using Contract;
    using Models;
    using Sources.Console;
    using Sources.Database;
    using Sources.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class Logger : ILogger
    {
        public List<ISource> Sources { get; }

        public Logger() => Sources = new List<ISource>();

        public ILogger AddConsoleSource(Configuration configuration = default)
        {
            Sources.Add(new ConsoleSource(configuration, new LogBuffer<string>()));

            return this;
        }

        public ILogger AddDatabaseSource(Configuration configuration = default)
        {
            Sources.Add(new DatabaseSource(configuration, new LogBuffer<Log>()));

            return this;
        }

        public ILogger AddFileSource(Configuration configuration = default)
        {
            Sources.Add(new FileSource(configuration, new LogBuffer<string>()));

            return this;
        }

        public ILogger AddSource(ISource source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Sources.Add(source);

            return this;
        }

        public ILogger AddSources(IEnumerable<ISource> sources)
        {
            var anySourceIsNull = sources?.Any(logger => logger == null) ?? true;

            if (anySourceIsNull)
                throw new ArgumentNullException(nameof(sources));

            Sources.AddRange(sources);

            return this;
        }

        public override string ToString() =>
            Sources.Select(s => $"{s}").Aggregate((a, b) => $"{a}{Environment.NewLine}{b}");
    }
}
