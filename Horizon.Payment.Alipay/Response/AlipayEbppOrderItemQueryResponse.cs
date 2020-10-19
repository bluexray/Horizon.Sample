using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppOrderItemQueryResponse.
    /// </summary>
    public class AlipayEbppOrderItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单项
        /// </summary>
        [JsonPropertyName("item")]
        public EbppOrderItem Item { get; set; }
    }
}
