﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialModifyResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
