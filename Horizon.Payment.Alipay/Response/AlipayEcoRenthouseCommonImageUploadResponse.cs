﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommonImageUploadResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommonImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片url地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
