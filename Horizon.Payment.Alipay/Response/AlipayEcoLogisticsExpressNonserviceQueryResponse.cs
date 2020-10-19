using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressNonserviceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressNonserviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 非服务区区域代码列表
        /// </summary>
        [JsonPropertyName("area_codes")]
        public List<AreaCode> AreaCodes { get; set; }
    }
}
