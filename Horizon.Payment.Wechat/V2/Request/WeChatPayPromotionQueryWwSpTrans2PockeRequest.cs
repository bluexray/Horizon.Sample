﻿using System.Collections.Generic;
using Horizon.Payment.WechatPay.V2.Response;

namespace Horizon.Payment.WechatPay.V2.Request
{
    /// <summary>
    /// 企业支付 - 查询付款记录 (普通商户)
    /// </summary>
    public class WeChatPayPromotionQueryWwSpTrans2PockeRequest : IWeChatPayCertRequest<WeChatPayPromotionQueryWwSpTrans2PockeResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/querywwsptrans2pocket";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "partner_trade_no", PartnerTradeNo },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}