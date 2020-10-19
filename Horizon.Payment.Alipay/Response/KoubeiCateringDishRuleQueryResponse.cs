﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishRuleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRuleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 规则的返回集合
        /// </summary>
        [JsonPropertyName("kb_dish_rule_info_list")]
        public List<KbdishRuleInfo> KbDishRuleInfoList { get; set; }
    }
}
