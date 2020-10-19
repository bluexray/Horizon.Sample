﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecuritySssssssQueryResponse.
    /// </summary>
    public class AlipaySecuritySssssssQueryResponse : AlipayResponse
    {
        /// <summary>
        /// af
        /// </summary>
        [JsonPropertyName("adfad")]
        public string Adfad { get; set; }
    }
}
