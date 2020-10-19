using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预订单信息
        /// </summary>
        [JsonPropertyName("advance_order")]
        public AdvanceOrder AdvanceOrder { get; set; }
    }
}
