using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonPropertyName("data")]
        public VulInfo Data { get; set; }
    }
}
