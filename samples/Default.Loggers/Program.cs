namespace Default.Loggers
{
    using Microsoft.Extensions.DependencyInjection;
    using static Default.Loggers.TryCatchExtensions;
    
    class Program
    {
        static void Main(string[] args) =>
            TryOrFailFast(Startup.ServiceProvider.GetService<App>().Run);
    }
}
