using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [JsonPropertyName("result_set")]
        public SettlementbillOpenApiDTO ResultSet { get; set; }
    }
}
