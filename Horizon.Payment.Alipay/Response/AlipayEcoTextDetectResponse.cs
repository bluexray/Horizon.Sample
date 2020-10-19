using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoTextDetectResponse.
    /// </summary>
    public class AlipayEcoTextDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<SpiDetectionDetail> Data { get; set; }
    }
}
