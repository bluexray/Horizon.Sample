using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingProductRecommendResponse.
    /// </summary>
    public class AlipayInsMarketingProductRecommendResponse : AlipayResponse
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("products")]
        public List<RecomProduct> Products { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [JsonPropertyName("recom_flow_no")]
        public string RecomFlowNo { get; set; }
    }
}
