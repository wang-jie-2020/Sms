using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Sample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddLogging(x => x.AddConsole());
            services.AddSms(x =>
            {
                x.UseChinaMobile(z =>
                {

                });
            });

            var sp = services.BuildServiceProvider();

            //sp.GetService<ISmsService>().Send();

            Console.ReadLine();
        }
    }
}
