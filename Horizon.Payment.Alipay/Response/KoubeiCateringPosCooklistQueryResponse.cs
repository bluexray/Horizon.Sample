﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosCooklistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCooklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜谱列表
        /// </summary>
        [JsonPropertyName("cook_models")]
        public List<PosDishCookModel> CookModels { get; set; }
    }
}
