﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemSecurityQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemSecurityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
