using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [JsonPropertyName("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
