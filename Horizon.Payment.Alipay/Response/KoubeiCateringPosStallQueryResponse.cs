﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosStallQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStallQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 未分配档口的菜品数目
        /// </summary>
        [JsonPropertyName("no_set_stall")]
        public long NoSetStall { get; set; }

        /// <summary>
        /// 重复分配档口的菜品数目
        /// </summary>
        [JsonPropertyName("repeat_set_stall")]
        public long RepeatSetStall { get; set; }

        /// <summary>
        /// 档口列表
        /// </summary>
        [JsonPropertyName("stall_model_list")]
        public List<StallModel> StallModelList { get; set; }
    }
}
