﻿using Horizon.Payment.WechatPay.V3.Response;

namespace Horizon.Payment.WechatPay.V3.Request
{
    /// <summary>
    /// H5下单API（服务商）
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_4.shtml
    /// </summary>
    public class WeChatPayPartnerTransactionsH5Request : IWeChatPayPostRequest<WeChatPayPartnerTransactionsH5Response>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/pay/partner/transactions/h5";
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
