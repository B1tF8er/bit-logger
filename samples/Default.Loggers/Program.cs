namespace Default.Loggers
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class Program
    {
        private static Action Run =>
            Startup.ServiceProvider.GetService<App>().Run;

        static void Main(string[] _) =>
            Run.TryOrFailFast();
    }
}
