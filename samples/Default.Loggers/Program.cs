namespace Default.Loggers
{
    using Microsoft.Extensions.DependencyInjection;
    using static Default.Loggers.TryCatchExtensions;
    
    class Program
    {
        static void Main(string[] args) =>
            FailFast(Startup.ServiceProvider.GetService<App>().Run);
    }
}
