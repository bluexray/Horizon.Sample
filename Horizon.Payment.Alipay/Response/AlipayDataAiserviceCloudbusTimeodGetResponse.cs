using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetResponse : AlipayResponse
    {
        /// <summary>
        /// od分时结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<CloudbusTimeOdItem> Result { get; set; }
    }
}
