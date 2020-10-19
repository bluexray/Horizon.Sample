using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [JsonPropertyName("ins_certificate_pagination_list")]
        public InsCertificatePaginationList InsCertificatePaginationList { get; set; }
    }
}
