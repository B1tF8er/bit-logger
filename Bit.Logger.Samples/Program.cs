namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static ILoggerFactory logger = new Logger();

        static void Main(string[] args)
        {
            logger
                .AddConsoleSource(CreateConsoleConfiguration())
                .AddDatabaseSource(CreateDatabaseConfiguration())
                .AddFileSource(CreateFileConfiguration())
                .AddSource(CreateCustomConsoleSource())
                .AddSources(CreateCustomConsoleSources());

            // this should be done using a DI container LOL!!
            var sample = new Sample(logger);

            sample.Test();

            sample.TestAllPossibleLevels();
        }

        static Func<Configuration> CreateConsoleConfiguration = () => new Configuration
        {
            Level = Level.Trace,
            ShowLevel = false
        };

        static Func<Configuration> CreateDatabaseConfiguration = () => new Configuration
        {
            Level = Level.Critical,
            ShowTime = false
        };
        static Func<Configuration> CreateFileConfiguration = () => new Configuration
        {
            Level = Level.Information,
            ShowDate = false
        };

        static Func<CustomConsoleSource> CreateCustomConsoleSource = () => new CustomConsoleSource(new Configuration
        {
            Level = Level.Trace
        });

        static Func<IEnumerable<CustomConsoleSource>> CreateCustomConsoleSources = () => new List<CustomConsoleSource>
        {
            new CustomConsoleSource(new Configuration
            {
                Level = Level.Critical
            }),
            new CustomConsoleSource(new Configuration
            {
                Level = Level.Error
            }),
            new CustomConsoleSource()
        };
    }
}
