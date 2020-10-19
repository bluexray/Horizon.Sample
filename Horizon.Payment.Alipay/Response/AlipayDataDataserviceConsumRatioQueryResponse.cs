﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceConsumRatioQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceConsumRatioQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 占比数据接口返回数据结构
        /// </summary>
        [JsonPropertyName("ratio_detail")]
        public RatioDetail RatioDetail { get; set; }
    }
}
