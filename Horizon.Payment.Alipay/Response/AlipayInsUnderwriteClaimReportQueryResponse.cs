using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 案件信息
        /// </summary>
        [JsonPropertyName("reports")]
        public List<InsClaimReport> Reports { get; set; }
    }
}
