using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [JsonPropertyName("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
