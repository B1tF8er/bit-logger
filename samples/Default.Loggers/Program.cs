namespace Default.Loggers
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public static class Program
    {
        private static Action Run =>
            Startup.ServiceProvider.GetService<App>().Run;

        private static void Main(string[] _) =>
            Run.TryOrFailFast();
    }
}
