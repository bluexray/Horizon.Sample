﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEprintTokenGetResponse.
    /// </summary>
    public class AlipayEcoEprintTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 易联云token
        /// </summary>
        [JsonPropertyName("eprint_token")]
        public string EprintToken { get; set; }
    }
}
