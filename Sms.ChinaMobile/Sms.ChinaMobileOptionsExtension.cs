using Sms;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Sms.ChinaMobile
{
    public class ChinaMobileOptionsExtension : ISmsOptionsExtension
    {
        private readonly Action<ChinaMobileOptions> _configure;

        public ChinaMobileOptionsExtension(Action<ChinaMobileOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            //Inject Services

            //Add ChinaMobileOptions
            services.Configure(_configure);
            services.AddSingleton<IConfigureOptions<ChinaMobileOptions>, ConfigureChinaMobileOptions>();
        }
    }
}
