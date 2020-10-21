using System.ComponentModel;

namespace Sms.ChinaMobile.Model
{
    public enum ChinaMobileResult
    {
        [Description("提交成功")]
        Suceess = 1,
        [Description("smsContent为空")]
        Error101 = 101,
        [Description("mobiles为空")]
        Error102 = 102,
        [Description("mobiles为空数组")]
        Error103 = 103,
        [Description("mobiles含有非法号码")]
        Error104 = 104,
        [Description("未进行身份认证或认证失败")]
        Error105 = 105,
        [Description("sign为空")]
        Error106 = 106,
        [Description("其它错误")]
        Error107 = 107,
        [Description("mobiles含有重复号码")]
        Error109 = 109,
        [Description("mobiles中号码数量超限（>5000），应≤5000")]
        Error110 = 110,
        [Description("tempId 为空")]
        Error111 = 111,
        [Description("线程池忙")]
        Error112 = 112,
        [Description("位置错误")]
        Unknown = 9999
    }
}
