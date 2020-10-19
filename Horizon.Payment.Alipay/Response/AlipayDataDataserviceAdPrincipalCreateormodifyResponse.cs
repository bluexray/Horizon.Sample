﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }
    }
}
