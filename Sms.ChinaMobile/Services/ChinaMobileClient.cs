using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Sms.ChinaMobile.Model;
using Sms.ChinaMobile.Services;

namespace Sms.ChinaMobile.Services
{
    public class ChinaMobileClient : IChinaMobileClient
    {
        private readonly ChinaMobileOptions _options;

        public ChinaMobileClient(IOptions<ChinaMobileOptions> options)
        {
            _options = options.Value;
        }

        public IChinaMobileClient GetInstance()
        {
            throw new NotImplementedException();
        }

        public bool Login(string url, string userAccount, string password, string ecName)
        {
            throw new NotImplementedException();
        }

        public ChinaMobileResult SendDsms(string[] mobiles, string smsContent, string addSerial, int smsPriority, string sign,
            string msgGroup, bool isMo)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("ecName", _options.EcName);
            param.Add("apId", _options.AppId);
            param.Add("mobiles", string.Join(",", mobiles));
            param.Add("content", smsContent);
            param.Add("sign", _options.Sign);
            param.Add("addSerial", _options.AddSerial);

            StringBuilder sb = new StringBuilder();
            sb.Append(param["ecName"]);
            sb.Append(param["apId"]);
            sb.Append(_options.AppSecret);
            sb.Append(param["mobiles"]);
            sb.Append(param["content"]);
            sb.Append(param["sign"]);
            sb.Append(param["addSerial"]);

            param.Add("mac", Md5(sb.ToString()));

            string data = JsonConvert.SerializeObject(param);
            string encode = Base64(data);

            var result = ApiCallerHelper.Execute<ChinaMobileApiResult>(_options.NorSubmitUrl, HttpMethod.Post, encode);

            throw new NotImplementedException();
        }

        public ChinaMobileResult SendTsms(string[] mobiles, string tempId, string[] parameters, string addSerial, int smsPriority,
            string sign, string msgGroup)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("ecName", _options.EcName);
            param.Add("apId", _options.AppId);
            param.Add("templateId", tempId);
            param.Add("mobiles", string.Join(",", mobiles));

            param.Add("params", JsonConvert.SerializeObject(parameters));


            param.Add("sign", _options.Sign);
            param.Add("addSerial", _options.AddSerial);

            StringBuilder sb = new StringBuilder();
            sb.Append(param["ecName"]);
            sb.Append(param["apId"]);
            sb.Append(_options.AppSecret);
            sb.Append(param["templateId"]);
            sb.Append(param["mobiles"]);
            sb.Append(param["params"]);
            sb.Append(param["sign"]);
            sb.Append(param["addSerial"]);

            param.Add("mac", Md5(sb.ToString()));

            string data = JsonConvert.SerializeObject(param);
            string encode = Base64(data);

            var result = ApiCallerHelper.Execute<ChinaMobileApiResult>(_options.TmpSubmitUrl, HttpMethod.Post, encode);

            throw new NotImplementedException();
        }

        public List<ChinaMobileSubmitReport> GetSubmitReport()
        {
            throw new NotImplementedException();
        }

        public List<ChinaMobileStatusReport> GetReport()
        {
            throw new NotImplementedException();
        }

        public List<ChinaMobileMo> GetMo()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        /// 字符串MD5加密
        ///</summary>
        ///<param name="str">要加密的字符串</param>
        ///<param name="charset">编码方式</param>
        ///<returns>密文</returns>
        private string Md5(string str, string charset = "UTF-8")
        {
            byte[] buffer = System.Text.Encoding.GetEncoding(charset).GetBytes(str);
            try
            {
                var check = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hashBuffer = check.ComputeHash(buffer);
                string ret = "";
                foreach (byte a in hashBuffer)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("X");
                    else
                        ret += a.ToString("X");
                }
                return ret.ToLower();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// base64编码
        /// </summary>
        /// <param name="str">内容</param>
        /// <param name="charset">编码方式</param>
        /// <returns></returns>
        private string Base64(string str, string charset = "UTF-8")
        {
            return Convert.ToBase64String(System.Text.Encoding.GetEncoding(charset).GetBytes(str));
        }
    }
}