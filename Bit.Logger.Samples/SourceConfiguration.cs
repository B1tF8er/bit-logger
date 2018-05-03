namespace Bit.Logger.Samples
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;

    internal static class SourceConfiguration
    {
        internal static ILoggerFactory ConfigureLoggerSources(this ILoggerFactory logger)
        {
            logger
                .AddConsoleSource(CreateConsoleConfiguration())
                .AddDatabaseSource(CreateDatabaseConfiguration())
                .AddFileSource(CreateFileConfiguration())
                .AddSource(CreateCustomConsoleSource())
                .AddSources(CreateCustomConsoleSources());

            return logger;
        }

        private static Func<Configuration> CreateConsoleConfiguration = () => new Configuration
        {
            Level = Level.Trace,
            ShowLevel = false
        };

        private static Func<Configuration> CreateDatabaseConfiguration = () => new Configuration
        {
            Level = Level.Critical,
            ShowTime = false
        };
        
        private static Func<Configuration> CreateFileConfiguration = () => new Configuration
        {
            Level = Level.Information,
            ShowDate = false
        };

        private static Func<CustomConsoleSource> CreateCustomConsoleSource = () => new CustomConsoleSource(new Configuration
        {
            Level = Level.Trace
        });

        private static Func<IEnumerable<CustomConsoleSource>> CreateCustomConsoleSources = () => new List<CustomConsoleSource>
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
