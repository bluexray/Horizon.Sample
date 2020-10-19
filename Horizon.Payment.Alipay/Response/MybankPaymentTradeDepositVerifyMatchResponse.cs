using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyMatchResponse.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 金额是否匹配
        /// </summary>
        [JsonPropertyName("valid")]
        public bool Valid { get; set; }
    }
}
