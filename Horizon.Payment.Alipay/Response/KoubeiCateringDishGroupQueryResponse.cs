﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishGroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 项目列表
        /// </summary>
        [JsonPropertyName("kb_dish_group_list")]
        public List<KbdishGroupInfo> KbDishGroupList { get; set; }
    }
}
