using Microsoft.Extensions.DependencyInjection;
using System;

namespace Default.Loggers
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Startup.ServiceProvider.GetService<App>().Run();
            }
            catch (Exception ex)
            {
                Environment.FailFast(ex.Message, ex);
            }
        }
    }
}
