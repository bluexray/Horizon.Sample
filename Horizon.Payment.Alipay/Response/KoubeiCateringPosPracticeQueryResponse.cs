﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 做法模型
        /// </summary>
        [JsonPropertyName("practice_entity_list")]
        public List<PracticeEntity> PracticeEntityList { get; set; }
    }
}
