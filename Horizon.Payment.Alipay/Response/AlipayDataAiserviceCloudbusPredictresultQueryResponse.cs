using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictresultQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预测线路结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusPredictResult Result { get; set; }
    }
}
