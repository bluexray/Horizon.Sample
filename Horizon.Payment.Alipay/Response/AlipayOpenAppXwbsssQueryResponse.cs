﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbsssQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }
    }
}
