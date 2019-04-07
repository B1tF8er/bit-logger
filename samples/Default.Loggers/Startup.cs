using Bit.Logger;
using Bit.Logger.Contract;
using Bit.Logger.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using static Default.Loggers.LogConfigurationExtensions;

namespace Default.Loggers
{
    internal static class Startup
    {
        private static readonly ServiceCollection serviceCollection;

        internal static ServiceProvider ServiceProvider { get; }

        static Startup()
        {
            serviceCollection = new ServiceCollection();
            AddServices();
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void AddServices()
        {
            serviceCollection.AddSingleton(Logger);
            serviceCollection.AddSingleton(Configuration);
            serviceCollection.AddTransient<App>();
        }

        private static ILogger Logger => new Logger()
            .AddConsoleSource(CreateConfiguration(DateType.DateTimeIso, ShowLevel.Yes, Level.Trace))
            .AddDatabaseSource(CreateConfiguration(DateType.DateIso, ShowLevel.No))
            .AddFileSource(CreateConfiguration(DateType.TimeIso, ShowLevel.Yes, Level.Critical));

        private static IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }
}
