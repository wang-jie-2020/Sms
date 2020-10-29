using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sms;
using Sms.ChinaMobile;

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
                x.Version = "1.00";
                x.UseChinaMobile(z =>
                {
                    z.EcName = "test";
                });
            });

            var sp = services.BuildServiceProvider();

            //var t1 = sp.GetRequiredService<IOptions<SmsOptions>>();
            //var t2 = sp.GetRequiredService<IOptions<ChinaMobileOptions>>();

            //sp.GetService<ISmsService>().Send();

            Console.ReadLine();
        }
    }
}
