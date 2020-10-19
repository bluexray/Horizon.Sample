﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.WechatPay.V3.Response
{
    /// <summary>
    /// 合单下单-APP支付API-返回参数（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.05.21
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_1.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsAppResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预支付交易会话标识
        /// 数字和字母。微信生成的预支付会话标识，用于后续接口调用使用。
        /// 示例值：wx201410272009395522657a690389285100
        /// </summary>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }
    }
}
