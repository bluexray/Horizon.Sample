using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetroodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetroodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
