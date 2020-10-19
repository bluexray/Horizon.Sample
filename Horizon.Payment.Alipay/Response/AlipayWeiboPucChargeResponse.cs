﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayWeiboPucChargeResponse.
    /// </summary>
    public class AlipayWeiboPucChargeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回页面内容
        /// </summary>
        [JsonPropertyName("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
