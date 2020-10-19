﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppAesGetModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppAesGetModel : AlipayObject
    {
        /// <summary>
        /// 商家应用appId
        /// </summary>
        [JsonPropertyName("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
