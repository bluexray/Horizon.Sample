using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
