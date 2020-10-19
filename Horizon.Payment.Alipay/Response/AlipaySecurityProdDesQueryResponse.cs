﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdDesQueryResponse.
    /// </summary>
    public class AlipaySecurityProdDesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("dee")]
        public GavintestNewLeveaOne Dee { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("string")]
        public string String { get; set; }
    }
}
