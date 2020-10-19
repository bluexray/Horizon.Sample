using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持设为起点的站点列表
        /// </summary>
        [JsonPropertyName("support_starts")]
        public List<StationDetailInfo> SupportStarts { get; set; }
    }
}
