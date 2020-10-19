using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// SinglePayDetail信息
        /// </summary>
        [JsonPropertyName("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
