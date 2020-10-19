﻿using Horizon.Payment.WechatPay.V3.Response;

namespace Horizon.Payment.WechatPay.V3.Request
{
    /// <summary>
    /// 关闭订单API
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_6.shtml
    /// </summary>
    public class WeChatPayTransactionsOutTradeNoCloseRequest : IWeChatPayPostRequest<WeChatPayTransactionsOutTradeNoCloseResponse>
    {
        /// <summary>
        /// 商户订单号
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// 示例值：1217752501201407033233368018
        /// </summary>
        public string OutTradeNo { get; set; }

        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/transactions/out-trade-no/{OutTradeNo}/close";
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
