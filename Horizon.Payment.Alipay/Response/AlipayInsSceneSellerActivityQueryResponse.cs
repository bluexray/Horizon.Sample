using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneSellerActivityQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 关于签约查询结果的告知
        /// </summary>
        [JsonPropertyName("ins_seller_activity")]
        public InsSellerActivity InsSellerActivity { get; set; }
    }
}
