namespace Default.Loggers
{
    using Bit.Logger;
    using Bit.Logger.Contract;
    using Bit.Logger.Enums;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using static LogConfigurationExtensions;

    internal static class Startup
    {
        internal static ServiceProvider ServiceProvider { get; }

        static Startup() => ServiceProvider = new ServiceCollection()
            .AddServices()
            .BuildServiceProvider();

        private static ServiceCollection AddServices(this ServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton(Logger())
                .AddSingleton(Configuration())
                .AddTransient<App>();

            return serviceCollection;
        }

        private static ILogger Logger() => new Logger()
            .AddConsoleSource(CreateConfiguration(DateType.DateTimeIso, ShowLevel.Yes, Level.Trace))
            .AddDatabaseSource(CreateConfiguration(DateType.DateIso, ShowLevel.No))
            .AddFileSource(CreateConfiguration(DateType.TimeIso, ShowLevel.Yes, Level.Critical));

        private static IConfiguration Configuration() => new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }
}
