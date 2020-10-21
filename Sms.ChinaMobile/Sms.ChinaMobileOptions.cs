using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Sms.ChinaMobile
{
    public class ChinaMobileOptions
    {
        public string AppId { get; set; }

        public string AppSecret { get; set; }

        public string Sign { get; set; }
    }

    internal class ConfigureChinaMobileOptions : IConfigureOptions<ChinaMobileOptions>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public ConfigureChinaMobileOptions(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public void Configure(ChinaMobileOptions options)
        {
        }
    }
}
