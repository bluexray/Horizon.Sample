﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsProducerQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsProducerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 生产厂商信息
        /// </summary>
        [JsonPropertyName("producers")]
        public List<ProducerVO> Producers { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
