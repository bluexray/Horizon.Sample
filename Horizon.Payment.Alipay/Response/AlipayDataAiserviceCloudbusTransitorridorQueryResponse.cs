using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTransitorridorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusTransitResultItem Result { get; set; }
    }
}
