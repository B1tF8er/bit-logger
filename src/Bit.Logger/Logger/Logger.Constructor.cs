namespace Bit.Logger
{
    using Buffer;
    using Config;
    using Contract;
    using Helpers;
    using Models;
    using Sources.Console;
    using Sources.Database;
    using Sources.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Writers;

    public partial class Logger : ILogger
    {
        public List<ISource> Sources { get; }

        public Logger() => Sources = new List<ISource>();

        public ILogger AddConsoleSource(Configuration configuration = default)
        {
            configuration ??= new Configuration();

            Sources.Add(
                new ConsoleSource(
                    new LogBuffer<string>(configuration),
                    new ConsoleBulkWriter()
                )
            );
            
            return this;
        }

        public ILogger AddDatabaseSource(Configuration configuration = default)
        {
            configuration ??= new Configuration();

            Sources.Add(
                new DatabaseSource(
                    new LogBuffer<Log>(configuration),
                    new DatabaseBulkWriter(new DatabaseLogPathResolver(configuration))
                )
            );

            return this;
        }

        public ILogger AddFileSource(Configuration configuration = default)
        {
            configuration ??= new Configuration();

            Sources.Add(
                new FileSource(
                    new LogBuffer<string>(configuration),
                    new FileBulkWriter(new FileLogPathResolver(configuration))
                )
            );

            return this;
        }

        public ILogger AddSource(ISource source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            Sources.Add(source);

            return this;
        }

        public ILogger AddSources(IEnumerable<ISource> sources)
        {
            var anySourceIsNull = sources?.Any(source => source is null) ?? true;

            if (anySourceIsNull)
                throw new ArgumentNullException(nameof(sources));

            Sources.AddRange(sources);

            return this;
        }

        public override string ToString() =>
            Sources
                .Select(s => $"{s}")
                .Aggregate((acc, next) => $"{acc}{Environment.NewLine}{next}");
    }
}
