﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("userid")]
        public string Userid { get; set; }
    }
}
