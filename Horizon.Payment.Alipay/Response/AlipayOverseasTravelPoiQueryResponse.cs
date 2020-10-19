using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝poi查询结果
        /// </summary>
        [JsonPropertyName("poi_query_result")]
        public PoiQueryResult PoiQueryResult { get; set; }
    }
}
