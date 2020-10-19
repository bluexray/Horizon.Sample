﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayZmscoreZrankGetResponse.
    /// </summary>
    public class AlipayZmscoreZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻分分段
        /// </summary>
        [JsonPropertyName("zm_score_zrank")]
        public AlipayZmScoreZrankResult ZmScoreZrank { get; set; }
    }
}
