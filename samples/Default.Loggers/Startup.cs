namespace Default.Loggers
{
    using Bit.Logger;
    using Bit.Logger.Contract;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using static Constants.Path;
    using static LogConfigurationExtensions;

    internal static class Startup
    {
        internal static ServiceProvider ServiceProvider { get; }

        static Startup() =>
            ServiceProvider = new ServiceCollection()
                .AddServices()
                .BuildServiceProvider();

        private static IServiceCollection AddServices(this ServiceCollection serviceCollection) =>
            serviceCollection
                .AddSingleton(Logger())
                .AddSingleton(Configuration())
                .AddTransient<App>();

        private static ILogger Logger() =>
            new Logger()
                .AddConsoleSource(CreateConsoleLogConfiguration())
                .AddDatabaseSource(CreateDatabaseLogConfiguration())
                .AddFileSource(CreateFileLogConfiguration());

        private static IConfiguration Configuration() =>
            new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(AppSettingsPath, optional: true, reloadOnChange: true)
                .Build();
    }
}
