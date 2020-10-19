﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorModifyResponse.
    /// </summary>
    public class KoubeiMerchantOperatorModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}
