using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户信息
        /// </summary>
        [JsonPropertyName("alipay_user_detail")]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}
