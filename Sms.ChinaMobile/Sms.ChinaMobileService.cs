using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Sms.ChinaMobile.Internal;
using Sms.ChinaMobile.Internal.Model;

namespace Sms.ChinaMobile
{
    public class ChinaMobileService : ISmsService
    {
        private readonly ChinaMobileHttpClient _client;
        private readonly ChinaMobileOptions _options;

        public ChinaMobileService(ChinaMobileHttpClient client, IOptions<ChinaMobileOptions> options)
        {
            _client = client;
            _options = options.Value;
        }

        public async Task<SmsRsp> SendNormalSms(string[] mobiles, string content)
        {
            var input = new ChinaMobileHttpNormalSms
            {
                EcName = _options.EcName,
                ApId = _options.AppId,
                SecretKey = _options.AppSecret,
                Mobiles = mobiles,
                Content = content,
                Sign = _options.Sign,
                AddSerial = _options.AddSerial,
                Url = _options.NorSubmitUrl
            };

            var result = await _client.SendNormalSms(input);

            var rsp = new SmsRsp
            {
                Success = result.Success,
                RspCode = result.Rspcod,
                RspMsg = EnumHelper.GetEnumDesc<ChinaMobileHttpRspCode>(result.Rspcod)
            };

            return rsp;
        }

        public async Task<SmsRsp> SendTemplateSms(string[] mobiles, string templateId, Dictionary<string, string> parameters)
        {
            var input = new ChinaMobileHttpTemplateSms
            {

                EcName = _options.EcName,
                ApId = _options.AppId,
                SecretKey = _options.AppSecret,
                Mobiles = mobiles,
                TemplateId = templateId,
                Params = parameters.Values.ToArray(),
                Sign = _options.Sign,
                AddSerial = _options.AddSerial,
                Url = _options.TmpSubmitUrl
            };

            var result = await _client.SendTemplateSms(input);

            var rsp = new SmsRsp
            {
                Success = result.Success,
                RspCode = result.Rspcod,
                RspMsg = EnumHelper.GetEnumDesc<ChinaMobileHttpRspCode>(result.Rspcod)
            };

            return rsp;
        }
    }
}
