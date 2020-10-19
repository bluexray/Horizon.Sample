﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingLifeAccessQueryResponse.
    /// </summary>
    public class AlipayInsMarketingLifeAccessQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("access")]
        public bool Access { get; set; }
    }
}
