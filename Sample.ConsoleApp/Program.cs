using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sms;
using Sms.ChinaMobile;
using Sms.ChinaMobile.Internal;
using Sms.ChinaMobile.Internal.Model;

namespace Sample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HSSample.ServiceSample();

            Console.ReadLine();
        }
    }
}
