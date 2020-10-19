﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorCreateResponse.
    /// </summary>
    public class KoubeiMerchantOperatorCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}
