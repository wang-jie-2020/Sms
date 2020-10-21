using System.Collections.Generic;
using Sms.ChinaMobile.Model;

namespace Sms.ChinaMobile.Services
{
    public interface IChinaMobileClient : ISmsClient
    {
        /// <summary>
        /// 客户端实例化Client类后即可通过该实例调用短信发送等函数
        /// </summary>
        IChinaMobileClient GetInstance();

        /// <summary>
        /// 客户端实例化后必须进行身份认证才能与云MAS平台建立连接，每次连接只需认证一次身份
        /// </summary>
        /// <param name="url">身份认证地址，向客户经理获取</param>
        /// <param name="userAccount">接口账号用户名</param>
        /// <param name="password">接口账号密码</param>
        /// <param name="ecName">企业名称</param>
        /// <returns>true 认证成功 false 认证失败</returns>
        bool Login(string url, string userAccount, string password, string ecName);

        /// <summary>
        /// 普通短信
        /// </summary>
        /// <param name="mobiles">手机号码，每批次限5000个号码</param>
        /// <param name="smsContent">短信内容。如smsContent中存在双引号，请务必使用转义符\在报文中进行转义（使用JSON转换工具转换会自动增加转义符），否则会导致服务端解析报文异常</param>
        /// <param name="addSerial">扩展码。依据申请开户的服务代码匹配类型而定，如为精确匹配，此项填写空字符串（""）；如为模糊匹配，此项可填写空字符串或自定义的扩展码，注：服务代码加扩展码总长度不能超过20位</param>
        /// <param name="smsPriority">优先级。取值1-5，其它值默认为1</param>
        /// <param name="sign">签名编码。在云MAS平台『管理』→『接口管理』→『短信接入用户管理』获取</param>
        /// <param name="msgGroup">消息批次号，32位唯一编码，由字母和数字组成，客户端生成，用于匹配下行短信与回执。如不填，云MAS平台将分配随机值，建议填写</param>
        /// <param name="isMo">是否需要上行</param>
        /// <returns></returns>
        ChinaMobileResult SendDsms(string[] mobiles, string smsContent, string addSerial, int smsPriority, string sign, string msgGroup, bool isMo);

        /// <summary>
        /// 模板短信
        /// </summary>
        /// <param name="mobiles">手机号码，每批次限5000个号码</param>
        /// <param name="tempId">模板ID。在云MAS平台创建，路径：『短信』→『模板短信』→『模板管理』，创建后提交审核，审核通过将获得模板ID</param>
        /// <param name="parameters">模板变量。格式：[“param1”,“param2”]。此参数携带的变量个数必须与模板定义的变量个数保持一致。</param>
        /// <param name="addSerial">扩展码。依据开户时申请的服务代码匹配类型而定，如为精确匹配，此项填写空字符串（""）；如为模糊匹配，此项可填写空字符串或自定义的扩展码，注：服务代码加扩展码总长度不能超过20位</param>
        /// <param name="smsPriority">优先级。取值1-5，其它值默认为1</param>
        /// <param name="sign">签名编码。在云MAS平台『管理』→『接口管理』→『短信接入用户管理』获取</param>
        /// <param name="msgGroup">消息批次号，32位唯一编码，由字母和数字组成，客户端生成，用于匹配下行短信与回执。如不填，云MAS平台将分配随机值，建议填写</param>
        /// <returns></returns>
        ChinaMobileResult SendTsms(string[] mobiles, string tempId, string[] parameters, string addSerial, int smsPriority, string sign, string msgGroup);

        /// <summary>
        /// 获取提交报告
        /// </summary>
        /// <returns></returns>
        List<ChinaMobileSubmitReport> GetSubmitReport();

        /// <summary>
        /// 获取状态报告
        /// </summary>
        /// <returns></returns>
        List<ChinaMobileStatusReport> GetReport();

        /// <summary>
        /// 获取上行短信
        /// </summary>
        /// <returns></returns>
        List<ChinaMobileMo> GetMo();
    }
}
