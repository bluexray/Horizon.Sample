using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointTransQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointTransQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的结果
        /// </summary>
        [JsonPropertyName("trans_info")]
        public List<PointTransInfo> TransInfo { get; set; }
    }
}
