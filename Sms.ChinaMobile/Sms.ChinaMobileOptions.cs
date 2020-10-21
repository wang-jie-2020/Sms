using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Sms.ChinaMobile
{
    public class ChinaMobileOptions
    {
        public string EcName { get; set; }

        public string AppId { get; set; }

        public string AppSecret { get; set; }

        public string Sign { get; set; }

        public string AddSerial { get; set; }

        public string NorSubmitUrl { get; set; }

        public string TmpSubmitUrl { get; set; }

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
            //if (options.DbContextType != null)
            //{
            //    using var scope = _serviceScopeFactory.CreateScope();
            //    var provider = scope.ServiceProvider;
            //    using var dbContext = (DbContext)provider.GetRequiredService(options.DbContextType);
            //    options.ConnectionString = dbContext.Database.GetDbConnection().ConnectionString;
            //}
        }
    }
}
