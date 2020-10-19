﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntarchiveFaceIdentifyResponse.
    /// </summary>
    public class AlipayUserAntarchiveFaceIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 比对分值
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
