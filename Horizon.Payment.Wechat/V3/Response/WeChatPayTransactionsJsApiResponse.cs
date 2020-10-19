﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.WechatPay.V3.Response
{
    /// <summary>
    /// JSAPI下单API-返回参数
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_2.shtml
    /// </summary>
    public class WeChatPayTransactionsJsApiResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预支付交易会话标识	
        /// 预支付交易会话标识。
        /// 示例值：wx201410272009395522657a690389285100
        /// </summary>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }
    }
}
