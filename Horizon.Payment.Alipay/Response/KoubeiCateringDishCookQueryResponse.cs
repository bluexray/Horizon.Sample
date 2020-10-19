using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCookQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCookQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜谱list
        /// </summary>
        [JsonPropertyName("kb_cook_list")]
        public List<KbdishCookInfo> KbCookList { get; set; }
    }
}
