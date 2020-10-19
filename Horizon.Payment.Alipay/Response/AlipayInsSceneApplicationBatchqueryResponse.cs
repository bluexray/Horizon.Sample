using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneApplicationBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投保单列表
        /// </summary>
        [JsonPropertyName("applications")]
        public List<InsApplicationQuery> Applications { get; set; }
    }
}
