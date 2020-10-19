using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public List<InvoiceQueryOpenModel> InvoiceInfo { get; set; }
    }
}
