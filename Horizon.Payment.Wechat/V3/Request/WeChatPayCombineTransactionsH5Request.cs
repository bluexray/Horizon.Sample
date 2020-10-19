﻿using Horizon.Payment.WechatPay.V3.Response;

namespace Horizon.Payment.WechatPay.V3.Request
{
    /// <summary>
    /// 合单下单-H5支付API（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.06.09
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_9.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsH5Request : IWeChatPayPostRequest<WeChatPayCombineTransactionsH5Response>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/h5";
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
