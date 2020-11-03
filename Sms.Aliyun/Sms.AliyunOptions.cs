using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Sms.Aliyun
{
    public class AliyunOptions
    {
        public string AccessKeyId { get; set; }

        public string AccessKeySecret { get; set; }

        public string Sign { get; set; }
    }

    internal class ConfigureAliyunOptions : IConfigureOptions<AliyunOptions>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public ConfigureAliyunOptions(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public void Configure(AliyunOptions options)
        {
            /*
             *  Do Extra Configure
             *  example:
             *
                    if (options.DbContextType != null)
                    {
                        using var scope = _serviceScopeFactory.CreateScope();
                        var provider = scope.ServiceProvider;
                        using var dbContext = (DbContext)provider.GetRequiredService(options.DbContextType);
                        options.ConnectionString = dbContext.Database.GetDbConnection().ConnectionString;
                    }
             *
             */
        }
    }
}
