﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("chucan")]
        public string Chucan { get; set; }
    }
}
