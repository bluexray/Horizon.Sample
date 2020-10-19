﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationCombinedQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationCombinedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 复合关系数据
        /// </summary>
        [JsonPropertyName("relation_combined_list")]
        public List<RelationCombinedVO> RelationCombinedList { get; set; }
    }
}
