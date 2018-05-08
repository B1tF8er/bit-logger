namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Inject logging service
            var services = new ServiceCollection()
                .AddSingleton<ILoggerFactory, Logger>()
                .BuildServiceProvider();

            // Get logging service and configure its sources
            var logger = services
                .GetService<ILoggerFactory>()
                .ConfigureLoggerSources();

            var sample = new Sample(logger);

            sample.Test();

            Console.WriteLine(logger.ToString()); // this will show all the sources of the logger
        }
    }
}
