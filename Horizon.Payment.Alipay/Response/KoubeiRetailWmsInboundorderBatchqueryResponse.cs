using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 入库通知单列表
        /// </summary>
        [JsonPropertyName("inbound_order_vo_list")]
        public List<InboundOrderVO> InboundOrderVoList { get; set; }
    }
}
