﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
