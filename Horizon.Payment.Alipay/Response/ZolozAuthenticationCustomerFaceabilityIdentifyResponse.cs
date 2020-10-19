using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 能力接口返回值
        /// </summary>
        [JsonPropertyName("biz_info")]
        public FaceAbilityExtInfo BizInfo { get; set; }
    }
}
