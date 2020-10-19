using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoOuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开票资料
        /// </summary>
        [JsonPropertyName("result_set")]
        public ApUserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
