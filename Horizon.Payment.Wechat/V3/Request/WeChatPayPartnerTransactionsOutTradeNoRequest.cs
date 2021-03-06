﻿using Horizon.Payment.WechatPay.V3.Response;

namespace Horizon.Payment.WechatPay.V3.Request
{
    /// <summary>
    /// 查询订单API - 商户订单号查询（服务商）
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_5.shtml
    /// </summary>
    public class WeChatPayPartnerTransactionsOutTradeNoRequest : IWeChatPayGetRequest<WeChatPayPartnerTransactionsOutTradeNoResponse>
    {
        /// <summary>
        /// 服务商户号
        /// 服务商户号，由微信支付生成并下发
        /// 示例值：1230000109
        /// </summary>
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// 子商户的商户号，有微信支付生成并下发。
        /// 示例值：1900000109
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// 示例值：1217752501201407033233368018
        /// </summary>
        public string OutTradeNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/partner/transactions/out-trade-no/{OutTradeNo}?sp_mchid={SpMchId}&sub_mchid={SubMchId}";
        }
    }
}
