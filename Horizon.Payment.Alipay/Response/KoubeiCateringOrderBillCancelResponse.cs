﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillCancelResponse.
    /// </summary>
    public class KoubeiCateringOrderBillCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
