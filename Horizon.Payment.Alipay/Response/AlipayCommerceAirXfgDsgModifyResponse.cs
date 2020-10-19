using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyResponse.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 用户级别
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    }
}
