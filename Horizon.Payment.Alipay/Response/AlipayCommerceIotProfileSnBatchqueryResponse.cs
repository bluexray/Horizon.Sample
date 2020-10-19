using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotProfileSnBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<ProfileSnDetail> SnList { get; set; }
    }
}
