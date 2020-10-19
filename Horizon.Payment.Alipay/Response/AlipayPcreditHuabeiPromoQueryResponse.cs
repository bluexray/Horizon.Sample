﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPromoQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 花呗颜值分
        /// </summary>
        [JsonPropertyName("facescore")]
        public string Facescore { get; set; }
    }
}
