namespace Sms.ChinaMobile.Model
{
    public class ChinaMobileMo
    {
        /// <summary>
        /// 手机号码，每批次携带一个号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 上行短信内容
        /// </summary>
        public string SmsContent { get; set; }

        /// <summary>
        ///  发送时间，格式：yyyy-MM-dd hh24:mm:ss
        /// </summary>
        public string SendTime { get; set; }

        /// <summary>
        /// 上行服务代码
        /// </summary>
        public string AddSerial { get; set; }
    }
}
