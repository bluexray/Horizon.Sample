using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [JsonPropertyName("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
