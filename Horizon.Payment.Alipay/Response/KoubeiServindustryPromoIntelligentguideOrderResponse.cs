using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideOrderResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideOrderResponse : AlipayResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
