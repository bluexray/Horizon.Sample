using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待圈存明细
        /// </summary>
        [JsonPropertyName("recharge_bills")]
        public List<RechargeBill> RechargeBills { get; set; }
    }
}
