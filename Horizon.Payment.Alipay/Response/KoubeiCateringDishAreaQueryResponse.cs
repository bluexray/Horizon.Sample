using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaQueryResponse.
    /// </summary>
    public class KoubeiCateringDishAreaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回餐区大模型列表
        /// </summary>
        [JsonPropertyName("kb_dish_area_list")]
        public List<KbdishAreaInfo> KbDishAreaList { get; set; }
    }
}
