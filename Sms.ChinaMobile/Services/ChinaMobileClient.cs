using System;
using System.Collections.Generic;
using Sms.ChinaMobile.Model;
using Sms.ChinaMobile.Services;

namespace Sms.ChinaMobile.Services
{
    public class ChinaMobileClient : IChinaMobileClient
    {
        public IChinaMobileClient GetInstance()
        {
            throw new NotImplementedException();
        }

        public List<ChinaMobileMo> GetMo()
        {
            throw new NotImplementedException();
        }

        public List<ChinaMobileStatusReport> GetReport()
        {
            throw new NotImplementedException();
        }

        public List<ChinaMobileSubmitReport> GetSubmitReport()
        {
            throw new NotImplementedException();
        }

        public bool Login(string url, string userAccount, string password, string ecName)
        {
            throw new NotImplementedException();
        }

        public ChinaMobileResult SendDsms(string[] mobiles, string smsContent, string addSerial, int smsPriority, string sign, string msgGroup, bool isMo)
        {
            throw new NotImplementedException();
        }

        public ChinaMobileResult SendTsms(string[] mobiles, string tempId, string[] parameters, string addSerial, int smsPriority, string sign, string msgGroup)
        {
            throw new NotImplementedException();
        }
    }
}
