using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sms
{
    public interface ISmsService
    {
        Task<SmsRsp> SendNormalSms(string[] mobiles, string content);

        Task<SmsRsp> SendTemplateSms(string[] mobiles, string templateId, string[] parameters);
    }
}
