using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
