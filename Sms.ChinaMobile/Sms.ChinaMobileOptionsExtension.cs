using Sms;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Sms.ChinaMobile.Internal;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
            services.TryAddTransient<ChinaMobileHttpClient>();
            services.TryAddEnumerable(ServiceDescriptor.Transient<ISmsService, ChinaMobileService>());

            //Add ChinaMobileOptions
            services.Configure(_configure);
            services.AddSingleton<IConfigureOptions<ChinaMobileOptions>, ConfigureChinaMobileOptions>();
        }
    }
}
