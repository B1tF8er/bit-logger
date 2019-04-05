using Microsoft.Extensions.DependencyInjection;
using static Default.Loggers.TryCatchExtensions;

namespace Default.Loggers
{
    class Program
    {
        static void Main(string[] args) =>
            FailFast(() => Startup.ServiceProvider.GetService<App>().Run());
    }
}
