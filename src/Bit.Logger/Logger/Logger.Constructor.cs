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

        public ILogger AddConsoleSource(IConsoleConfiguration configuration = default)
        {
            configuration ??= new ConsoleConfiguration();
            var bulkWriter = new ConsoleBulkWriter();
            var logBuffer = new LogBuffer<string>(configuration, bulkWriter);
            var consoleSource = new ConsoleSource(logBuffer);

            Sources.Add(consoleSource);

            return this;
        }

        public ILogger AddDatabaseSource(IDatabaseConfiguration configuration = default)
        {
            configuration ??= new DatabaseConfiguration();
            var databaseLogPathResolver = new DatabaseLogPathResolver(configuration);
            var bulkWriter = new DatabaseBulkWriter(databaseLogPathResolver);
            var logBuffer = new LogBuffer<Log>(configuration, bulkWriter);
            var databaseSource = new DatabaseSource(logBuffer);

            Sources.Add(databaseSource);

            return this;
        }

        public ILogger AddFileSource(IFileConfiguration configuration = default)
        {
            configuration ??= new FileConfiguration();
            var bulkWriter = new FileBulkWriter(new FileLogPathResolver(configuration));
            var logBuffer = new LogBuffer<string>(configuration, bulkWriter);
            var fileSource = new FileSource(logBuffer);

            Sources.Add(fileSource);

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
                .Select(source => $"{source}")
                .Aggregate((sourcesSoFar, nextSource) => $"{sourcesSoFar}{Environment.NewLine}{nextSource}");
    }
}
