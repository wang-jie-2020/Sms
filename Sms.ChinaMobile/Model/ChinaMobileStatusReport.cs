namespace Sms.ChinaMobile.Model
{
    public class ChinaMobileStatusReport
    {
        /// <summary>
        /// 短信网关返回的回执结果，说明见附录4.1
        /// </summary>
        public string ReportStatus { get; set; }

        /// <summary>
        ///  手机号码，支持多号码提交的返回结果
        /// </summary>
        public string[] Mobiles { get; set; }

        /// <summary>
        /// 发送时间，格式：yyyy-MM-dd hh24:mm:ss
        /// </summary>
        public string SubmitDate { get; set; }

        /// <summary>
        /// 平台接收时间，格式同上
        /// </summary>
        public string ReceiveDate { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 消息批次号，32位唯一编码，由字母和数字组成，客户端生成，用于匹配下行短信与回执
        /// </summary>
        public string MsgGroup { get; set; }
    }
}
