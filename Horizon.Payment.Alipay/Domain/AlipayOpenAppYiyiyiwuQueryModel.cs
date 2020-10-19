﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("rucan")]
        public string Rucan { get; set; }
    }
}
