﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateAllclientrateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率信息列表
        /// </summary>
        [JsonPropertyName("client_rate_list")]
        public List<ExClientRateVO> ClientRateList { get; set; }
    }
}
